using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPedidos {
	public partial class JanelaPedidos : Form {
		public static Action AtualizarLista;
		private TipoJanela tipoJanela;

		public JanelaPedidos(string pedidoNumero = "", TipoJanela tJanela = TipoJanela.Novo) {
			InitializeComponent();
			tipoJanela = tJanela;

			if(tipoJanela == TipoJanela.Novo) {
				Text = "Novo Pedido";
			} else {
				Text = "Editar Pedido";
				txtPedidoNumero.Enabled = false;
				DataTable pedidoData = new DataTable();
				SQLiteDBConnector.SQLSelectData("SELECT * FROM pedidos WHERE numero='" + pedidoNumero + "'", ref pedidoData);
				if(pedidoData.Rows.Count > 0) {
					DataRow row = pedidoData.Rows[0];
					txtPedidoNumero.Text = row["numero"].ToString();
					datePedidoData.Value = DateTime.Parse(row["data"].ToString());
					txtPedidoDescricao.Text = row["descricao"].ToString();
				} else {
					this.Close();
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnConfirmar_Click(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(txtPedidoNumero.Text) || string.IsNullOrEmpty(datePedidoData.Text) || string.IsNullOrEmpty(txtPedidoDescricao.Text)) {
				return;
			}

			int pedidoNumero = int.Parse(txtPedidoNumero.Text);
			string pedidoData = datePedidoData.Text;
			string pedidoDesc = txtPedidoDescricao.Text;

			if (tipoJanela == TipoJanela.Novo) {
				DataTable pedido = new DataTable();
				SQLiteDBConnector.SQLSelectData("SELECT * FROM pedidos WHERE numero='" + txtPedidoNumero.Text + "'", ref pedido);

				if(pedido.Rows.Count > 0) {
					MessageBox.Show("O Pedido já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string query = "INSERT INTO pedidos (numero, data, descricao, situacao) VALUES('" + pedidoNumero + "', '" + pedidoData + "', '" + pedidoDesc + "', 'Em análise')";
				SQLiteDBConnector.SQLCommandNonQuery(query);
			} else {
				string query = "UPDATE pedidos SET data='"+pedidoData+"', descricao='"+pedidoDesc+"' WHERE numero='"+txtPedidoNumero.Text+"'";
				SQLiteDBConnector.SQLCommandNonQuery(query);
			}

			AtualizarLista.Invoke();
			this.Close();
		}

		private void txtPedidoNumero_KeyPress(object sender, KeyPressEventArgs e) {
			char ch = e.KeyChar;
			if(!char.IsDigit(ch) && ch != 8) {
				e.Handled = true;
			}
		}
	}
}
