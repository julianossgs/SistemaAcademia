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
    public partial class FrmProfessores : Form
    {
        Conexao con = new Conexao();
        public FrmProfessores()
        {
            InitializeComponent();
        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            btNovo.Focus();
        } 

        //Métodos
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtTel.Enabled = true;
        } 

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtTel.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtTel.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btSalvar.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome do Professor!");
                txtNome.Focus();
                return;
            }

            if (txtTel.Text == string.Empty)
            {
                MessageBox.Show("Informe o Telefone!");
                txtTel.Focus();
                return;
            }

            //Cód p/ salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirProfessor";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@NomeProfessor", txtNome.Text);
            Cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!");
            LimparCampos();
            DesabilitarCampos();
            btNovo.Focus();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtNome.Clear();
            txtTel.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
