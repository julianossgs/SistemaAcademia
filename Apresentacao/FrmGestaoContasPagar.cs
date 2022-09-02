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
    public partial class FrmGestaoContasPagar : Form
    {
        Conexao con = new Conexao();
        public FrmGestaoContasPagar()
        {
            InitializeComponent();
        }

        private void FrmGestaoContasPagar_Load(object sender, EventArgs e)
        {
            CarregarCBFornecedores();
        }

        private void CarregarCBFornecedores()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarFornecedores";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            cBFornecedor.DataSource = Dt;
            cBFornecedor.ValueMember = "IdFornec";
            cBFornecedor.DisplayMember = "Fornecedor";
            con.FecharConexao();
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtSaida.Enabled = true;
            btAlterar.Enabled = true;
            cBFornecedor.Enabled = true;
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void FrmGestaoContasPagar_Activated(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtCod.Text = Global.idcontaspagar;
            dtSaida.Value = Global.dataContasPagar;
            txtTipo.Text = Global.tipoContasPagar;
            txtDescricao.Text = Global.descricaoContasPagar;
            txtValor.Text = Global.valorContasPagar.ToString();
            cBFornecedor.Text = Global.nomeFornecedor;

            btAlterar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarContasPagar";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdContasPagar", txtCod.Text);
            Cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dtSaida.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd.Parameters.AddWithValue("@Id_Fornec", cBFornecedor.SelectedValue);
            Cmd.ExecuteNonQuery();

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
        }

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

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
