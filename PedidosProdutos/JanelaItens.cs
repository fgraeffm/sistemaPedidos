using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPedidos {
	public partial class JanelaItens : Form {
		public static Action AtualizarItens;
		private TipoJanela tipoJanela;
		private string pedidoNumero;

		public JanelaItens(string pedidoNumero, string itemCodigo = "", TipoJanela tJanela = TipoJanela.Novo) {
			InitializeComponent();
			tipoJanela = tJanela;
			this.pedidoNumero = pedidoNumero;

			if (tipoJanela == TipoJanela.Novo) {
				Text = "Novo Item";
			} else {
				Text = "Editar Item";
				txtItemCodigo.Enabled = false;
				DataTable itemData = new DataTable();
				SQLiteDBConnector.SQLSelectData("SELECT * FROM itens WHERE codigo='" + itemCodigo + "'", ref itemData);
				if(itemData.Rows.Count > 0) {
					DataRow row = itemData.Rows[0];
					txtItemCodigo.Text = row["codigo"].ToString();
					txtItemQuantidade.Text = row["quantidade"].ToString();
					txtItemValor.Text = row["valorUnitario"].ToString();
					txtItemDesconto.Text = row["desconto"].ToString();
					AtualizarValorTotal();
				} else {
					this.Close();
				}
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnConfirmar_Click(object sender, EventArgs e) {
			string itemCodigo = txtItemCodigo.Text;
			int itemQuantidade;
			float itemValor;
			float itemDesconto;

			if (!int.TryParse(txtItemQuantidade.Text, out itemQuantidade)) {
				itemQuantidade = 0;
			}
			if (!float.TryParse(txtItemValor.Text, out itemValor)) {
				itemValor = 0;
			}
			if (!float.TryParse(txtItemDesconto.Text, out itemDesconto)) {
				itemDesconto = 0;
			}

			if (tipoJanela == TipoJanela.Novo) {
				if (string.IsNullOrEmpty(itemCodigo)) {
					return;
				}

				DataTable item = new DataTable();
				SQLiteDBConnector.SQLSelectData("SELECT * FROM itens WHERE codigo='" + txtItemCodigo.Text + "'", ref item);

				
				if (item.Rows.Count > 0) {
					MessageBox.Show("O Item já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string query = "INSERT INTO itens (pedidoNumero, codigo, quantidade, valorUnitario, desconto) VALUES('" +
					pedidoNumero + "','" + itemCodigo + "','" + itemQuantidade + "','" + itemValor + "','" + itemDesconto + "')";
				SQLiteDBConnector.SQLCommandNonQuery(query);
			} else {
				string query = "UPDATE itens SET quantidade='"+itemQuantidade+"', valorUnitario='"+itemValor+"', desconto='"+itemDesconto+"' WHERE codigo='"+itemCodigo+"'";
				SQLiteDBConnector.SQLCommandNonQuery(query);
			}

			AtualizarItens.Invoke();
			this.Close();
		}

		private void txtItemValor_KeyPress(object sender, KeyPressEventArgs e) {
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8 && ch != 46) {
				e.Handled = true;
			}
		}

		private void txtItemDesconto_KeyPress(object sender, KeyPressEventArgs e) {
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8 && ch != 46) {
				e.Handled = true;
			}
		}

		private void txtItemQuantidade_KeyPress(object sender, KeyPressEventArgs e) {
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8) {
				e.Handled = true;
			}
		}

		private void AtualizarValorTotal() {
			int quantidade;
			float valor;
			float desconto;
			if(!int.TryParse(txtItemQuantidade.Text, out  quantidade)) {
				quantidade = 0;
			}
			if(!float.TryParse(txtItemValor.Text, out valor)) {
				valor = 0;
			}
			if(!float.TryParse(txtItemDesconto.Text, out desconto)) {
				desconto = 0;
			}

			float valorTotal = quantidade * (valor - (valor * (desconto / 100)));
			labelValorTotal.Text = "R$" + valorTotal.ToString("n2");
		}

		private void txtItemValor_TextChanged(object sender, EventArgs e) {
			AtualizarValorTotal();
		}

		private void txtItemQuantidade_TextChanged(object sender, EventArgs e) {
			AtualizarValorTotal();
		}

		private void txtItemDesconto_TextChanged(object sender, EventArgs e) {
			AtualizarValorTotal();
		}
	}
}
