
namespace Academia.Apresentacao
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.pCadastro = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDowp = new System.Windows.Forms.NumericUpDown();
            this.btListar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pListar = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDowp)).BeginInit();
            this.pListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.label9);
            this.pCadastro.Controls.Add(this.txtStatus);
            this.pCadastro.Controls.Add(this.label8);
            this.pCadastro.Controls.Add(this.label7);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.NUDowp);
            this.pCadastro.Controls.Add(this.btListar);
            this.pCadastro.Controls.Add(this.btLimpar);
            this.pCadastro.Controls.Add(this.btExcluir);
            this.pCadastro.Controls.Add(this.btSalvar);
            this.pCadastro.Controls.Add(this.btNovo);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.txtSenha);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Controls.Add(this.txtUserName);
            this.pCadastro.Controls.Add(this.label1);
            this.pCadastro.Controls.Add(this.txtNome);
            this.pCadastro.Location = new System.Drawing.Point(12, 12);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(909, 190);
            this.pCadastro.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "B - Bloqueado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "A - Ativado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Legenda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nível do Usuário";
            // 
            // NUDowp
            // 
            this.NUDowp.Location = new System.Drawing.Point(525, 94);
            this.NUDowp.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDowp.Name = "NUDowp";
            this.NUDowp.Size = new System.Drawing.Size(41, 21);
            this.NUDowp.TabIndex = 5;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(680, 150);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(111, 23);
            this.btListar.TabIndex = 6;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Enabled = false;
            this.btLimpar.Location = new System.Drawing.Point(539, 150);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(111, 23);
            this.btLimpar.TabIndex = 0;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(398, 150);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(111, 23);
            this.btExcluir.TabIndex = 0;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(257, 150);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(111, 23);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(116, 150);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(111, 23);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(152, 94);
            this.txtSenha.MaxLength = 4;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(216, 21);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName\r\n";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(152, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(216, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Usuário";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(152, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pListar
            // 
            this.pListar.BackColor = System.Drawing.Color.Gainsboro;
            this.pListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pListar.Controls.Add(this.btSair);
            this.pListar.Controls.Add(this.gridUsuarios);
            this.pListar.Location = new System.Drawing.Point(64, 246);
            this.pListar.Name = "pListar";
            this.pListar.Size = new System.Drawing.Size(789, 224);
            this.pListar.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.BackgroundImage = global::Academia.Properties.Resources.iconfinder_cross_48_10298;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.Location = new System.Drawing.Point(716, 180);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(39, 37);
            this.btSair.TabIndex = 1;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.AllowUserToOrderColumns = true;
            this.gridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NomeUsuario,
            this.UserName,
            this.SenhaUsuario,
            this.StatusUsuario,
            this.NivelUsuario});
            this.gridUsuarios.Location = new System.Drawing.Point(27, 14);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowTemplate.Height = 30;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(728, 160);
            this.gridUsuarios.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "Cód";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.DataPropertyName = "NomeUsuario";
            this.NomeUsuario.HeaderText = "Nome";
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            this.NomeUsuario.Width = 200;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 140;
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.DataPropertyName = "SenhaUsuario";
            this.SenhaUsuario.HeaderText = "Senha";
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.ReadOnly = true;
            // 
            // StatusUsuario
            // 
            this.StatusUsuario.DataPropertyName = "StatusUsuario";
            this.StatusUsuario.HeaderText = "Status";
            this.StatusUsuario.Name = "StatusUsuario";
            this.StatusUsuario.ReadOnly = true;
            this.StatusUsuario.Width = 120;
            // 
            // NivelUsuario
            // 
            this.NivelUsuario.DataPropertyName = "NivelUsuario";
            this.NivelUsuario.HeaderText = "Nivel Usuario";
            this.NivelUsuario.Name = "NivelUsuario";
            this.NivelUsuario.ReadOnly = true;
            this.NivelUsuario.Width = 120;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(61, 228);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(215, 15);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "LISTA DE USUÁRIOS CADASTRADOS";
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "A - Ativo",
            "B - Bloqueado",
            "D -Desligado"});
            this.txtStatus.Location = new System.Drawing.Point(425, 12);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(226, 23);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.Text = "Selecione o Status do Usuário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "D -Desligado";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 482);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.pListar);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUÁRIOS DO SISTEMA";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDowp)).EndInit();
            this.pListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pListar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown NUDowp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtStatus;
    }
}