
namespace Academia.Apresentacao
{
    partial class FrmTurmas
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
            this.pCadastro = new System.Windows.Forms.Panel();
            this.btImprimir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.nUDAlunos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.cBHorario = new System.Windows.Forms.ComboBox();
            this.cBProfessor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.btImprimir);
            this.pCadastro.Controls.Add(this.label8);
            this.pCadastro.Controls.Add(this.txtVagas);
            this.pCadastro.Controls.Add(this.grid);
            this.pCadastro.Controls.Add(this.btExcluir);
            this.pCadastro.Controls.Add(this.btAlterar);
            this.pCadastro.Controls.Add(this.label7);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Controls.Add(this.txtTurma);
            this.pCadastro.Controls.Add(this.label5);
            this.pCadastro.Controls.Add(this.btFechar);
            this.pCadastro.Controls.Add(this.btCancelar);
            this.pCadastro.Controls.Add(this.btSalvar);
            this.pCadastro.Controls.Add(this.btNovo);
            this.pCadastro.Controls.Add(this.nUDAlunos);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Controls.Add(this.cBStatus);
            this.pCadastro.Controls.Add(this.cBHorario);
            this.pCadastro.Controls.Add(this.cBProfessor);
            this.pCadastro.Controls.Add(this.label1);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(1004, 499);
            this.pCadastro.TabIndex = 0;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(716, 463);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(115, 29);
            this.btImprimir.TabIndex = 15;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nº de Vagas Restantes";
            // 
            // txtVagas
            // 
            this.txtVagas.Cursor = System.Windows.Forms.Cursors.No;
            this.txtVagas.Enabled = false;
            this.txtVagas.Location = new System.Drawing.Point(397, 144);
            this.txtVagas.MaxLength = 3;
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(71, 21);
            this.txtVagas.TabIndex = 0;
            this.txtVagas.TabStop = false;
            this.txtVagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVagas.TextChanged += new System.EventHandler(this.txtVagas_TextChanged);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(81, 265);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(827, 172);
            this.grid.TabIndex = 13;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(438, 463);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(115, 29);
            this.btExcluir.TabIndex = 0;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(299, 463);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(115, 29);
            this.btAlterar.TabIndex = 0;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Turmas Cadastradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(81, 25);
            this.txtCod.MaxLength = 3;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(68, 21);
            this.txtCod.TabIndex = 0;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTurma
            // 
            this.txtTurma.Enabled = false;
            this.txtTurma.Location = new System.Drawing.Point(81, 76);
            this.txtTurma.MaxLength = 50;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(268, 21);
            this.txtTurma.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Turma";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(855, 463);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(115, 29);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(577, 463);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 29);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(160, 463);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(115, 29);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(24, 463);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 29);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Nova Turma";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // nUDAlunos
            // 
            this.nUDAlunos.Enabled = false;
            this.nUDAlunos.Location = new System.Drawing.Point(397, 76);
            this.nUDAlunos.Name = "nUDAlunos";
            this.nUDAlunos.Size = new System.Drawing.Size(120, 21);
            this.nUDAlunos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº de Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // cBStatus
            // 
            this.cBStatus.Enabled = false;
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Items.AddRange(new object[] {
            "Ativa",
            "Cancelada",
            "Paralisada"});
            this.cBStatus.Location = new System.Drawing.Point(397, 209);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(252, 23);
            this.cBStatus.TabIndex = 4;
            // 
            // cBHorario
            // 
            this.cBHorario.Enabled = false;
            this.cBHorario.FormattingEnabled = true;
            this.cBHorario.Location = new System.Drawing.Point(81, 209);
            this.cBHorario.Name = "cBHorario";
            this.cBHorario.Size = new System.Drawing.Size(268, 23);
            this.cBHorario.TabIndex = 3;
            // 
            // cBProfessor
            // 
            this.cBProfessor.Enabled = false;
            this.cBProfessor.FormattingEnabled = true;
            this.cBProfessor.Location = new System.Drawing.Point(81, 142);
            this.cBProfessor.Name = "cBProfessor";
            this.cBProfessor.Size = new System.Drawing.Size(268, 23);
            this.cBProfessor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Turmas";
            this.Activated += new System.EventHandler(this.FrmTurmas_Activated);
            this.Load += new System.EventHandler(this.FrmTurmas_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nUDAlunos;
        public System.Windows.Forms.ComboBox cBStatus;
        public System.Windows.Forms.ComboBox cBHorario;
        public System.Windows.Forms.ComboBox cBProfessor;
        public System.Windows.Forms.TextBox txtTurma;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVagas;
        private System.Windows.Forms.Button btImprimir;
    }
}