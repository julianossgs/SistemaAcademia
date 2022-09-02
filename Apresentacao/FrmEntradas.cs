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
    public partial class FrmEntradas : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmEntradas()
        {
            InitializeComponent();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            Totalizar();
            BuscarDataEntrada();
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtEntrada.Enabled = true;
            btSalvar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
        }

        public void BuscarDataEntrada()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarDatasEntrada";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial", Convert.ToDateTime(dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dtFinal.Value));
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridEntradas.DataSource = Dt;
            con.FecharConexao();
            Totalizar();
        }

        //Método de Totalizar
        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridEntradas.Rows)
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
            BuscarDataEntrada();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataEntrada();
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
            Cmd.CommandText = "spInserirEntradas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dtEntrada.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            BuscarDataEntrada();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (gridEntradas.Rows.Count == 0)
            {
                MessageBox.Show("Não há Registros no banco de dados para exclusão!");
                return;
            }

            if (gridEntradas.Rows.Count > 1)
            {
                //obtendo o valor da 1ª linha do grid p/ exclusão
                id = gridEntradas.CurrentRow.Cells["IdEntrada"].Value.ToString();
                txtDescricao.Text = gridEntradas.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = gridEntradas.CurrentRow.Cells[4].Value.ToString();

                //extraindo o valor da Entrada para exclusão
                con.AbrirConexao();
                SqlCommand CmdExtrair = new SqlCommand();
                CmdExtrair.Connection = con.Con;
                CmdExtrair.CommandText = "spSelecionarValorEntrada";
                CmdExtrair.CommandType = CommandType.StoredProcedure;
                CmdExtrair.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
                SqlDataReader reader;
                reader = CmdExtrair.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.valorEntrada = Convert.ToDecimal(reader["Valor"]);
                    }

                }

                var result = MessageBox.Show("Deseja Excluir o Valor : " + Global.valorEntrada, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    con.AbrirConexao();
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = con.Con;
                    Cmd.CommandText = "spExcluirEntradas";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@IdEntrada", id);
                    Cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    MessageBox.Show("Registro excluido com sucesso!");
                    LimparCampos();
                    BuscarDataEntrada();
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
            FrmRelEntradas frmRelEntradas = new FrmRelEntradas();
            frmRelEntradas.ShowDialog();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridEntradas_SelectionChanged(object sender, EventArgs e)
        {
            txtCod.Text = gridEntradas.CurrentRow.Cells[0].Value.ToString();
            dtEntrada.Text = gridEntradas.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = gridEntradas.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = gridEntradas.CurrentRow.Cells[4].Value.ToString();
        }

        private void gridEntradas_DoubleClick(object sender, EventArgs e)
        {
            Global.identrada = gridEntradas.CurrentRow.Cells[0].Value.ToString();
            Global.dataEntrada = Convert.ToDateTime(gridEntradas.CurrentRow.Cells[1].Value.ToString());
            Global.tipoEntrada = gridEntradas.CurrentRow.Cells[2].Value.ToString();
            Global.descricaoEntrada = gridEntradas.CurrentRow.Cells[3].Value.ToString();
            Global.valorEntrada = Convert.ToDecimal(gridEntradas.CurrentRow.Cells[4].Value.ToString());

            FrmGestaoEntradas frmGestaoEntradas = new FrmGestaoEntradas();
            frmGestaoEntradas.ShowDialog();
        }

        private void lblMov_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmMovimentacoes = new FrmMovimentacoes();
            frmMovimentacoes.ShowDialog();
        }
    }
}
