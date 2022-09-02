
namespace Academia.Apresentacao
{
    partial class FrmGestaoProdutos
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
            this.label10 = new System.Windows.Forms.Label();
            this.cBFornecedor = new System.Windows.Forms.ComboBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
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
            this.pCadastro.Controls.Add(this.label10);
            this.pCadastro.Controls.Add(this.cBFornecedor);
            this.pCadastro.Controls.Add(this.txtEstoque);
            this.pCadastro.Controls.Add(this.label9);
            this.pCadastro.Controls.Add(this.txtPrecoCusto);
            this.pCadastro.Controls.Add(this.label4);
            this.pCadastro.Controls.Add(this.txtUnid);
            this.pCadastro.Controls.Add(this.label3);
            this.pCadastro.Controls.Add(this.txtPrecoVenda);
            this.pCadastro.Controls.Add(this.txtDataCompra);
            this.pCadastro.Controls.Add(this.label7);
            this.pCadastro.Controls.Add(this.label6);
            this.pCadastro.Controls.Add(this.label5);
            this.pCadastro.Controls.Add(this.txtProduto);
            this.pCadastro.Controls.Add(this.txtCod);
            this.pCadastro.Controls.Add(this.label2);
            this.pCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastro.Location = new System.Drawing.Point(0, 0);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(947, 268);
            this.pCadastro.TabIndex = 3;
            // 
            // btFechar
            // 
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Location = new System.Drawing.Point(573, 230);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 27);
            this.btFechar.TabIndex = 21;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(428, 230);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 27);
            this.btCancelar.TabIndex = 22;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Location = new System.Drawing.Point(283, 216);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(106, 41);
            this.btAlterar.TabIndex = 20;
            this.btAlterar.Text = "Confirmar Alteração?";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Forneçedor";
            // 
            // cBFornecedor
            // 
            this.cBFornecedor.Enabled = false;
            this.cBFornecedor.FormattingEnabled = true;
            this.cBFornecedor.Location = new System.Drawing.Point(701, 24);
            this.cBFornecedor.Name = "cBFornecedor";
            this.cBFornecedor.Size = new System.Drawing.Size(207, 21);
            this.cBFornecedor.TabIndex = 5;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(534, 133);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(83, 20);
            this.txtEstoque.TabIndex = 0;
            this.txtEstoque.TabStop = false;
            this.txtEstoque.Text = "0";
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estoque";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Enabled = false;
            this.txtPrecoCusto.Location = new System.Drawing.Point(534, 61);
            this.txtPrecoCusto.MaxLength = 30;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoCusto.TabIndex = 3;
            this.txtPrecoCusto.Text = "0";
            this.txtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preço de Venda";
            // 
            // txtUnid
            // 
            this.txtUnid.Enabled = false;
            this.txtUnid.Location = new System.Drawing.Point(534, 25);
            this.txtUnid.MaxLength = 30;
            this.txtUnid.Name = "txtUnid";
            this.txtUnid.Size = new System.Drawing.Size(125, 20);
            this.txtUnid.TabIndex = 2;
            this.txtUnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unid";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Enabled = false;
            this.txtPrecoVenda.Location = new System.Drawing.Point(534, 99);
            this.txtPrecoVenda.MaxLength = 30;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.Text = "0";
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Enabled = false;
            this.txtDataCompra.Location = new System.Drawing.Point(136, 99);
            this.txtDataCompra.Mask = "99/99/0000";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(83, 20);
            this.txtDataCompra.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preço de Custo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data da Compra";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(136, 61);
            this.txtProduto.MaxLength = 50;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(232, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(136, 24);
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
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código do Produto\r\n";
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 271);
            this.Controls.Add(this.pCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestaoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Produtos";
            this.Load += new System.EventHandler(this.FrmGestaoProdutos_Load);
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBFornecedor;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
    }
}