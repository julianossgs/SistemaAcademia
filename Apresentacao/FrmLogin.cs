using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Dados;
using System.Data.SqlClient;
using Academia.Properties;

namespace Academia.Apresentacao
{
    public partial class FrmLogin : Form
    {
        Conexao con = new Conexao();
      
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        } 

        //Método de Limpar Campos
        private void LimparCampos()
        {
            txtUserName.Clear();
            txtSenha.Clear();
        }

        //Método de Logar
        private void Logar()
        {
           
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spLogar";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            CmdVerificar.Parameters.AddWithValue("@UserName",txtUserName.Text);
            CmdVerificar.Parameters.AddWithValue("@SenhaUsuario", txtSenha.Text);
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.usuario = Convert.ToString(reader["NomeUsuario"]);
                    Global.userName = Convert.ToString(reader["UserName"]);
                    Global.nivel = Convert.ToInt32(reader["NivelUsuario"]);
                    Global.logado = true;
                }

                MessageBox.Show("Bem vindo  " + Global.userName);
                FrmPrincipal frm = new FrmPrincipal();
                LimparCampos();
                frm.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Erro ao Acessar! Usuário ou Senha inválidos!");
                txtUserName.Clear();
                txtSenha.Clear();
                txtUserName.Focus();
                return;
            }

            //con.FecharConexao();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do Usuário!");
                txtUserName.Focus();
                return;
            }

            if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Informe a Senha!");
                txtSenha.Focus();
                return;
            }

            Logar();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
