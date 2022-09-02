using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Academia.Dados;

namespace Academia.Apresentacao
{
    public partial class FrmGestaoPlanos : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmGestaoPlanos()
        {
            InitializeComponent();
        }

        private void FrmGestaoPlanos_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtDataVenc.Clear();
            txtDescricao.Clear();
            txtPlano.Clear();
            txtPreco.Clear();
        }


        private void FrmGestaoPlanos_Activated(object sender, EventArgs e)
        {
            HabilitarCampos();

            txtCod.Text = Global.idplano;
            txtPlano.Text = Global.nomePlano;
            txtDescricao.Text = Global.descricaoPlano;
            txtDataVenc.Text = Global.vencimentoPlano;
            txtPreco.Text = Global.valorPlano;

            btAlterar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtPlano.Enabled = true;
            txtDataVenc.Enabled = true;
            txtPreco.Enabled = true;
            btCancelar.Enabled = true;
            btAlterar.Enabled = true;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {

            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarPlanos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdPlano", txtCod.Text);
            Cmd.Parameters.AddWithValue("@Plano", txtPlano.Text);
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtPreco.Text));
            Cmd.Parameters.AddWithValue("@Vencimento", Convert.ToInt32(txtDataVenc.Text));
            Cmd.Parameters.AddWithValue("@DescricaoPlano", txtDescricao.Text);

            int data = Convert.ToInt32(txtDataVenc.Text);
            if (data > 31)
            {
                MessageBox.Show("Dia inválido! - Informe um dia de 01 a 31");
                txtDataVenc.Clear();
                txtDataVenc.Focus();
                return;
            }

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
            Close();
        }
    }
}
