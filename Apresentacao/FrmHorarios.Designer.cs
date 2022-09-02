
namespace Academia.Apresentacao
{
    partial class FrmHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorarios = new System.Windows.Forms.MaskedTextBox();
            this.gridHorarios = new System.Windows.Forms.DataGridView();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.IdHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).BeginInit();
            this.pBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(137, 57);
            this.txtCod.MaxLength = 2;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(38, 21);
            this.txtCod.TabIndex = 0;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(134, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horários";
            // 
            // txtHorarios
            // 
            this.txtHorarios.Location = new System.Drawing.Point(255, 57);
            this.txtHorarios.Mask = "99:99  \\até  99:99";
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(119, 21);
            this.txtHorarios.TabIndex = 1;
            this.txtHorarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridHorarios
            // 
            this.gridHorarios.AllowUserToAddRows = false;
            this.gridHorarios.AllowUserToDeleteRows = false;
            this.gridHorarios.AllowUserToOrderColumns = true;
            this.gridHorarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridHorarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHorario,
            this.DescricaoHorario});
            this.gridHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridHorarios.Location = new System.Drawing.Point(137, 84);
            this.gridHorarios.MultiSelect = false;
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.ReadOnly = true;
            this.gridHorarios.RowTemplate.Height = 30;
            this.gridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHorarios.Size = new System.Drawing.Size(237, 289);
            this.gridHorarios.TabIndex = 0;
            this.gridHorarios.SelectionChanged += new System.EventHandler(this.gridHorarios_SelectionChanged);
            // 
            // pBotoes
            // 
            this.pBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.pBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBotoes.Controls.Add(this.btFechar);
            this.pBotoes.Controls.Add(this.btExcluir);
            this.pBotoes.Controls.Add(this.btSalvar);
            this.pBotoes.Controls.Add(this.btNovo);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotoes.Location = new System.Drawing.Point(0, 393);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(516, 68);
            this.pBotoes.TabIndex = 5;
            // 
            // btNovo
            // 
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovo.Location = new System.Drawing.Point(19, 14);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(113, 31);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Location = new System.Drawing.Point(139, 14);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(113, 31);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Location = new System.Drawing.Point(259, 14);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(113, 31);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(379, 14);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(113, 31);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // IdHorario
            // 
            this.IdHorario.DataPropertyName = "IdHorario";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdHorario.DefaultCellStyle = dataGridViewCellStyle11;
            this.IdHorario.HeaderText = "ID";
            this.IdHorario.Name = "IdHorario";
            this.IdHorario.ReadOnly = true;
            this.IdHorario.Width = 70;
            // 
            // DescricaoHorario
            // 
            this.DescricaoHorario.DataPropertyName = "DescricaoHorario";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DescricaoHorario.DefaultCellStyle = dataGridViewCellStyle12;
            this.DescricaoHorario.HeaderText = "Horários";
            this.DescricaoHorario.Name = "DescricaoHorario";
            this.DescricaoHorario.ReadOnly = true;
            this.DescricaoHorario.Width = 120;
            // 
            // FrmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 461);
            this.Controls.Add(this.pBotoes);
            this.Controls.Add(this.gridHorarios);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.FrmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            this.pBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHorarios;
        private System.Windows.Forms.DataGridView gridHorarios;
        private System.Windows.Forms.Panel pBotoes;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoHorario;
    }
}