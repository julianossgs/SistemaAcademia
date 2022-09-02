
namespace Academia.Apresentacao
{
    partial class FrmGestaoEntradas
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
            this.btFechar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.btFechar);
            this.pCadastro.Controls.Add(this.btCancelar);
            this.pCadastro.Controls.Add(this.btAlterar);
            this.pCadastro.Controls.Add(this.txtTipo);
            this.pCadastro.Controls.Add(this.dtSaida);
            this.pCadastro.Controls.Add(this.txtDescricao);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.txtValor);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.label7);
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(542, 264);
            this.pCadastro.TabIndex = 6;
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(363, 217);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 27);
            this.btFechar.TabIndex = 24;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(218, 217);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 27);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Location = new System.Drawing.Point(73, 203);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(106, 41);
            this.btAlterar.TabIndex = 23;
            this.btAlterar.Text = "Confirmar Alteração?";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(297, 116);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 21);
            this.txtTipo.TabIndex = 0;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Saída";
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipo.Visible = false;
            // 
            // dtSaida
            // 
            this.dtSaida.Enabled = false;
            this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaida.Location = new System.Drawing.Point(265, 28);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(132, 21);
            this.dtSaida.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(111, 78);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(305, 21);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(111, 129);
            this.txtValor.MaxLength = 30;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(83, 21);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data";
            // 
            // txtCod
            // 
            this.txtCod.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(111, 26);
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
            this.label2.Location = new System.Drawing.Point(76, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cód\r\n";
            // 
            // FrmGestaoEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 266);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestaoEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Entradas";
            this.Activated += new System.EventHandler(this.FrmGestaoEntradas_Activated);
            this.Load += new System.EventHandler(this.FrmGestaoEntradas_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
    }
}