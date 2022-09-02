using Academia.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Academia.Entidades;

namespace Academia.Apresentacao
{
    public partial class FrmUsuarios : Form
    {
        Conexao con = new Conexao();
        string Id;
        Usuarios objU = new Usuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            pListar.Visible = false;
            lblLista.Visible = false;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtSenha.Clear();
            txtUserName.Clear();
        } 

        private void HabilitarCampos()
        {
            txtNome.Focus();
            txtUserName.Enabled = true;
            txtSenha.Enabled = true;
            txtNome.Enabled = true;
            btSalvar.Enabled = true;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;
        }

        //Método de Listar Usuarios
        private void ListarUsuarios()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarUsuarios";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            gridUsuarios.DataSource = Dt;
            con.FecharConexao();
        }

        //botão Novo
        private void btNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        //botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome do Usuário!");
                txtNome.Focus();
                return;
            }

            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Informe o User Name!");
                txtUserName.Focus();
                return;
            }

            if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Informe a Senha!");
                txtSenha.Focus();
                return;
            }

            //Cód p/ salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirUsuarios";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@NomeUsuario",objU.NomeUsuario=txtNome.Text);
            Cmd.Parameters.AddWithValue("@UserName",txtUserName.Text);
            Cmd.Parameters.AddWithValue("@SenhaUsuario",txtSenha.Text);
            Cmd.Parameters.AddWithValue("@StatusUsuario",txtStatus.Text);
            Cmd.Parameters.AddWithValue("@NivelUsuario",NUDowp.Value);

            //Verificar se o UserName já existe no banco
            SqlCommand CmdVerificarUserName = new SqlCommand();
            CmdVerificarUserName.Connection = con.Con;
            CmdVerificarUserName.CommandText = "spVerificarUserName";
            CmdVerificarUserName.CommandType = CommandType.StoredProcedure;
            CmdVerificarUserName.Parameters.AddWithValue("@UserName", txtUserName.Text);
            SqlDataAdapter DaUserName = new SqlDataAdapter();
            DaUserName.SelectCommand = CmdVerificarUserName;
            DataTable DtUserName = new DataTable();
            DaUserName.Fill(DtUserName);
            if (DtUserName.Rows.Count > 0)
            {
                MessageBox.Show("UserName já cadastrado!");
                txtUserName.Clear();
                txtUserName.Focus();
                return;
            }

            //Verificar se a senha já existe no banco
            SqlCommand CmdVerificarSenha = new SqlCommand();
            CmdVerificarSenha.Connection = con.Con;
            CmdVerificarSenha.CommandText = "spVerificarSenha";
            CmdVerificarSenha.CommandType = CommandType.StoredProcedure;
            CmdVerificarSenha.Parameters.AddWithValue("@SenhaUsuario", txtSenha.Text);
            SqlDataAdapter DaSenha = new SqlDataAdapter();
            DaSenha.SelectCommand = CmdVerificarSenha;
            DataTable DtSenha = new DataTable();
            DaSenha.Fill(DtSenha);
            if (DtSenha.Rows.Count > 0)
            {
                MessageBox.Show("Senha já cadastrada!");
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }

            Cmd.ExecuteNonQuery();
            con.FecharConexao();
            MessageBox.Show("Usuário inserido com sucesso!");
            ListarUsuarios();
            LimparCampos();
        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Cód p/ o Id
            Id = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            txtNome.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();

            //extraindo nome do Usuário para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spVerificarNomeUsuario";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@NomeUsuario", txtNome.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.usuario = Convert.ToString(reader["NomeUsuario"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir o(a) Usuário - " + Global.usuario, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                //Cód p/ excluir
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirUsuario";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdUsuario",Id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();
                MessageBox.Show("Registro excluido com sucesso!");
                ListarUsuarios();

            }
        }

        //botão Limpar
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btNovo.Focus();
        }

        //botão Listar
        private void btListar_Click(object sender, EventArgs e)
        {
            pListar.Visible = true;
            lblLista.Visible = true;
        }

        //botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            pListar.Visible = false;
            lblLista.Visible = false;
        }
    }
}
