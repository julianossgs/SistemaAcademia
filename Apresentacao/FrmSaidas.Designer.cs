
namespace Academia.Apresentacao
{
    partial class FrmSaidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCadastro = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.gridSaidas = new System.Windows.Forms.DataGridView();
            this.IdSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMov = new System.Windows.Forms.Label();
            this.pCadastro.SuspendLayout();
            this.pBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.pCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCadastro.Controls.Add(this.txtTipo);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.label5);
            this.pCadastro.Controls.Add(this.label1);
            this.pCadastro.Controls.Add(this.dtFinal);
            this.pCadastro.Controls.Add(this.dtInicial);
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
            this.pCadastro.Size = new System.Drawing.Size(888, 195);
            this.pCadastro.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(316, 156);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 21);
            this.txtTipo.TabIndex = 0;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Saída";
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Consulta por Datas";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(579, 113);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(132, 21);
            this.dtFinal.TabIndex = 18;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(579, 70);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(132, 21);
            this.dtInicial.TabIndex = 17;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // dtSaida
            // 
            this.dtSaida.Enabled = false;
            this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaida.Location = new System.Drawing.Point(111, 70);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(132, 21);
            this.dtSaida.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(111, 113);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(305, 21);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(111, 156);
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
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 76);
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
            this.pBotoes.Location = new System.Drawing.Point(0, 457);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(888, 62);
            this.pBotoes.TabIndex = 14;
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Location = new System.Drawing.Point(316, 28);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(106, 27);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(764, 28);
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
            this.btImprimir.Location = new System.Drawing.Point(615, 28);
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
            this.btCancelar.Location = new System.Drawing.Point(466, 28);
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
            this.btSalvar.Location = new System.Drawing.Point(168, 28);
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
            this.btNovo.Location = new System.Drawing.Point(19, 28);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(106, 27);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // gridSaidas
            // 
            this.gridSaidas.AllowUserToAddRows = false;
            this.gridSaidas.AllowUserToDeleteRows = false;
            this.gridSaidas.AllowUserToOrderColumns = true;
            this.gridSaidas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridSaidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSaida,
            this.Data,
            this.Tipo,
            this.Descricao,
            this.Valor});
            this.gridSaidas.Location = new System.Drawing.Point(140, 201);
            this.gridSaidas.MultiSelect = false;
            this.gridSaidas.Name = "gridSaidas";
            this.gridSaidas.ReadOnly = true;
            this.gridSaidas.RowTemplate.Height = 30;
            this.gridSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSaidas.Size = new System.Drawing.Size(595, 212);
            this.gridSaidas.TabIndex = 15;
            this.gridSaidas.SelectionChanged += new System.EventHandler(this.gridSaidas_SelectionChanged);
            this.gridSaidas.DoubleClick += new System.EventHandler(this.gridSaidas_DoubleClick);
            // 
            // IdSaida
            // 
            this.IdSaida.DataPropertyName = "IdSaida";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdSaida.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdSaida.HeaderText = "ID";
            this.IdSaida.Name = "IdSaida";
            this.IdSaida.ReadOnly = true;
            this.IdSaida.Width = 60;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 110;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(666, 428);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 15);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            // 
            // lblMov
            // 
            this.lblMov.AutoSize = true;
            this.lblMov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMov.ForeColor = System.Drawing.Color.Blue;
            this.lblMov.Image = global::Academia.Properties.Resources._1481080293_Money;
            this.lblMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMov.Location = new System.Drawing.Point(137, 428);
            this.lblMov.Name = "lblMov";
            this.lblMov.Size = new System.Drawing.Size(242, 16);
            this.lblMov.TabIndex = 18;
            this.lblMov.Text = "        Ir para o Movimento do Caixa";
            this.lblMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMov.Click += new System.EventHandler(this.lblMov_Click);
            // 
            // FrmSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 519);
            this.Controls.Add(this.lblMov);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridSaidas);
            this.Controls.Add(this.pBotoes);
            this.Controls.Add(this.pCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saídas";
            this.Load += new System.EventHandler(this.FrmSaidas_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            this.pBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.Panel pBotoes;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView gridSaidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label lblMov;
        private System.Windows.Forms.Button btExcluir;
    }
}