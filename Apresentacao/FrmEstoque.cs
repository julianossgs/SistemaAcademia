using Academia.Dados;
using Academia.Relatorios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmEstoque : Form
    {
        Conexao con = new Conexao();
        //string id;
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            CarregarCBFornecedores();
            btAddProdutos.Focus();
           
        }

        private void LimparCampos()
        {
            txtProduto.Clear();
            txtUnid.Clear();
            txtCod.Clear();
            txtQuant.Clear();
            txtPrecoCusto.Clear();
            txtDataCompra.Clear();
        }

        public void HabilitarCampos()
        {
           
            txtQuant.Enabled = true;
            txtDataCompra.Enabled = true;
            cBFornecedor.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btAddProdutos.Focus();

        } 

        public void DesabilitarCampos()
        {
            txtQuant.Enabled = false;
            txtDataCompra.Enabled = false;
            cBFornecedor.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
           
        }

        //Carregar combo Box Fornecedores
        private void CarregarCBFornecedores()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarFornecedores";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            cBFornecedor.DataSource = Dt;
            cBFornecedor.ValueMember = "IdFornec";
            cBFornecedor.DisplayMember = "Fornecedor";
            con.FecharConexao();
        }

        private void btAddProdutos_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            Global.chamadaProdutos = "estoque";

            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();
        }

        private void FrmEstoque_Activated(object sender, EventArgs e)
        {
            txtCod.Text = Global.idproduto;
            txtProduto.Text = Global.nomeProduto;
            txtPrecoCusto.Text = Global.precoCustoProduto.ToString();
            txtQuant.Text = Global.precoVendaProduto.ToString();
            txtUnid.Text = Global.unidProduto;
            txtDataCompra.Text = Global.dataCompraProduto;
            txtEstoque.Text = Global.estoqueProduto;
        }

        //botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == string.Empty)
            {
                MessageBox.Show("Selecione um Produto! ", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btAddProdutos.Focus();
                return;
            }

            if (txtQuant.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma Quantidade para o Produto! ", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuant.Focus();
                return;
            }

            //cód p/ alterar os produtos p/ o estoque
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarProdutosEstoque";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdProduto", Global.idproduto);
           // Cmd.Parameters.AddWithValue("@IdProduto", txtCod.Text);
            Cmd.Parameters.AddWithValue("@DataCompra", txtDataCompra.Text);
            Cmd.Parameters.AddWithValue("@Estoque", Convert.ToDecimal(txtEstoque.Text) + Convert.ToDecimal(txtQuant.Text));
            Cmd.Parameters.AddWithValue("@PrecoCusto", Convert.ToDecimal(txtPrecoCusto.Text));
            Cmd.Parameters.AddWithValue("@Id_Fornec", cBFornecedor.SelectedValue);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Pedido realizado com sucesso!");
            LimparCampos();
            DesabilitarCampos();
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Cancelar o Pedido?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {
                btAddProdutos.Focus();
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelEstoque frmRelEstoque = new FrmRelEstoque();
            frmRelEstoque.ShowDialog();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Evento p/ não digitar letras no text box
        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
