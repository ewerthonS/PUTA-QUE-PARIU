
namespace FarmaTec
{
    partial class frmRelatorioEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioEstoque));
            this.dtRelatório = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasRetirada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovoAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacaoEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacaoSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatório)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtRelatório
            // 
            this.dtRelatório.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRelatório.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.NomeProduto,
            this.preco,
            this.qtde,
            this.ValorTotal});
            this.dtRelatório.Location = new System.Drawing.Point(308, 168);
            this.dtRelatório.Name = "dtRelatório";
            this.dtRelatório.Size = new System.Drawing.Size(734, 433);
            this.dtRelatório.TabIndex = 5;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Código";
            this.CodProduto.Name = "CodProduto";
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Width = 200;
            // 
            // preco
            // 
            this.preco.HeaderText = "Valor unitário";
            this.preco.Name = "preco";
            this.preco.Width = 130;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.Width = 130;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 130;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBuscar.Controls.Add(this.txtProduto);
            this.pnlBuscar.Controls.Add(this.lblProduto);
            this.pnlBuscar.Controls.Add(this.lblPeriodo);
            this.pnlBuscar.Controls.Add(this.dateTimePicker1);
            this.pnlBuscar.Controls.Add(this.lblRelatorio);
            this.pnlBuscar.Controls.Add(this.btnGerarRelatorio);
            this.pnlBuscar.Location = new System.Drawing.Point(12, 36);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(1137, 114);
            this.pnlBuscar.TabIndex = 4;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(294, 74);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(287, 20);
            this.txtProduto.TabIndex = 5;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(295, 56);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(55, 16);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(7, 56);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(130, 16);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Selecione o período";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.Location = new System.Drawing.Point(3, 6);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(186, 24);
            this.lblRelatorio.TabIndex = 1;
            this.lblRelatorio.Text = "Relatório de Estoque";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(1003, 67);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(118, 38);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendasCaixa,
            this.menuVendasRetirada});
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(56, 20);
            this.menuVendas.Text = "Vendas";
            // 
            // menuVendasCaixa
            // 
            this.menuVendasCaixa.Name = "menuVendasCaixa";
            this.menuVendasCaixa.Size = new System.Drawing.Size(117, 22);
            this.menuVendasCaixa.Text = "Caixa";
            // 
            // menuVendasRetirada
            // 
            this.menuVendasRetirada.Name = "menuVendasRetirada";
            this.menuVendasRetirada.Size = new System.Drawing.Size(117, 22);
            this.menuVendasRetirada.Text = "Retirada";
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultaProdutos,
            this.menuConsultaClientes});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(66, 20);
            this.menuConsulta.Text = "Consulta";
            // 
            // menuConsultaProdutos
            // 
            this.menuConsultaProdutos.Name = "menuConsultaProdutos";
            this.menuConsultaProdutos.Size = new System.Drawing.Size(122, 22);
            this.menuConsultaProdutos.Text = "Produtos";
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(122, 22);
            this.menuConsultaClientes.Text = "Clientes";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes,
            this.menuCadastroFuncionarios,
            this.menuCadastroFornecedores});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroClientes.Text = "Clientes";
            // 
            // menuCadastroFuncionarios
            // 
            this.menuCadastroFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoAcesso,
            this.menuEditarCadastro,
            this.menuAlterarSenha});
            this.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios";
            this.menuCadastroFuncionarios.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFuncionarios.Text = "Funcionários";
            // 
            // menuNovoAcesso
            // 
            this.menuNovoAcesso.Name = "menuNovoAcesso";
            this.menuNovoAcesso.Size = new System.Drawing.Size(154, 22);
            this.menuNovoAcesso.Text = "Novo Acesso";
            // 
            // menuEditarCadastro
            // 
            this.menuEditarCadastro.Name = "menuEditarCadastro";
            this.menuEditarCadastro.Size = new System.Drawing.Size(154, 22);
            this.menuEditarCadastro.Text = "Editar Cadastro";
            // 
            // menuAlterarSenha
            // 
            this.menuAlterarSenha.Name = "menuAlterarSenha";
            this.menuAlterarSenha.Size = new System.Drawing.Size(154, 22);
            this.menuAlterarSenha.Text = "Alterar Senha";
            // 
            // menuCadastroFornecedores
            // 
            this.menuCadastroFornecedores.Name = "menuCadastroFornecedores";
            this.menuCadastroFornecedores.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFornecedores.Text = "Fornecedores";
            // 
            // menuMovimentacao
            // 
            this.menuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentacaoEntrada,
            this.menuMovimentacaoSaida});
            this.menuMovimentacao.Name = "menuMovimentacao";
            this.menuMovimentacao.Size = new System.Drawing.Size(99, 20);
            this.menuMovimentacao.Text = "Movimentação";
            // 
            // menuMovimentacaoEntrada
            // 
            this.menuMovimentacaoEntrada.Name = "menuMovimentacaoEntrada";
            this.menuMovimentacaoEntrada.Size = new System.Drawing.Size(159, 22);
            this.menuMovimentacaoEntrada.Text = "Entrada Estoque";
            // 
            // menuMovimentacaoSaida
            // 
            this.menuMovimentacaoSaida.Name = "menuMovimentacaoSaida";
            this.menuMovimentacaoSaida.Size = new System.Drawing.Size(159, 22);
            this.menuMovimentacaoSaida.Text = "Saida Estoque";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelatorioFinanceiro,
            this.menuRelatorioFluxo,
            this.menuRelatorioVendas,
            this.menuRelatorioEstoque});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuRelatorioFinanceiro
            // 
            this.menuRelatorioFinanceiro.Name = "menuRelatorioFinanceiro";
            this.menuRelatorioFinanceiro.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioFinanceiro.Text = "Financeiro";
            // 
            // menuRelatorioFluxo
            // 
            this.menuRelatorioFluxo.Name = "menuRelatorioFluxo";
            this.menuRelatorioFluxo.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioFluxo.Text = "Fluxo de Caixa";
            // 
            // menuRelatorioVendas
            // 
            this.menuRelatorioVendas.Name = "menuRelatorioVendas";
            this.menuRelatorioVendas.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioVendas.Text = "Vendas";
            // 
            // menuRelatorioEstoque
            // 
            this.menuRelatorioEstoque.Name = "menuRelatorioEstoque";
            this.menuRelatorioEstoque.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioEstoque.Text = "Estoque";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendas,
            this.menuConsulta,
            this.menuCadastro,
            this.menuMovimentacao,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 61;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1231, 472);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 62;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRelatorioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dtRelatório);
            this.Controls.Add(this.pnlBuscar);
            this.Name = "frmRelatorioEstoque";
            this.Text = "frmRelatorioEstoque";
            this.Load += new System.EventHandler(this.frmRelatorioEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatório)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRelatório;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuVendasCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuVendasRetirada;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuNovoAcesso;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarSenha;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacaoEntrada;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacaoSaida;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioFluxo;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioVendas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnSair;
    }
}