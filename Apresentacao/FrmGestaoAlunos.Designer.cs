
namespace Academia.Apresentacao
{
    partial class FrmGestaoAlunos
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
            this.pCadastro = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btAddImagem = new System.Windows.Forms.Button();
            this.pBoxImagem = new System.Windows.Forms.PictureBox();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.btRemoverImagem);
            this.pCadastro.Controls.Add(this.btAddImagem);
            this.pCadastro.Controls.Add(this.pBoxImagem);
            this.pCadastro.Controls.Add(this.btFechar);
            this.pCadastro.Controls.Add(this.btCancelar);
            this.pCadastro.Controls.Add(this.btAlterar);
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
            this.pCadastro.Size = new System.Drawing.Size(995, 335);
            this.pCadastro.TabIndex = 1;
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(595, 212);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 27);
            this.btFechar.TabIndex = 13;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(450, 212);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 27);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Location = new System.Drawing.Point(305, 198);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(106, 41);
            this.btAlterar.TabIndex = 12;
            this.btAlterar.Text = "Confirmar Alteração?";
            this.toolTip1.SetToolTip(this.btAlterar, "Confirmar Alteração?");
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
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
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoverImagem.Enabled = false;
            this.btRemoverImagem.Image = global::Academia.Properties.Resources.iconfinder_jee01_27_2184671;
            this.btRemoverImagem.Location = new System.Drawing.Point(907, 78);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(41, 39);
            this.btRemoverImagem.TabIndex = 17;
            this.btRemoverImagem.UseVisualStyleBackColor = true;
            this.btRemoverImagem.Click += new System.EventHandler(this.btRemoverImagem_Click);
            // 
            // btAddImagem
            // 
            this.btAddImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddImagem.Enabled = false;
            this.btAddImagem.Image = global::Academia.Properties.Resources.iconfinder_jee01_26_2184672;
            this.btAddImagem.Location = new System.Drawing.Point(907, 24);
            this.btAddImagem.Name = "btAddImagem";
            this.btAddImagem.Size = new System.Drawing.Size(41, 39);
            this.btAddImagem.TabIndex = 16;
            this.btAddImagem.UseVisualStyleBackColor = true;
            this.btAddImagem.Click += new System.EventHandler(this.btAddImagem_Click);
            // 
            // pBoxImagem
            // 
            this.pBoxImagem.Image = global::Academia.Properties.Resources.sem_foto;
            this.pBoxImagem.Location = new System.Drawing.Point(805, 24);
            this.pBoxImagem.Name = "pBoxImagem";
            this.pBoxImagem.Size = new System.Drawing.Size(86, 93);
            this.pBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagem.TabIndex = 15;
            this.pBoxImagem.TabStop = false;
            // 
            // FrmGestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 253);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Alunos";
            this.Load += new System.EventHandler(this.FrmGestaoAlunos_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.Button btAddImagem;
        private System.Windows.Forms.PictureBox pBoxImagem;
    }
}