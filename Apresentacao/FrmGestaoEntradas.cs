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
    public partial class FrmGestaoEntradas : Form
    {
        Conexao con = new Conexao();
        public FrmGestaoEntradas()
        {
            InitializeComponent();
        }

        private void FrmGestaoEntradas_Load(object sender, EventArgs e)
        {

        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtSaida.Enabled = true;
            btAlterar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void FrmGestaoEntradas_Activated(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtCod.Text = Global.identrada;
            dtSaida.Value = Global.dataEntrada;
            txtTipo.Text = Global.tipoEntrada;
            txtDescricao.Text = Global.descricaoEntrada;
            txtValor.Text = Global.valorEntrada.ToString();

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
            Cmd.CommandText = "spAlterarEntradas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdEntrada", txtCod.Text);
            Cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dtSaida.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
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

        }
    }
}
