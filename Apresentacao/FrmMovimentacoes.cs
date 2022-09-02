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
    public partial class FrmMovimentacoes : Form
    {
        Conexao con = new Conexao();

        //variáveis usadas no métodos de totalizar
        decimal totalEntradas, totalSaidas;
        public FrmMovimentacoes()
        {
            InitializeComponent();
        }

        private void FrmMovimentacoes_Load(object sender, EventArgs e)
        {
            cBEntradaSaida.SelectedIndex = 0;
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
           
            BuscarDatas();
        }

        //Método de Listar movimentações
        private void BuscarDatas()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarDatas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial",Convert.ToDateTime(dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dtFinal.Text));
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridMovimentacoes.DataSource = Dt;
            con.FecharConexao();

            TotalizarEntradas();
            TotalizarSaidas();
            Totalizar();
        } 

        //Método de buscar por datas e tipo
        private void BuscarDataTipo()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarDataTipo";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial", Convert.ToDateTime(dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dtFinal.Text));
            Cmd.Parameters.AddWithValue("@Tipo", cBEntradaSaida.Text);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridMovimentacoes.DataSource = Dt;
            con.FecharConexao();

            TotalizarEntradas();
            TotalizarSaidas();
            Totalizar();
        }

        //Evento de busca no combo box
        private void cBEntradaSaida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBEntradaSaida.SelectedIndex == 0)
            {
                BuscarDatas();
            }

            else
            {
                BuscarDataTipo();
            }
        }

        //Evento de busca no date time inicial
        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }

        //Evento de buscar no date time final
        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        } 

        //Método de totalizar as entradas
        private void TotalizarEntradas()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacoes.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString() == "Entrada")
                {
                    total += Convert.ToDecimal(linha.Cells["Valor"].Value);
                }
            }
            totalEntradas = total;
            lblEntrada.Text = Convert.ToDecimal(total).ToString("C2");
        }

        //Método de totalizar as saída
        private void TotalizarSaidas()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacoes.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString() == "Saida")
                {
                    total += Convert.ToDecimal(linha.Cells["Valor"].Value);
                    //linha de cód p/ deixar a cor da linha em vermelho(valor negativo)
                    linha.Cells["Valor"].Style.ForeColor = Color.Red;
                    //linha.Cells["Tipo"].Style.ForeColor = Color.Red;
                    //linha.Cells["Movimento"].Style.ForeColor = Color.Red;
                }
            }
            totalSaidas = total;
            lblSaida.Text = Convert.ToDecimal(total).ToString("C2");
        }

        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacoes.Rows)
            {
                total = totalEntradas - totalSaidas;
            }

            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");

            if (total >= 0)
            {
                lblTotal.ForeColor = Color.Black;
            }

            else
            {
                lblTotal.ForeColor = Color.Red;
            }
        }
    }
}
