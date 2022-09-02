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
using System.Text.RegularExpressions;
using Academia.Relatorios;

namespace Academia.Apresentacao
{
    public partial class FrmPlanos : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmPlanos()
        {
            InitializeComponent();
        }

        private void FrmPlanos_Load(object sender, EventArgs e)
        {
            ListarPlanos();
            DesabilitarCampos();
            btNovo.Focus();
        }

        private void LimparCampos()
        {
            txtPlano.Clear();
            txtDescricao.Clear();
            txtCod.Clear();
            txtPreco.Clear();
            txtDataVenc.Clear();
        }

        public void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtPlano.Enabled = true;
            txtDataVenc.Enabled = true;
            txtPreco.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
         
        }

        public void DesabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtDataVenc.Enabled = false;
            txtPreco.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            txtPlano.Enabled = false;
        }

        public void ListarPlanos()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarPlanos";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridPlanos.DataSource = Dt;
            con.FecharConexao();
        }

        //Cód p/ usuário não digitar letras no tex box
        private void txtDataVenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Cód p/ usuário não digitar letras no tex box
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //botão Novo
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        //botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtPlano.Text == string.Empty)
            {
                MessageBox.Show("Informe o Plano!");
                txtPlano.Focus();
                return;
            }

            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe a Descrição do Plano!");
                txtDescricao.Focus();
                return;
            }

            if (txtPreco.Text == string.Empty)
            {
                MessageBox.Show("Informe o Preço!");
                txtPreco.Focus();
                return;
            }

            if (txtDataVenc.Text == string.Empty)
            {
                MessageBox.Show("Informe a Data de Vencimento!");
                txtDataVenc.Focus();
                return;
            }

            int data = Convert.ToInt32(txtDataVenc.Text);
            if (data > 31)
            {
                MessageBox.Show("Dia inválido! - Informe um dia de 01 a 31");
                txtDataVenc.Clear();
                txtDataVenc.Focus();
                return;
            }

            //Cód p/ Salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirPlanos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Plano", txtPlano.Text);
            Cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtPreco.Text));
            Cmd.Parameters.AddWithValue("@Vencimento",Convert.ToInt32 (txtDataVenc.Text));
            Cmd.Parameters.AddWithValue("@DescricaoPlano", txtDescricao.Text);
           
            //Verificar se o Plano já existe no banco/Cadastrado
            SqlCommand CmdPlano = new SqlCommand();
            CmdPlano.Connection = con.Con;
            CmdPlano.CommandText = "spSelecionarPlanoNome";
            CmdPlano.CommandType = CommandType.StoredProcedure;
            CmdPlano.Parameters.AddWithValue("@Plano", txtPlano.Text);
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = CmdPlano;
            Da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("Plano já Cadastrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlano.Clear();
                txtPlano.Focus();
                return;
            }

            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            ListarPlanos();
        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (gridPlanos.Rows.Count == 0)
            {
                MessageBox.Show("Não Registros no banco de dados para exclusão!");
                return;
            }

            if (gridPlanos.Rows.Count > 1)
            {
                //obtendo o valor da 1ª linha do grid p/ exclusão
                id = gridPlanos.CurrentRow.Cells["IdPlano"].Value.ToString();
                txtPlano.Text = gridPlanos.CurrentRow.Cells[1].Value.ToString();

                //extraindo Plano para exclusão
                con.AbrirConexao();
                SqlCommand CmdExtrair = new SqlCommand();
                CmdExtrair.Connection = con.Con;
                CmdExtrair.CommandText = "spSelecionarPlanoNome";
                CmdExtrair.CommandType = CommandType.StoredProcedure;
                CmdExtrair.Parameters.AddWithValue("@Plano", txtPlano.Text);
                SqlDataReader reader;
                reader = CmdExtrair.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.nomePlano = Convert.ToString(reader["Plano"]);
                    }

                }

                var result = MessageBox.Show("Deseja Excluir o Plano : " + Global.nomePlano, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    con.AbrirConexao();
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = con.Con;
                    Cmd.CommandText = "spExcluirPlanos";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@IdPlano", id);
                    Cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    MessageBox.Show("Registro excluido com sucesso!");
                    LimparCampos();
                    ListarPlanos();
                }
            }
            
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btNovo.Focus();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelPlanos frmRelPlanos = new FrmRelPlanos();
            frmRelPlanos.ShowDialog();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridPlanos_SelectionChanged(object sender, EventArgs e)
        {
            id = gridPlanos.CurrentRow.Cells[0].Value.ToString();
            txtCod.Text = gridPlanos.CurrentRow.Cells[0].Value.ToString();
            txtPlano.Text = gridPlanos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = gridPlanos.CurrentRow.Cells[2].Value.ToString();
            txtDataVenc.Text = gridPlanos.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridPlanos.CurrentRow.Cells[4].Value.ToString();
        }

        private void gridPlanos_DoubleClick(object sender, EventArgs e)
        {
            Global.idplano = gridPlanos.CurrentRow.Cells[0].Value.ToString();
            Global.nomePlano = gridPlanos.CurrentRow.Cells[1].Value.ToString();
            Global.valorPlano = gridPlanos.CurrentRow.Cells[2].Value.ToString();
            Global.vencimentoPlano = gridPlanos.CurrentRow.Cells[3].Value.ToString();
            Global.descricaoPlano = gridPlanos.CurrentRow.Cells[4].Value.ToString();

            FrmGestaoPlanos frmGestaoPlanos = new FrmGestaoPlanos();
            frmGestaoPlanos.ShowDialog();
        }
    }
}
