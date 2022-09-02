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
    public partial class FrmGestaoProfessores : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmGestaoProfessores()
        {
            InitializeComponent();
        }

        private void FrmGestaoProfessores_Load(object sender, EventArgs e)
        {
            ListarProfessores();
        }

        //Métodos
        private void LimparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtTel.Clear();
        } 

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtTel.Enabled = true;
        } 

        private void ListarProfessores()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarProfessor";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridProfessores.DataSource = Dt;
            con.FecharConexao();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarProfessor";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdProf", id);
            Cmd.Parameters.AddWithValue("@NomeProfessor", txtNome.Text);
            Cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
            ListarProfessores();
          
        }

        //botão EXCLUIR
        private void btExcluir_Click(object sender, EventArgs e)
        {
            id = gridProfessores.CurrentRow.Cells["IdProf"].Value.ToString();
            txtNome.Text = gridProfessores.CurrentRow.Cells[1].Value.ToString();

            //extraindo nome do Funcionário para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spListarProfessorNome";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@NomeProfessor", txtNome.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.nomeProfessor = Convert.ToString(reader["NomeProfessor"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir o(a) Professor - " + Global.nomeProfessor, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirProfessor";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdProf", id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!");
                LimparCampos();
                ListarProfessores();
            }
        }
       
        

        private void tbCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridProfessores_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarCampos();
            btExcluir.Enabled = true;
            id = gridProfessores.CurrentRow.Cells[0].Value.ToString();
            txtCod.Text = gridProfessores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridProfessores.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = gridProfessores.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
