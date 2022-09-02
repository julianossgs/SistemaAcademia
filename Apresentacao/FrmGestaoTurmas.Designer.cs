
namespace Academia.Apresentacao
{
    partial class FrmGestaoTurmas
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBHorario = new System.Windows.Forms.ComboBox();
            this.cBProfessor = new System.Windows.Forms.ComboBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.nUDAlunos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.cBHorario);
            this.pCadastro.Controls.Add(this.cBProfessor);
            this.pCadastro.Controls.Add(this.txtTurma);
            this.pCadastro.Controls.Add(this.label5);
            this.pCadastro.Controls.Add(this.btFechar);
            this.pCadastro.Controls.Add(this.btCancelar);
            this.pCadastro.Controls.Add(this.btAlterar);
            this.pCadastro.Controls.Add(this.nUDAlunos);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Controls.Add(this.cBStatus);
            this.pCadastro.Controls.Add(this.label1);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(722, 309);
            this.pCadastro.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(395, 22);
            this.txtCod.MaxLength = 3;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(73, 21);
            this.txtCod.TabIndex = 0;
            this.txtCod.TabStop = false;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código";
            // 
            // cBHorario
            // 
            this.cBHorario.Enabled = false;
            this.cBHorario.FormattingEnabled = true;
            this.cBHorario.Location = new System.Drawing.Point(29, 157);
            this.cBHorario.Name = "cBHorario";
            this.cBHorario.Size = new System.Drawing.Size(268, 23);
            this.cBHorario.TabIndex = 10;
            // 
            // cBProfessor
            // 
            this.cBProfessor.Enabled = false;
            this.cBProfessor.FormattingEnabled = true;
            this.cBProfessor.Location = new System.Drawing.Point(29, 90);
            this.cBProfessor.Name = "cBProfessor";
            this.cBProfessor.Size = new System.Drawing.Size(268, 23);
            this.cBProfessor.TabIndex = 9;
            // 
            // txtTurma
            // 
            this.txtTurma.Enabled = false;
            this.txtTurma.Location = new System.Drawing.Point(29, 22);
            this.txtTurma.MaxLength = 50;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(268, 21);
            this.txtTurma.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Turma";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(491, 260);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(126, 29);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(290, 260);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(126, 29);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(89, 260);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(126, 29);
            this.btAlterar.TabIndex = 0;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // nUDAlunos
            // 
            this.nUDAlunos.Enabled = false;
            this.nUDAlunos.Location = new System.Drawing.Point(348, 90);
            this.nUDAlunos.Name = "nUDAlunos";
            this.nUDAlunos.Size = new System.Drawing.Size(120, 21);
            this.nUDAlunos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº de Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 137);
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
            this.cBStatus.Location = new System.Drawing.Point(348, 155);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(217, 23);
            this.cBStatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // FrmGestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 330);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao de Turmas";
            this.Activated += new System.EventHandler(this.FrmGestaoTurmas_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestaoTurmas_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGestaoTurmas_FormClosed);
            this.Load += new System.EventHandler(this.FrmGestaoTurmas_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDAlunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBHorario;
        private System.Windows.Forms.ComboBox cBProfessor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.Button btFechar;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.TextBox txtTurma;
    }
}