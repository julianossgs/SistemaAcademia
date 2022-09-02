
namespace Academia.Apresentacao
{
    partial class FrmGestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCadastro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.tbCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.gridProfessores = new System.Windows.Forms.DataGridView();
            this.IdProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCadastro.SuspendLayout();
            this.pBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Controls.Add(this.label1);
            this.pCadastro.Controls.Add(this.txtTel);
            this.pCadastro.Controls.Add(this.txtNome);
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(677, 78);
            this.pCadastro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(503, 38);
            this.txtTel.Mask = "(99) 99999-9999";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(112, 20);
            this.txtTel.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(185, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(70, 38);
            this.txtCod.MaxLength = 3;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(64, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBotoes
            // 
            this.pBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.pBotoes.Controls.Add(this.btFechar);
            this.pBotoes.Controls.Add(this.tbCancelar);
            this.pBotoes.Controls.Add(this.btExcluir);
            this.pBotoes.Controls.Add(this.btAlterar);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotoes.Location = new System.Drawing.Point(0, 369);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(677, 81);
            this.pBotoes.TabIndex = 2;
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(498, 33);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(122, 27);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "Fechar\r\n";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // tbCancelar
            // 
            this.tbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCancelar.Location = new System.Drawing.Point(351, 33);
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Size = new System.Drawing.Size(122, 27);
            this.tbCancelar.TabIndex = 0;
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.UseVisualStyleBackColor = true;
            this.tbCancelar.Click += new System.EventHandler(this.tbCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(204, 33);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(122, 27);
            this.btExcluir.TabIndex = 1;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Location = new System.Drawing.Point(57, 33);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(122, 27);
            this.btAlterar.TabIndex = 0;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // gridProfessores
            // 
            this.gridProfessores.AllowUserToAddRows = false;
            this.gridProfessores.AllowUserToDeleteRows = false;
            this.gridProfessores.AllowUserToOrderColumns = true;
            this.gridProfessores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridProfessores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProf,
            this.NomeProfessor,
            this.Telefone});
            this.gridProfessores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridProfessores.Location = new System.Drawing.Point(97, 84);
            this.gridProfessores.MultiSelect = false;
            this.gridProfessores.Name = "gridProfessores";
            this.gridProfessores.ReadOnly = true;
            this.gridProfessores.RowTemplate.Height = 30;
            this.gridProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfessores.Size = new System.Drawing.Size(471, 279);
            this.gridProfessores.TabIndex = 0;
            this.gridProfessores.SelectionChanged += new System.EventHandler(this.gridProfessores_SelectionChanged);
            // 
            // IdProf
            // 
            this.IdProf.DataPropertyName = "IdProf";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdProf.DefaultCellStyle = dataGridViewCellStyle15;
            this.IdProf.HeaderText = "ID";
            this.IdProf.Name = "IdProf";
            this.IdProf.ReadOnly = true;
            this.IdProf.Width = 80;
            // 
            // NomeProfessor
            // 
            this.NomeProfessor.DataPropertyName = "NomeProfessor";
            this.NomeProfessor.HeaderText = "Nome";
            this.NomeProfessor.Name = "NomeProfessor";
            this.NomeProfessor.ReadOnly = true;
            this.NomeProfessor.Width = 220;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle16;
            this.Telefone.HeaderText = "Tel";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 120;
            // 
            // FrmGestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.gridProfessores);
            this.Controls.Add(this.pBotoes);
            this.Controls.Add(this.pCadastro);
            this.Name = "FrmGestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestaoProfessores";
            this.Load += new System.EventHandler(this.FrmGestaoProfessores_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            this.pBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Panel pBotoes;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button tbCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView gridProfessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}