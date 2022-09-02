using Academia.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmHorarios : Form
    {
        Conexao con = new Conexao();
        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            ListarHorarios();
        } 

        private void ListarHorarios()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarHorarios";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridHorarios.DataSource = Dt;
            con.FecharConexao();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridHorarios_SelectionChanged(object sender, EventArgs e)
        {
            txtCod.Text = gridHorarios.CurrentRow.Cells[0].Value.ToString();
            txtHorarios.Text = gridHorarios.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
