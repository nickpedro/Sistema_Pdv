namespace Sistema_Pdv
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelEntradaSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos1,
            this.MenuMovimentacoes,
            this.MenuRelDespesas,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 27);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionario,
            this.MenuClientes,
            this.MenuUsuarios,
            this.MenuCargo,
            this.MenuFornecedor});
            this.MenuCadastro.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(111, 23);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // MenuProdutos1
            // 
            this.MenuProdutos1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos2,
            this.MenuEstoque});
            this.MenuProdutos1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProdutos1.Name = "MenuProdutos1";
            this.MenuProdutos1.Size = new System.Drawing.Size(101, 23);
            this.MenuProdutos1.Text = "Produtos";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoCaixa,
            this.MenuLancaVenda,
            this.MenuEntradaSaida,
            this.MenuDespesas});
            this.MenuMovimentacoes.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(151, 23);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuRelDespesas
            // 
            this.MenuRelDespesas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelProdutos,
            this.MenuRelVendas,
            this.MenuRelMovimento,
            this.MenuRelEntradaSaida,
            this.despesasToolStripMenuItem1});
            this.MenuRelDespesas.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRelDespesas.Name = "MenuRelDespesas";
            this.MenuRelDespesas.Size = new System.Drawing.Size(111, 23);
            this.MenuRelDespesas.Text = "Relatório";
            // 
            // MenuSair
            // 
            this.MenuSair.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(61, 23);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(198, 24);
            this.MenuFuncionario.Text = "Funcionários";
            this.MenuFuncionario.Click += new System.EventHandler(this.MenuFuncionario_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(198, 24);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(198, 24);
            this.MenuUsuarios.Text = "Usuários";
            // 
            // MenuCargo
            // 
            this.MenuCargo.Name = "MenuCargo";
            this.MenuCargo.Size = new System.Drawing.Size(198, 24);
            this.MenuCargo.Text = "Cargo";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(198, 24);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuProdutos2
            // 
            this.MenuProdutos2.Name = "MenuProdutos2";
            this.MenuProdutos2.Size = new System.Drawing.Size(158, 24);
            this.MenuProdutos2.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(158, 24);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuFluxoCaixa
            // 
            this.MenuFluxoCaixa.Name = "MenuFluxoCaixa";
            this.MenuFluxoCaixa.Size = new System.Drawing.Size(248, 24);
            this.MenuFluxoCaixa.Text = "Fluxo de Caixa";
            // 
            // MenuLancaVenda
            // 
            this.MenuLancaVenda.Name = "MenuLancaVenda";
            this.MenuLancaVenda.Size = new System.Drawing.Size(248, 24);
            this.MenuLancaVenda.Text = "Lançar Venda";
            // 
            // MenuEntradaSaida
            // 
            this.MenuEntradaSaida.Name = "MenuEntradaSaida";
            this.MenuEntradaSaida.Size = new System.Drawing.Size(248, 24);
            this.MenuEntradaSaida.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(248, 24);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelProdutos
            // 
            this.MenuRelProdutos.Name = "MenuRelProdutos";
            this.MenuRelProdutos.Size = new System.Drawing.Size(288, 24);
            this.MenuRelProdutos.Text = "Rel / Produtos";
            // 
            // MenuRelVendas
            // 
            this.MenuRelVendas.Name = "MenuRelVendas";
            this.MenuRelVendas.Size = new System.Drawing.Size(288, 24);
            this.MenuRelVendas.Text = "Rel / Vendas";
            // 
            // MenuRelMovimento
            // 
            this.MenuRelMovimento.Name = "MenuRelMovimento";
            this.MenuRelMovimento.Size = new System.Drawing.Size(288, 24);
            this.MenuRelMovimento.Text = "Rel / Movimento";
            // 
            // MenuRelEntradaSaida
            // 
            this.MenuRelEntradaSaida.Name = "MenuRelEntradaSaida";
            this.MenuRelEntradaSaida.Size = new System.Drawing.Size(288, 24);
            this.MenuRelEntradaSaida.Text = "Rel / Entrada e Saída";
            // 
            // despesasToolStripMenuItem1
            // 
            this.despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            this.despesasToolStripMenuItem1.Size = new System.Drawing.Size(288, 24);
            this.despesasToolStripMenuItem1.Text = "Despesas ";
            // 
            // img04
            // 
            this.img04.Image = global::Sistema_Pdv.Properties.Resources.nota_de_dolar;
            this.img04.Location = new System.Drawing.Point(470, 286);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(296, 200);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::Sistema_Pdv.Properties.Resources.dinheiro_de_volta1;
            this.img02.Location = new System.Drawing.Point(507, 86);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(171, 159);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::Sistema_Pdv.Properties.Resources.despesas;
            this.img03.Location = new System.Drawing.Point(200, 312);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(246, 190);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 2;
            this.img03.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::Sistema_Pdv.Properties.Resources.analise_de_dados;
            this.img01.Location = new System.Drawing.Point(129, 66);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(335, 220);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos1;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuCargo;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos2;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLancaVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaida;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelMovimento;
        private System.Windows.Forms.ToolStripMenuItem MenuRelEntradaSaida;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem1;
    }
}

