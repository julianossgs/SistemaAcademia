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
    public partial class FrmContasPagas : Form
    {
        Conexao con = new Conexao();
        public FrmContasPagas()
        {
            InitializeComponent();
        }

        private void FrmContasPagas_Load(object sender, EventArgs e)
        {
            BuscarData();
        }

        public void BuscarData()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarContasPagas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DataInicial", Convert.ToDateTime(dtInicial.Text));
            Cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dtFinal.Value));
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridContasPagas.DataSource = Dt;
            con.FecharConexao();
            Totalizar();
        }

        //Método de Totalizar
        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridContasPagas.Rows)
            {
                total += Convert.ToDecimal(linha.Cells["Valor"].Value);
            }

            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");

        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelContasPagas frmRelContasPagas = new FrmRelContasPagas();
            frmRelContasPagas.ShowDialog();
        }
    }
}
