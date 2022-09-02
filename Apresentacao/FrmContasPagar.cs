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
    public partial class FrmContasPagar : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmContasPagar()
        {
            InitializeComponent();
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
            CarregarCBFornecedores();
        }

        //Métodos
        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtSaida.Enabled = true;
            cBFornecedor.Enabled = true;
            btSalvar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            cBFornecedor.Text = "Selecione o Forneçedor";
        }

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

        public void BuscarData()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarContasPagar";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial", Convert.ToDateTime(dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dtFinal.Value));
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridContasPagar.DataSource = Dt;
            con.FecharConexao();
            Totalizar();
        }

        //Método de Totalizar
        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridContasPagar.Rows)
            {
                total += Convert.ToDecimal(linha.Cells["Valor"].Value);
            }

            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            txtDescricao.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe a Descrição!");
                txtDescricao.Focus();
                return;
            }
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Informe o Valor!");
                txtValor.Focus();
                return;
            }

            //Cód p/ Salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirContasPagar";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dtSaida.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd.Parameters.AddWithValue("@Id_Fornec", cBFornecedor.SelectedValue);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            BuscarData();
        }

        private void btPagarConta_Click(object sender, EventArgs e)
        {
            if (gridContasPagar.Rows.Count == 0)
            {
                MessageBox.Show("Não há Registros no banco de dados!");
                return;
            }

            if (gridContasPagar.Rows.Count >= 1)
            {
                //obtendo o valor da 1ª linha do grid p/ exclusão
                id = gridContasPagar.CurrentRow.Cells["IdContasPagar"].Value.ToString();
               // txtDescricao.Text = gridContasPagar.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = gridContasPagar.CurrentRow.Cells[4].Value.ToString();

                //extraindo o valor da Contas a pagar para exclusão
                con.AbrirConexao();
                SqlCommand CmdExtrair = new SqlCommand();
                CmdExtrair.Connection = con.Con;
                CmdExtrair.CommandText = "spListarContasPagarValor";
                CmdExtrair.CommandType = CommandType.StoredProcedure;
                CmdExtrair.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
                SqlDataReader reader;
                reader = CmdExtrair.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.valorContasPagar = Convert.ToDecimal(reader["Valor"]);
                    }

                }

                var result = MessageBox.Show("Deseja Pagar o Valor : " + Global.valorContasPagar, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    con.AbrirConexao();
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = con.Con;
                    Cmd.CommandText = "spExcluirContasPagar";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@IdContasPagar", id);
                    Cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    MessageBox.Show("A Conta foi paga com sucesso!");
                    LimparCampos();
                    BuscarData();
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btNovo.Focus();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelContasPagar frmRelContasPagar = new FrmRelContasPagar();
            frmRelContasPagar.ShowDialog();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridContasPagar_SelectionChanged(object sender, EventArgs e)
        {
            txtCod.Text = gridContasPagar.CurrentRow.Cells[0].Value.ToString();
            dtSaida.Text = gridContasPagar.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = gridContasPagar.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = gridContasPagar.CurrentRow.Cells[4].Value.ToString();
            cBFornecedor.Text = gridContasPagar.CurrentRow.Cells[5].Value.ToString();
        }

        private void gridContasPagar_DoubleClick(object sender, EventArgs e)
        {
            Global.idcontaspagar = gridContasPagar.CurrentRow.Cells[0].Value.ToString();
            Global.dataContasPagar = Convert.ToDateTime(gridContasPagar.CurrentRow.Cells[1].Value.ToString());
            Global.tipoContasPagar = gridContasPagar.CurrentRow.Cells[2].Value.ToString();
            Global.descricaoContasPagar = gridContasPagar.CurrentRow.Cells[3].Value.ToString();
            Global.valorContasPagar = Convert.ToDecimal(gridContasPagar.CurrentRow.Cells[4].Value.ToString());
            Global.nomeFornecedor = gridContasPagar.CurrentRow.Cells[5].Value.ToString();

            FrmGestaoContasPagar frmGestaoContasPagar = new FrmGestaoContasPagar();
            frmGestaoContasPagar.ShowDialog();
        }
    }
}
