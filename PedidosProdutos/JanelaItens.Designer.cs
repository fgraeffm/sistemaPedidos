
namespace SistemaPedidos {
	partial class JanelaItens {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.txtItemCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtItemQuantidade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelValorTotal = new System.Windows.Forms.Label();
			this.txtItemDesconto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtItemValor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(332, 319);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 49);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(466, 319);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(105, 49);
			this.btnConfirmar.TabIndex = 14;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// txtItemCodigo
			// 
			this.txtItemCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtItemCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtItemCodigo.Location = new System.Drawing.Point(172, 12);
			this.txtItemCodigo.MaxLength = 7;
			this.txtItemCodigo.Name = "txtItemCodigo";
			this.txtItemCodigo.Size = new System.Drawing.Size(289, 29);
			this.txtItemCodigo.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 32);
			this.label1.TabIndex = 8;
			this.label1.Text = "Código:";
			// 
			// txtItemQuantidade
			// 
			this.txtItemQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtItemQuantidade.Location = new System.Drawing.Point(172, 67);
			this.txtItemQuantidade.Name = "txtItemQuantidade";
			this.txtItemQuantidade.Size = new System.Drawing.Size(289, 29);
			this.txtItemQuantidade.TabIndex = 17;
			this.txtItemQuantidade.TextChanged += new System.EventHandler(this.txtItemQuantidade_TextChanged);
			this.txtItemQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantidade_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 32);
			this.label2.TabIndex = 16;
			this.label2.Text = "Quantidade:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 32);
			this.label3.TabIndex = 18;
			this.label3.Text = "Valor:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 32);
			this.label4.TabIndex = 19;
			this.label4.Text = "Desconto:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(12, 229);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 32);
			this.label5.TabIndex = 20;
			this.label5.Text = "Valor Total:";
			// 
			// labelValorTotal
			// 
			this.labelValorTotal.AutoSize = true;
			this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelValorTotal.Location = new System.Drawing.Point(172, 229);
			this.labelValorTotal.Name = "labelValorTotal";
			this.labelValorTotal.Size = new System.Drawing.Size(93, 32);
			this.labelValorTotal.TabIndex = 21;
			this.labelValorTotal.Text = "R$0,00";
			// 
			// txtItemDesconto
			// 
			this.txtItemDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtItemDesconto.Location = new System.Drawing.Point(172, 177);
			this.txtItemDesconto.Name = "txtItemDesconto";
			this.txtItemDesconto.Size = new System.Drawing.Size(106, 29);
			this.txtItemDesconto.TabIndex = 22;
			this.txtItemDesconto.TextChanged += new System.EventHandler(this.txtItemDesconto_TextChanged);
			this.txtItemDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemDesconto_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(284, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 32);
			this.label6.TabIndex = 23;
			this.label6.Text = "%";
			// 
			// txtItemValor
			// 
			this.txtItemValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtItemValor.Location = new System.Drawing.Point(172, 125);
			this.txtItemValor.Name = "txtItemValor";
			this.txtItemValor.Size = new System.Drawing.Size(106, 29);
			this.txtItemValor.TabIndex = 24;
			this.txtItemValor.TextChanged += new System.EventHandler(this.txtItemValor_TextChanged);
			this.txtItemValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemValor_KeyPress);
			// 
			// JanelaItens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 381);
			this.Controls.Add(this.txtItemValor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtItemDesconto);
			this.Controls.Add(this.labelValorTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtItemQuantidade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.txtItemCodigo);
			this.Controls.Add(this.label1);
			this.Name = "JanelaItens";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Novo Item";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.TextBox txtItemCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtItemQuantidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelValorTotal;
		private System.Windows.Forms.TextBox txtItemDesconto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtItemValor;
	}
}