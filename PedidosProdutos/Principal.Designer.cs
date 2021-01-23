
namespace SistemaPedidos {
	partial class Principal {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.listaPedidos = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNovoPedido = new System.Windows.Forms.Button();
			this.btnEditarPedido = new System.Windows.Forms.Button();
			this.btnExcluirPedido = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.labelPedidoSituacao = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelPedidoData = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelPedidoNumero = new System.Windows.Forms.Label();
			this.btnAprovarPedido = new System.Windows.Forms.Button();
			this.btnNovoItem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.listaItens = new System.Windows.Forms.DataGridView();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditarItem = new System.Windows.Forms.Button();
			this.btnCancelarPedido = new System.Windows.Forms.Button();
			this.btnExcluirItem = new System.Windows.Forms.Button();
			this.panelPedido = new System.Windows.Forms.Panel();
			this.labelPedidoDesc = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.listaItens)).BeginInit();
			this.panelPedido.SuspendLayout();
			this.SuspendLayout();
			// 
			// listaPedidos
			// 
			this.listaPedidos.FormattingEnabled = true;
			this.listaPedidos.ItemHeight = 15;
			this.listaPedidos.Location = new System.Drawing.Point(12, 186);
			this.listaPedidos.Name = "listaPedidos";
			this.listaPedidos.Size = new System.Drawing.Size(139, 394);
			this.listaPedidos.TabIndex = 0;
			this.listaPedidos.SelectedIndexChanged += new System.EventHandler(this.listaPedidos_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pedidos";
			// 
			// btnNovoPedido
			// 
			this.btnNovoPedido.Location = new System.Drawing.Point(12, 60);
			this.btnNovoPedido.Name = "btnNovoPedido";
			this.btnNovoPedido.Size = new System.Drawing.Size(139, 36);
			this.btnNovoPedido.TabIndex = 11;
			this.btnNovoPedido.Text = "Novo Pedido";
			this.btnNovoPedido.UseVisualStyleBackColor = true;
			this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
			// 
			// btnEditarPedido
			// 
			this.btnEditarPedido.Location = new System.Drawing.Point(12, 102);
			this.btnEditarPedido.Name = "btnEditarPedido";
			this.btnEditarPedido.Size = new System.Drawing.Size(139, 36);
			this.btnEditarPedido.TabIndex = 12;
			this.btnEditarPedido.Text = "Editar Pedido";
			this.btnEditarPedido.UseVisualStyleBackColor = true;
			this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
			// 
			// btnExcluirPedido
			// 
			this.btnExcluirPedido.Location = new System.Drawing.Point(12, 144);
			this.btnExcluirPedido.Name = "btnExcluirPedido";
			this.btnExcluirPedido.Size = new System.Drawing.Size(139, 36);
			this.btnExcluirPedido.TabIndex = 13;
			this.btnExcluirPedido.Text = "Excluir Pedido";
			this.btnExcluirPedido.UseVisualStyleBackColor = true;
			this.btnExcluirPedido.Click += new System.EventHandler(this.btnExcluirPedido_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(12, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 30);
			this.label8.TabIndex = 8;
			this.label8.Text = "Descrição:";
			// 
			// labelPedidoSituacao
			// 
			this.labelPedidoSituacao.BackColor = System.Drawing.SystemColors.ControlDark;
			this.labelPedidoSituacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPedidoSituacao.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelPedidoSituacao.Location = new System.Drawing.Point(567, 12);
			this.labelPedidoSituacao.Name = "labelPedidoSituacao";
			this.labelPedidoSituacao.Size = new System.Drawing.Size(246, 30);
			this.labelPedidoSituacao.TabIndex = 7;
			this.labelPedidoSituacao.Text = "Em análise";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(458, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 30);
			this.label6.TabIndex = 6;
			this.label6.Text = "Situação:";
			// 
			// labelPedidoData
			// 
			this.labelPedidoData.AutoSize = true;
			this.labelPedidoData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPedidoData.Location = new System.Drawing.Point(301, 12);
			this.labelPedidoData.Name = "labelPedidoData";
			this.labelPedidoData.Size = new System.Drawing.Size(117, 30);
			this.labelPedidoData.TabIndex = 5;
			this.labelPedidoData.Text = "00/00/0000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(231, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 30);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data:";
			// 
			// labelPedidoNumero
			// 
			this.labelPedidoNumero.AutoSize = true;
			this.labelPedidoNumero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPedidoNumero.Location = new System.Drawing.Point(123, 12);
			this.labelPedidoNumero.Name = "labelPedidoNumero";
			this.labelPedidoNumero.Size = new System.Drawing.Size(68, 30);
			this.labelPedidoNumero.TabIndex = 3;
			this.labelPedidoNumero.Text = "00000";
			// 
			// btnAprovarPedido
			// 
			this.btnAprovarPedido.BackColor = System.Drawing.Color.LightGreen;
			this.btnAprovarPedido.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAprovarPedido.Location = new System.Drawing.Point(819, 12);
			this.btnAprovarPedido.Name = "btnAprovarPedido";
			this.btnAprovarPedido.Size = new System.Drawing.Size(170, 86);
			this.btnAprovarPedido.TabIndex = 17;
			this.btnAprovarPedido.Text = "Aprovar Pedido";
			this.btnAprovarPedido.UseVisualStyleBackColor = false;
			this.btnAprovarPedido.Click += new System.EventHandler(this.btnAprovarPedido_Click);
			// 
			// btnNovoItem
			// 
			this.btnNovoItem.Location = new System.Drawing.Point(12, 229);
			this.btnNovoItem.Name = "btnNovoItem";
			this.btnNovoItem.Size = new System.Drawing.Size(105, 50);
			this.btnNovoItem.TabIndex = 14;
			this.btnNovoItem.Text = "Novo Item";
			this.btnNovoItem.UseVisualStyleBackColor = true;
			this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Pedido #:";
			// 
			// listaItens
			// 
			this.listaItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.quantidade,
            this.valorUnitario,
            this.desconto,
            this.valorTotal});
			this.listaItens.Location = new System.Drawing.Point(12, 285);
			this.listaItens.MultiSelect = false;
			this.listaItens.Name = "listaItens";
			this.listaItens.RowTemplate.Height = 25;
			this.listaItens.Size = new System.Drawing.Size(977, 280);
			this.listaItens.TabIndex = 10;
			// 
			// codigo
			// 
			this.codigo.HeaderText = "CÓDIGO";
			this.codigo.Name = "codigo";
			// 
			// quantidade
			// 
			this.quantidade.HeaderText = "QUANTIDADE";
			this.quantidade.Name = "quantidade";
			// 
			// valorUnitario
			// 
			this.valorUnitario.HeaderText = "VALOR UNITÁRIO";
			this.valorUnitario.Name = "valorUnitario";
			// 
			// desconto
			// 
			this.desconto.HeaderText = "DESCONTO";
			this.desconto.Name = "desconto";
			// 
			// valorTotal
			// 
			this.valorTotal.HeaderText = "VALOR TOTAL";
			this.valorTotal.Name = "valorTotal";
			// 
			// btnEditarItem
			// 
			this.btnEditarItem.Location = new System.Drawing.Point(123, 229);
			this.btnEditarItem.Name = "btnEditarItem";
			this.btnEditarItem.Size = new System.Drawing.Size(105, 50);
			this.btnEditarItem.TabIndex = 15;
			this.btnEditarItem.Text = "Editar Item";
			this.btnEditarItem.UseVisualStyleBackColor = true;
			this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
			// 
			// btnCancelarPedido
			// 
			this.btnCancelarPedido.BackColor = System.Drawing.Color.IndianRed;
			this.btnCancelarPedido.Location = new System.Drawing.Point(819, 104);
			this.btnCancelarPedido.Name = "btnCancelarPedido";
			this.btnCancelarPedido.Size = new System.Drawing.Size(170, 86);
			this.btnCancelarPedido.TabIndex = 18;
			this.btnCancelarPedido.Text = "Cancelar Pedido";
			this.btnCancelarPedido.UseVisualStyleBackColor = false;
			this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
			// 
			// btnExcluirItem
			// 
			this.btnExcluirItem.Location = new System.Drawing.Point(234, 229);
			this.btnExcluirItem.Name = "btnExcluirItem";
			this.btnExcluirItem.Size = new System.Drawing.Size(105, 50);
			this.btnExcluirItem.TabIndex = 16;
			this.btnExcluirItem.Text = "Excluir Item";
			this.btnExcluirItem.UseVisualStyleBackColor = true;
			this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
			// 
			// panelPedido
			// 
			this.panelPedido.Controls.Add(this.labelPedidoDesc);
			this.panelPedido.Controls.Add(this.btnExcluirItem);
			this.panelPedido.Controls.Add(this.btnCancelarPedido);
			this.panelPedido.Controls.Add(this.btnEditarItem);
			this.panelPedido.Controls.Add(this.listaItens);
			this.panelPedido.Controls.Add(this.label2);
			this.panelPedido.Controls.Add(this.btnNovoItem);
			this.panelPedido.Controls.Add(this.btnAprovarPedido);
			this.panelPedido.Controls.Add(this.labelPedidoNumero);
			this.panelPedido.Controls.Add(this.label4);
			this.panelPedido.Controls.Add(this.labelPedidoData);
			this.panelPedido.Controls.Add(this.label6);
			this.panelPedido.Controls.Add(this.labelPedidoSituacao);
			this.panelPedido.Controls.Add(this.label8);
			this.panelPedido.Location = new System.Drawing.Point(157, 15);
			this.panelPedido.Name = "panelPedido";
			this.panelPedido.Size = new System.Drawing.Size(999, 579);
			this.panelPedido.TabIndex = 19;
			// 
			// labelPedidoDesc
			// 
			this.labelPedidoDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPedidoDesc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelPedidoDesc.Location = new System.Drawing.Point(12, 104);
			this.labelPedidoDesc.Name = "labelPedidoDesc";
			this.labelPedidoDesc.Size = new System.Drawing.Size(801, 122);
			this.labelPedidoDesc.TabIndex = 19;
			this.labelPedidoDesc.Text = resources.GetString("labelPedidoDesc.Text");
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(296, 295);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(657, 65);
			this.label10.TabIndex = 20;
			this.label10.Text = "Nenhum pedido cadastrado";
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 606);
			this.Controls.Add(this.btnExcluirPedido);
			this.Controls.Add(this.btnEditarPedido);
			this.Controls.Add(this.btnNovoPedido);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listaPedidos);
			this.Controls.Add(this.panelPedido);
			this.Controls.Add(this.label10);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Pedidos";
			((System.ComponentModel.ISupportInitialize)(this.listaItens)).EndInit();
			this.panelPedido.ResumeLayout(false);
			this.panelPedido.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listaPedidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNovoPedido;
		private System.Windows.Forms.Button btnEditarPedido;
		private System.Windows.Forms.Button btnExcluirPedido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelPedidoSituacao;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelPedidoData;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelPedidoNumero;
		private System.Windows.Forms.Button btnAprovarPedido;
		private System.Windows.Forms.Button btnNovoItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView listaItens;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
		private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
		private System.Windows.Forms.Button btnEditarItem;
		private System.Windows.Forms.Button btnCancelarPedido;
		private System.Windows.Forms.Button btnExcluirItem;
		private System.Windows.Forms.Panel panelPedido;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelPedidoDesc;
	}
}

