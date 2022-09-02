using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Academia.Dados;

namespace Academia.Apresentacao
{
    public partial class FrmGestaoProdutos : Form
    {
        Conexao con = new Conexao();
        public FrmGestaoProdutos()
        {
            InitializeComponent();
        }

        private void FrmGestaoProdutos_Load(object sender, EventArgs e)
        {
            HabilitarCampos();
            CarregarCBFornecedores();
            txtCod.Text = Global.idproduto;
            txtProduto.Text = Global.nomeProduto;
            txtUnid.Text = Global.unidProduto;
            txtDataCompra.Text = Global.dataCompraProduto;
            cBFornecedor.Text = Global.nomeFornecedor;
        }

        private void LimparCampos()
        {
            txtProduto.Clear();
            txtUnid.Clear();
            txtCod.Clear();
            txtEstoque.Clear();
            txtPrecoVenda.Clear();
            txtDataCompra.Clear();
            cBFornecedor.Text = "";
        }

        public void HabilitarCampos()
        {
            txtProduto.Enabled = true;
            txtUnid.Enabled = true;
            txtDataCompra.Enabled = true;
            cBFornecedor.Enabled = true;
            btCancelar.Enabled = true;
           
        } 

        //Preencher comboBox de fornecedores
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

        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarProdutos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdProduto", txtCod.Text);
            Cmd.Parameters.AddWithValue("@Produto", txtProduto.Text);
            Cmd.Parameters.AddWithValue("@Unid", txtUnid.Text);
            Cmd.Parameters.AddWithValue("@DataCompra", txtDataCompra.Text);
            Cmd.Parameters.AddWithValue("@Id_Fornec", cBFornecedor.SelectedValue);
            
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
            Close();
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Cancelar a Edição?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {
                btAlterar.Focus();
            }
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Close();
        }
    }
}
