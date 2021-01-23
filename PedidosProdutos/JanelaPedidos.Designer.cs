
namespace SistemaPedidos {
	partial class JanelaPedidos {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.datePedidoData = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPedidoDescricao = new System.Windows.Forms.TextBox();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtPedidoNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pedido #:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(331, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Data:";
			// 
			// datePedidoData
			// 
			this.datePedidoData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.datePedidoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.datePedidoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePedidoData.Location = new System.Drawing.Point(411, 34);
			this.datePedidoData.Name = "datePedidoData";
			this.datePedidoData.Size = new System.Drawing.Size(160, 29);
			this.datePedidoData.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Descrição:";
			// 
			// txtPedidoDescricao
			// 
			this.txtPedidoDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPedidoDescricao.Location = new System.Drawing.Point(12, 120);
			this.txtPedidoDescricao.MaxLength = 599;
			this.txtPedidoDescricao.Multiline = true;
			this.txtPedidoDescricao.Name = "txtPedidoDescricao";
			this.txtPedidoDescricao.Size = new System.Drawing.Size(559, 204);
			this.txtPedidoDescricao.TabIndex = 5;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(466, 341);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(105, 49);
			this.btnConfirmar.TabIndex = 6;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(332, 341);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 49);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtPedidoNumero
			// 
			this.txtPedidoNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPedidoNumero.Location = new System.Drawing.Point(139, 34);
			this.txtPedidoNumero.Name = "txtPedidoNumero";
			this.txtPedidoNumero.Size = new System.Drawing.Size(143, 29);
			this.txtPedidoNumero.TabIndex = 8;
			this.txtPedidoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedidoNumero_KeyPress);
			// 
			// JanelaPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 404);
			this.ControlBox = false;
			this.Controls.Add(this.txtPedidoNumero);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.txtPedidoDescricao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.datePedidoData);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "JanelaPedidos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Novo Pedido";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker datePedidoData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtPedidoDescricao;
		private System.Windows.Forms.TextBox txtPedidoNumero;
	}
}