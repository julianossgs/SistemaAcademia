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
using Academia.Relatorios;

namespace Academia.Apresentacao
{
    public partial class FrmProdutos : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarCBFornecedores();
            ListarProdutos();
        }

        private void LimparCampos()
        {
            txtProduto.Clear();
            txtUnid.Clear();
            txtCod.Clear();
            txtPrecoVenda.Clear();
            txtPrecoCusto.Clear();
            txtDataCompra.Clear();
            cBFornecedor.Text = "";
            txtEstoque.Text = "0,00";
        }

        public void HabilitarCampos()
        {
            txtUnid.Enabled = true;
            txtProduto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtDataCompra.Enabled = true;
            cBFornecedor.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btExcluir.Enabled = true;

            txtProduto.Focus();
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



        //Listar Produtos
        public void ListarProdutos()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarProdutos";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridProdutos.DataSource = Dt;
            con.FecharConexao();
        }

        //buscar Produtos por nome
        private void BuscarProdutoNome()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarProdutoNome";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Produto", txtBuscar.Text);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridProdutos.DataSource = Dt;

            con.FecharConexao();
        }

        //Cód p/ o usuário não digitar letras no textbox
        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Cód p/ o usuário não digitar letras no textbox
        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProdutoNome();
        }

        //botão Novo
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        //botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == string.Empty)
            {
                MessageBox.Show("Informe o Produto!");
                txtProduto.Focus();
                return;
            }

            if (txtUnid.Text ==string.Empty)
            {
                MessageBox.Show("Informe a Unidade!");
                txtUnid.Focus();
                return;
            }

            if (txtPrecoVenda.Text == string.Empty)
            {
                MessageBox.Show("Informe o Preço de Venda!");
                txtPrecoVenda.Focus();
                return;
            }

            if (txtDataCompra.Text == string.Empty)
            {
                MessageBox.Show("Informe a Data da Compra!");
                txtDataCompra.Focus();
                return;
            }
            if (cBFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Voçê precisa cadastrar um Forneçedor!");
                Close();
            }

            //Cód p/ Salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirProdutos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Produto", txtProduto.Text);
            Cmd.Parameters.AddWithValue("@Unid", txtUnid.Text);
            Cmd.Parameters.AddWithValue("@Estoque",Convert.ToDecimal(txtEstoque.Text));
            Cmd.Parameters.AddWithValue("@PrecoCusto", Convert.ToDecimal(txtPrecoCusto.Text));
            Cmd.Parameters.AddWithValue("@PrecoVenda", Convert.ToDecimal(txtPrecoVenda.Text));
            Cmd.Parameters.AddWithValue("@DataCompra", txtDataCompra.Text);
            Cmd.Parameters.AddWithValue("@Id_Fornec", cBFornecedor.SelectedValue);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();
            
            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            ListarProdutos();

        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (gridProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Não Registros no banco de dados para exclusão!");
                return;
            }
            //obtendo o valor da 1ª linha do grid p/ exclusão
            id = gridProdutos.CurrentRow.Cells["IdProduto"].Value.ToString();
            txtProduto.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();

            //extraindo Aluno para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spListarProdutoNome";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@Produto", txtProduto.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.nomeProduto = Convert.ToString(reader["Produto"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir o Produto : " + Global.nomeProduto, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirProdutos";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdProduto", id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!");
                LimparCampos();
                ListarProdutos();
            }
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btNovo.Focus();
        }

        //botão Imprimir
        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelProdutos frmRelProdutos = new FrmRelProdutos();
            frmRelProdutos.ShowDialog();
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Evento de selecionar na gridview
        private void gridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            id = gridProdutos.CurrentRow.Cells[0].Value.ToString();
            txtCod.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
            txtUnid.Text = gridProdutos.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = gridProdutos.CurrentRow.Cells[3].Value.ToString();
            txtPrecoCusto.Text = gridProdutos.CurrentRow.Cells[4].Value.ToString();
            txtPrecoVenda.Text = gridProdutos.CurrentRow.Cells[5].Value.ToString();
            txtDataCompra.Text = gridProdutos.CurrentRow.Cells[6].Value.ToString();
            cBFornecedor.Text = gridProdutos.CurrentRow.Cells[7].Value.ToString();
        }

        //Evento de duplo click na gridview
        private void gridProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (Global.chamadaProdutos != "estoque")
            {
                Global.idproduto = gridProdutos.CurrentRow.Cells[0].Value.ToString();
                Global.nomeProduto = gridProdutos.CurrentRow.Cells[1].Value.ToString();
                Global.precoVendaProduto = Convert.ToDecimal(gridProdutos.CurrentRow.Cells[5].Value.ToString());
                Global.estoqueProduto = gridProdutos.CurrentRow.Cells[3].Value.ToString();
                Global.unidProduto = gridProdutos.CurrentRow.Cells[2].Value.ToString();
                Global.precoCustoProduto = Convert.ToDecimal(gridProdutos.CurrentRow.Cells[4].Value.ToString());
                Global.dataCompraProduto = gridProdutos.CurrentRow.Cells[6].Value.ToString();
                Global.nomeFornecedor = gridProdutos.CurrentRow.Cells[7].Value.ToString();

                Close();

                FrmGestaoProdutos frmGestao = new FrmGestaoProdutos();
                frmGestao.ShowDialog();
            }

            if (Global.chamadaProdutos == "estoque")
            {
                Global.idproduto = gridProdutos.CurrentRow.Cells[0].Value.ToString();
                Global.nomeProduto = gridProdutos.CurrentRow.Cells[1].Value.ToString();
                Global.estoqueProduto = gridProdutos.CurrentRow.Cells[3].Value.ToString();
                Global.unidProduto = gridProdutos.CurrentRow.Cells[2].Value.ToString();
                Global.precoCustoProduto = Convert.ToDecimal(gridProdutos.CurrentRow.Cells[4].Value.ToString());
               
                Global.dataCompraProduto = gridProdutos.CurrentRow.Cells[6].Value.ToString();
                Global.nomeFornecedor = gridProdutos.CurrentRow.Cells[7].Value.ToString();

                Close();
            }
        }
    }
}
