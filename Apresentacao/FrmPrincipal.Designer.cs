
namespace Academia.Apresentacao
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forneçedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoForneçedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosParaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasPagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAcesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 61);
            this.panel1.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(232, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(28, 18);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.Location = new System.Drawing.Point(122, 35);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(16, 18);
            this.lblAcesso.TabIndex = 5;
            this.lblAcesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Acesso";
            // 
            // pbLogado
            // 
            this.pbLogado.Image = global::Academia.Properties.Resources.iconfinder_Ball_Green_345551;
            this.pbLogado.Location = new System.Drawing.Point(10, 16);
            this.pbLogado.Name = "pbLogado";
            this.pbLogado.Size = new System.Drawing.Size(42, 37);
            this.pbLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogado.TabIndex = 2;
            this.pbLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosDoSistemaToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.turmasToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.forneçedoresToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuáriosDoSistemaToolStripMenuItem
            // 
            this.usuáriosDoSistemaToolStripMenuItem.Name = "usuáriosDoSistemaToolStripMenuItem";
            this.usuáriosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.usuáriosDoSistemaToolStripMenuItem.Text = "Usuários do Sistema";
            this.usuáriosDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuáriosDoSistemaToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeProfessoresToolStripMenuItem,
            this.cadastrarNovoProfessorToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // gestãoDeProfessoresToolStripMenuItem
            // 
            this.gestãoDeProfessoresToolStripMenuItem.Name = "gestãoDeProfessoresToolStripMenuItem";
            this.gestãoDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.gestãoDeProfessoresToolStripMenuItem.Text = "Gestão de Professores";
            this.gestãoDeProfessoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProfessoresToolStripMenuItem_Click);
            // 
            // cadastrarNovoProfessorToolStripMenuItem
            // 
            this.cadastrarNovoProfessorToolStripMenuItem.Name = "cadastrarNovoProfessorToolStripMenuItem";
            this.cadastrarNovoProfessorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.cadastrarNovoProfessorToolStripMenuItem.Text = "Cadastrar Novo Professor";
            this.cadastrarNovoProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoProfessorToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovaTurmaToolStripMenuItem});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // cadastrarNovaTurmaToolStripMenuItem
            // 
            this.cadastrarNovaTurmaToolStripMenuItem.Name = "cadastrarNovaTurmaToolStripMenuItem";
            this.cadastrarNovaTurmaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cadastrarNovaTurmaToolStripMenuItem.Text = "Cadastrar Nova Turma";
            this.cadastrarNovaTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovaTurmaToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastrarNovoAlunoToolStripMenuItem
            // 
            this.cadastrarNovoAlunoToolStripMenuItem.Name = "cadastrarNovoAlunoToolStripMenuItem";
            this.cadastrarNovoAlunoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastrarNovoAlunoToolStripMenuItem.Text = "Cadastrar Novo Aluno";
            this.cadastrarNovoAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoAlunoToolStripMenuItem_Click);
            // 
            // forneçedoresToolStripMenuItem
            // 
            this.forneçedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoForneçedorToolStripMenuItem});
            this.forneçedoresToolStripMenuItem.Name = "forneçedoresToolStripMenuItem";
            this.forneçedoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.forneçedoresToolStripMenuItem.Text = "Forneçedores";
            // 
            // cadastrarNovoForneçedorToolStripMenuItem
            // 
            this.cadastrarNovoForneçedorToolStripMenuItem.Name = "cadastrarNovoForneçedorToolStripMenuItem";
            this.cadastrarNovoForneçedorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cadastrarNovoForneçedorToolStripMenuItem.Text = "Cadastrar Novo Forneçedor";
            this.cadastrarNovoForneçedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoForneçedorToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoProdutoToolStripMenuItem,
            this.pedidosParaEstoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarNovoProdutoToolStripMenuItem
            // 
            this.cadastrarNovoProdutoToolStripMenuItem.Name = "cadastrarNovoProdutoToolStripMenuItem";
            this.cadastrarNovoProdutoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.cadastrarNovoProdutoToolStripMenuItem.Text = "Cadastrar Novo Produto";
            this.cadastrarNovoProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoProdutoToolStripMenuItem_Click);
            // 
            // pedidosParaEstoqueToolStripMenuItem
            // 
            this.pedidosParaEstoqueToolStripMenuItem.Name = "pedidosParaEstoqueToolStripMenuItem";
            this.pedidosParaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pedidosParaEstoqueToolStripMenuItem.Text = "Pedidos para Estoque";
            this.pedidosParaEstoqueToolStripMenuItem.Click += new System.EventHandler(this.pedidosParaEstoqueToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planosToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.fluxoDeCaixaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.contasPagasToolStripMenuItem});
            this.financeiroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.planosToolStripMenuItem.Text = "Planos";
            this.planosToolStripMenuItem.Click += new System.EventHandler(this.planosToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            this.movimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.movimentaçãoToolStripMenuItem_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saídasToolStripMenuItem.Text = "Saídas";
            this.saídasToolStripMenuItem.Click += new System.EventHandler(this.saídasToolStripMenuItem_Click);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "Contas a Pagar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contasPagasToolStripMenuItem
            // 
            this.contasPagasToolStripMenuItem.Name = "contasPagasToolStripMenuItem";
            this.contasPagasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.contasPagasToolStripMenuItem.Text = "Contas Pagas";
            this.contasPagasToolStripMenuItem.Click += new System.EventHandler(this.contasPagasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACADEMIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbLogado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosDoSistemaToolStripMenuItem;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forneçedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoForneçedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosParaEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasPagasToolStripMenuItem;
    }
}