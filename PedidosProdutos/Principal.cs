using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos {
	public partial class Principal : Form {

		private JanelaItens jItens;
		private JanelaPedidos jPedidos;

		public Principal() {
			InitializeComponent();
			JanelaPedidos.AtualizarLista += ChecarEAdicionarPedidosNaLista;
			JanelaItens.AtualizarItens += AtualizarItens;
			panelPedido.Visible = false;
			SQLiteDBConnector.CreateTables();

			ChecarEAdicionarPedidosNaLista();
		}

		private void ChecarEAdicionarPedidosNaLista() {
			listaPedidos.Items.Clear();
			DataTable pedidosData = new DataTable();
			SQLiteDBConnector.SQLSelectData("SELECT * FROM pedidos", ref pedidosData);
			if (pedidosData.Rows.Count > 0) {
				panelPedido.Visible = true;
				foreach (DataRow row in pedidosData.Rows) {
					listaPedidos.Items.Add("#" + row["numero"]);
				}
				listaPedidos.SelectedIndex = 0;
				AtualizarInfoPedido();
			} else {
				panelPedido.Visible = false;
			}
		}

		private void AtualizarItens() {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			listaItens.Rows.Clear();
			DataTable itensData = new DataTable();
			SQLiteDBConnector.SQLSelectData("SELECT * FROM itens WHERE pedidoNumero='"+pedidoNumero+"'", ref itensData);

			if (itensData.Rows.Count > 0) {
				foreach (DataRow row in itensData.Rows) {
					int quantidade;
					float valor;
					float desconto;
					float valorTotal;

					if (!int.TryParse(row["quantidade"].ToString(), out quantidade)) {
						quantidade = 0;
					}
					if (!float.TryParse(row["valorUnitario"].ToString(), out valor)) {
						valor = 0;
					}
					if (!float.TryParse(row["Desconto"].ToString(), out desconto)) {
						desconto = 0;
					}

					valorTotal = quantidade * (valor - (valor * (desconto / 100)));
										
					listaItens.Rows.Add(row["codigo"], quantidade, "R$" + valor.ToString("n2"), desconto.ToString("n2"), "R$" + valorTotal.ToString("n2"));
				}
			} 
		}

		private void AtualizarInfoPedido() {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			DataTable pedidoInfo = new DataTable();
			SQLiteDBConnector.SQLSelectData("SELECT * FROM pedidos WHERE numero='" + pedidoNumero + "'", ref pedidoInfo);
			if (pedidoInfo.Rows.Count > 0) {
				DataRow row = pedidoInfo.Rows[0];				
				labelPedidoNumero.Text = "#" + row["numero"];
				labelPedidoData.Text = row["data"].ToString();
				labelPedidoDesc.Text = row["descricao"].ToString();
				switch (row["situacao"].ToString()) {
					case "Aprovado":
						labelPedidoSituacao.Text = "Aprovado";
						labelPedidoSituacao.BackColor = btnAprovarPedido.BackColor;
						break;
					case "Cancelado":
						labelPedidoSituacao.Text = "Cancelado";
						labelPedidoSituacao.BackColor = btnCancelarPedido.BackColor;
						break;
					default:
						labelPedidoSituacao.Text = "Em análise";
						labelPedidoSituacao.BackColor = SystemColors.ControlDark;
						break;
				}
				AtualizarItens();
			} else {
				MessageBox.Show("Pedido não encontrado", "Procurar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnNovoPedido_Click(object sender, EventArgs e) {
			jPedidos = new JanelaPedidos();
			jPedidos.ShowDialog();
		}

		private void btnEditarPedido_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			jPedidos = new JanelaPedidos(pedidoNumero, TipoJanela.Editar);
			jPedidos.ShowDialog();
		}

		private void btnNovoItem_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			jItens = new JanelaItens(pedidoNumero);
			jItens.ShowDialog();
		}

		private void btnEditarItem_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			string itemCodigo = GetCodigoItemSelecionado();
			jItens = new JanelaItens(pedidoNumero, itemCodigo, TipoJanela.Editar);
			jItens.ShowDialog();
		}

		private void btnExcluirPedido_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();

			//string query = "DELETE FROM pedidos WHERE numero='"+ pedidoNumero + "'";
			string query = "DELETE FROM pedidos";

			SQLiteDBConnector.SQLCommandNonQuery(query);

			ChecarEAdicionarPedidosNaLista();
		}

		public string GetNumeroPedidoSelecionado() {
			return(listaPedidos.SelectedItem.ToString().Replace("#", ""));
		}

		public string GetCodigoItemSelecionado() {
			if(listaItens.SelectedCells.Count > 0) {
				int cellIndex = listaItens.SelectedCells[0].RowIndex;
				return listaItens.Rows[cellIndex].Cells[0].Value.ToString();
			} else if(listaItens.SelectedRows[0].Cells.Count > 0) {
				return listaItens.SelectedRows[0].Cells[0].Value.ToString();
			} else {
				return "";
			}
		}

		private void listaPedidos_SelectedIndexChanged(object sender, EventArgs e) {
			AtualizarInfoPedido();
		}

		private void btnAprovarPedido_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			SQLiteDBConnector.SQLCommandNonQuery("UPDATE pedidos SET situacao='Aprovado' WHERE numero='" + pedidoNumero + "' ");

			labelPedidoSituacao.Text = "Aprovado";
			labelPedidoSituacao.BackColor = btnAprovarPedido.BackColor;
		}

		private void btnCancelarPedido_Click(object sender, EventArgs e) {
			string pedidoNumero = GetNumeroPedidoSelecionado();
			SQLiteDBConnector.SQLCommandNonQuery("UPDATE pedidos SET situacao='Cancelado' WHERE numero='" + pedidoNumero + "' ");

			labelPedidoSituacao.Text = "Cancelado";
			labelPedidoSituacao.BackColor = btnCancelarPedido.BackColor;
		}

		private void btnExcluirItem_Click(object sender, EventArgs e) {
			string itemCodigo = GetCodigoItemSelecionado();

			string query = "DELETE FROM itens WHERE codigo='"+ itemCodigo + "'";

			SQLiteDBConnector.SQLCommandNonQuery(query);

			AtualizarItens();
		}
	}

	public enum TipoJanela {
		Novo,
		Editar
	}
}
