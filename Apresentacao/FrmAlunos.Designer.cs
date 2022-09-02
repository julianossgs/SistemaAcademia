
namespace Academia.Apresentacao
{
    partial class FrmAlunos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCadastro = new System.Windows.Forms.Panel();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btAddImagem = new System.Windows.Forms.Button();
            this.pBoxImagem = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.cBTurma = new System.Windows.Forms.ComboBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.gridAlunos = new System.Windows.Forms.DataGridView();
            this.IdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagem)).BeginInit();
            this.pBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.btRemoverImagem);
            this.pCadastro.Controls.Add(this.btAddImagem);
            this.pCadastro.Controls.Add(this.pBoxImagem);
            this.pCadastro.Controls.Add(this.label9);
            this.pCadastro.Controls.Add(this.txtEmail);
            this.pCadastro.Controls.Add(this.txtTel);
            this.pCadastro.Controls.Add(this.label7);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.label5);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.cBStatus);
            this.pCadastro.Controls.Add(this.cBTurma);
            this.pCadastro.Controls.Add(this.txtAluno);
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(1007, 163);
            this.pCadastro.TabIndex = 0;
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoverImagem.Enabled = false;
            this.btRemoverImagem.Image = global::Academia.Properties.Resources.iconfinder_jee01_27_2184671;
            this.btRemoverImagem.Location = new System.Drawing.Point(893, 78);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(41, 39);
            this.btRemoverImagem.TabIndex = 14;
            this.btRemoverImagem.UseVisualStyleBackColor = true;
            this.btRemoverImagem.Click += new System.EventHandler(this.btRemoverImagem_Click);
            // 
            // btAddImagem
            // 
            this.btAddImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddImagem.Enabled = false;
            this.btAddImagem.Image = global::Academia.Properties.Resources.iconfinder_jee01_26_2184672;
            this.btAddImagem.Location = new System.Drawing.Point(893, 24);
            this.btAddImagem.Name = "btAddImagem";
            this.btAddImagem.Size = new System.Drawing.Size(41, 39);
            this.btAddImagem.TabIndex = 13;
            this.btAddImagem.UseVisualStyleBackColor = true;
            this.btAddImagem.Click += new System.EventHandler(this.btAddImagem_Click);
            // 
            // pBoxImagem
            // 
            this.pBoxImagem.Image = global::Academia.Properties.Resources.sem_foto;
            this.pBoxImagem.Location = new System.Drawing.Point(791, 24);
            this.pBoxImagem.Name = "pBoxImagem";
            this.pBoxImagem.Size = new System.Drawing.Size(86, 93);
            this.pBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagem.TabIndex = 12;
            this.pBoxImagem.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "A -Ativo  /  B - Bloqueado";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(500, 25);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 21);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(131, 105);
            this.txtTel.Mask = "(99) 99999-9999";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(110, 21);
            this.txtTel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aluno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // cBStatus
            // 
            this.cBStatus.Enabled = false;
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cBStatus.Location = new System.Drawing.Point(500, 103);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(44, 23);
            this.cBStatus.TabIndex = 5;
            // 
            // cBTurma
            // 
            this.cBTurma.Enabled = false;
            this.cBTurma.FormattingEnabled = true;
            this.cBTurma.Location = new System.Drawing.Point(500, 61);
            this.cBTurma.Name = "cBTurma";
            this.cBTurma.Size = new System.Drawing.Size(236, 23);
            this.cBTurma.TabIndex = 4;
            // 
            // txtAluno
            // 
            this.txtAluno.Enabled = false;
            this.txtAluno.Location = new System.Drawing.Point(131, 65);
            this.txtAluno.MaxLength = 50;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(232, 21);
            this.txtAluno.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(131, 24);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(57, 22);
            this.txtCod.TabIndex = 0;
            this.txtCod.TabStop = false;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código do Aluno";
            // 
            // pBotoes
            // 
            this.pBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.pBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBotoes.Controls.Add(this.btExcluir);
            this.pBotoes.Controls.Add(this.btFechar);
            this.pBotoes.Controls.Add(this.btImprimir);
            this.pBotoes.Controls.Add(this.btCancelar);
            this.pBotoes.Controls.Add(this.btSalvar);
            this.pBotoes.Controls.Add(this.btNovo);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotoes.Location = new System.Drawing.Point(0, 405);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(1007, 62);
            this.pBotoes.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Location = new System.Drawing.Point(326, 21);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(106, 27);
            this.btExcluir.TabIndex = 0;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(752, 21);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 27);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.Location = new System.Drawing.Point(610, 21);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(106, 27);
            this.btImprimir.TabIndex = 0;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(468, 21);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 27);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(184, 21);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(106, 27);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovo.Location = new System.Drawing.Point(42, 21);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(106, 27);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // gridAlunos
            // 
            this.gridAlunos.AllowUserToAddRows = false;
            this.gridAlunos.AllowUserToDeleteRows = false;
            this.gridAlunos.AllowUserToOrderColumns = true;
            this.gridAlunos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAluno,
            this.NomeAluno,
            this.Telefone,
            this.Email,
            this.Status,
            this.Id_Turma,
            this.Imagem});
            this.gridAlunos.Location = new System.Drawing.Point(59, 209);
            this.gridAlunos.MultiSelect = false;
            this.gridAlunos.Name = "gridAlunos";
            this.gridAlunos.ReadOnly = true;
            this.gridAlunos.RowTemplate.Height = 30;
            this.gridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunos.Size = new System.Drawing.Size(900, 190);
            this.gridAlunos.TabIndex = 2;
            this.gridAlunos.SelectionChanged += new System.EventHandler(this.gridAlunos_SelectionChanged);
            this.gridAlunos.DoubleClick += new System.EventHandler(this.gridAlunos_DoubleClick);
            // 
            // IdAluno
            // 
            this.IdAluno.DataPropertyName = "IdAluno";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdAluno.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdAluno.HeaderText = "ID";
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.ReadOnly = true;
            this.IdAluno.Width = 40;
            // 
            // NomeAluno
            // 
            this.NomeAluno.DataPropertyName = "Aluno";
            this.NomeAluno.HeaderText = "Aluno";
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.ReadOnly = true;
            this.NomeAluno.Width = 220;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle2;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 130;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 210;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // Id_Turma
            // 
            this.Id_Turma.DataPropertyName = "Turma";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id_Turma.DefaultCellStyle = dataGridViewCellStyle5;
            this.Id_Turma.HeaderText = "Turma";
            this.Id_Turma.Name = "Id_Turma";
            this.Id_Turma.ReadOnly = true;
            this.Id_Turma.Width = 200;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "Imagem";
            this.Imagem.HeaderText = "Foto";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Alunos Cadastrados";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(754, 185);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 21);
            this.txtBuscar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBuscar, "Informe o Nome do Aluno");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Buscar";
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 467);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAlunos);
            this.Controls.Add(this.pBotoes);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagem)).EndInit();
            this.pBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Panel pBotoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBStatus;
        private System.Windows.Forms.ComboBox cBTurma;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.PictureBox pBoxImagem;
        private System.Windows.Forms.Button btAddImagem;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Turma;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        public System.Windows.Forms.DataGridView gridAlunos;
    }
}