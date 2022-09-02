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
    public partial class FrmSaidas : Form
    {
        Conexao con = new Conexao();
        string id;
        
        public FrmSaidas()
        {
            InitializeComponent();
        }

        private void FrmSaidas_Load(object sender, EventArgs e)
        {
            Totalizar();
            BuscarDataSaida();
        } 

        //Métodos
        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtSaida.Enabled = true;
            btSalvar.Enabled = true;
          
        } 

        private void LimparCampos()
        {
            txtCod.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
        }

        public void BuscarDataSaida()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarDatasSaida";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial",Convert.ToDateTime (dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal",Convert.ToDateTime (dtFinal.Value));
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridSaidas.DataSource = Dt;
            con.FecharConexao();
            Totalizar();
        }

        //Método de Totalizar
        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridSaidas.Rows)
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
            BuscarDataSaida();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataSaida();
        }

        
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            txtDescricao.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text==string.Empty)
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
            Cmd.CommandText = "spInserirSaidas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Data",Convert.ToDateTime(dtSaida.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            BuscarDataSaida();

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
            FrmRelSaidas frmRelSaidas = new FrmRelSaidas();
            frmRelSaidas.ShowDialog();
        }

        //botão Cancelar
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //evento de selecionar na grid
        private void gridSaidas_SelectionChanged(object sender, EventArgs e)
        {
            txtCod.Text = gridSaidas.CurrentRow.Cells[0].Value.ToString();
            dtSaida.Text = gridSaidas.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = gridSaidas.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = gridSaidas.CurrentRow.Cells[4].Value.ToString();
        }

        private void lblMov_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmMovimentacoes = new FrmMovimentacoes();
            frmMovimentacoes.ShowDialog();
        }

        //evento de duplo click na grid
        private void gridSaidas_DoubleClick(object sender, EventArgs e)
        {
            Global.idsaida = gridSaidas.CurrentRow.Cells[0].Value.ToString();
            Global.dataSaida =Convert.ToDateTime(gridSaidas.CurrentRow.Cells[1].Value.ToString());
            Global.tipoSaida = gridSaidas.CurrentRow.Cells[2].Value.ToString();
            Global.descricaoSaida = gridSaidas.CurrentRow.Cells[3].Value.ToString();
            Global.valorSaida =Convert.ToDecimal(gridSaidas.CurrentRow.Cells[4].Value.ToString());

            FrmGestaoSaidas frmGestaoSaidas = new FrmGestaoSaidas();
            frmGestaoSaidas.ShowDialog();
        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (gridSaidas.Rows.Count == 0)
            {
                MessageBox.Show("Não Registros no banco de dados para exclusão!");
                return;
            }

            if (gridSaidas.Rows.Count > 1)
            {
                //obtendo o valor da 1ª linha do grid p/ exclusão
                id = gridSaidas.CurrentRow.Cells["IdSaida"].Value.ToString();
                txtDescricao.Text = gridSaidas.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = gridSaidas.CurrentRow.Cells[4].Value.ToString();

                //extraindo o valor da Saída para exclusão
                con.AbrirConexao();
                SqlCommand CmdExtrair = new SqlCommand();
                CmdExtrair.Connection = con.Con;
                CmdExtrair.CommandText = "spSelecionarValorSaida";
                CmdExtrair.CommandType = CommandType.StoredProcedure;
                CmdExtrair.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
                SqlDataReader reader;
                reader = CmdExtrair.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.valorSaida = Convert.ToDecimal(reader["Valor"]);
                    }

                }

                var result = MessageBox.Show("Deseja Excluir o Valor : " + Global.valorSaida, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    con.AbrirConexao();
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = con.Con;
                    Cmd.CommandText = "spExcluirSaidas";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@IdSaida", id);
                    Cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    MessageBox.Show("Registro excluido com sucesso!");
                    LimparCampos();
                    BuscarDataSaida();
                }
            }
        }
    }
}
