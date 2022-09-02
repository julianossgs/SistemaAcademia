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
    public partial class FrmGestaoFornecedores : Form
    {
        Conexao con = new Conexao();
        public FrmGestaoFornecedores()
        {
            InitializeComponent();
        }

        private void FrmGestaoFornecedores_Load(object sender, EventArgs e)
        {
           
            HabilitarCampos();
           
            txtCod.Text = Global.idFornec;
            txtFornec.Text = Global.nomeFornecedor;
            txtEmail.Text = Global.emailFornecedor;
            txtTel.Text = Global.telFornecedor;
            txtEndereco.Text = Global.enderecoFornecedor;
            txtContato.Text = Global.contatoFornecedor;
            txtCnpj.Text = Global.cnpjFornecedor;
            btAlterar.Enabled = true;
            btCancelar.Enabled = true;
          
        }

        private void LimparCampos()
        {
            txtFornec.Clear();
            txtTel.Clear();
            txtCod.Clear();
            txtEndereco.Clear();
            txtCnpj.Clear();
            txtEmail.Clear();
            txtContato.Clear();
        }

        public void HabilitarCampos()
        {
            txtEmail.Enabled = true;
            txtFornec.Enabled = true;
            txtTel.Enabled = true;
            txtEndereco.Enabled = true;
            txtContato.Enabled = true;
            btCancelar.Enabled = true;
            txtFornec.Focus();
        }

        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarFornec";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdFornec", txtCod.Text);
            Cmd.Parameters.AddWithValue("@Fornecedor", txtFornec.Text);
            Cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            Cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
            Cmd.Parameters.AddWithValue("@Contato", txtContato.Text);
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            //não alterar o CNPJ
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
            Close();
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Cancelar a Edição?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {
                btAlterar.Focus();
            }
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Close();
        }
    }
}
