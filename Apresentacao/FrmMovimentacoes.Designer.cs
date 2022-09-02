
namespace Academia.Apresentacao
{
    partial class FrmMovimentacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pBuscar = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBEntradaSaida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridMovimentacoes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBuscar.Controls.Add(this.dtFinal);
            this.pBuscar.Controls.Add(this.dtInicial);
            this.pBuscar.Controls.Add(this.label6);
            this.pBuscar.Controls.Add(this.label5);
            this.pBuscar.Controls.Add(this.cBEntradaSaida);
            this.pBuscar.Controls.Add(this.label4);
            this.pBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBuscar.Location = new System.Drawing.Point(0, 0);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(826, 106);
            this.pBuscar.TabIndex = 0;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(548, 38);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(122, 21);
            this.dtFinal.TabIndex = 5;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(376, 38);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(122, 21);
            this.dtInicial.TabIndex = 4;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data Inicial";
            // 
            // cBEntradaSaida
            // 
            this.cBEntradaSaida.FormattingEnabled = true;
            this.cBEntradaSaida.Items.AddRange(new object[] {
            "Todos",
            "Entrada",
            "Saida"});
            this.cBEntradaSaida.Location = new System.Drawing.Point(38, 36);
            this.cBEntradaSaida.Name = "cBEntradaSaida";
            this.cBEntradaSaida.Size = new System.Drawing.Size(162, 23);
            this.cBEntradaSaida.TabIndex = 1;
            this.cBEntradaSaida.SelectedIndexChanged += new System.EventHandler(this.cBEntradaSaida_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entradas / Saídas";
            // 
            // gridMovimentacoes
            // 
            this.gridMovimentacoes.AllowUserToAddRows = false;
            this.gridMovimentacoes.AllowUserToDeleteRows = false;
            this.gridMovimentacoes.AllowUserToOrderColumns = true;
            this.gridMovimentacoes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMov,
            this.Data,
            this.Tipo,
            this.Movimento,
            this.Valor});
            this.gridMovimentacoes.Location = new System.Drawing.Point(12, 137);
            this.gridMovimentacoes.MultiSelect = false;
            this.gridMovimentacoes.Name = "gridMovimentacoes";
            this.gridMovimentacoes.ReadOnly = true;
            this.gridMovimentacoes.RowTemplate.Height = 30;
            this.gridMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovimentacoes.Size = new System.Drawing.Size(787, 150);
            this.gridMovimentacoes.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblSaida);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(582, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 110);
            this.panel1.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(132, 89);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(132, 49);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(14, 15);
            this.lblSaida.TabIndex = 4;
            this.lblSaida.Text = "0";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(132, 16);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(14, 15);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saídas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entradas";
            // 
            // IdMov
            // 
            this.IdMov.DataPropertyName = "IdMov";
            this.IdMov.HeaderText = "ID";
            this.IdMov.Name = "IdMov";
            this.IdMov.ReadOnly = true;
            this.IdMov.Width = 60;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 90;
            // 
            // Movimento
            // 
            this.Movimento.DataPropertyName = "Descricao";
            this.Movimento.HeaderText = "Descrição";
            this.Movimento.Name = "Movimento";
            this.Movimento.ReadOnly = true;
            this.Movimento.Width = 330;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 120;
            // 
            // FrmMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridMovimentacoes);
            this.Controls.Add(this.pBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMovimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentacoes";
            this.Load += new System.EventHandler(this.FrmMovimentacoes_Load);
            this.pBuscar.ResumeLayout(false);
            this.pBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBuscar;
        private System.Windows.Forms.DataGridView gridMovimentacoes;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBEntradaSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}