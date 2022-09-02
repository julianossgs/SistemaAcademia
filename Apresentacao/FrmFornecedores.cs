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
    public partial class FrmFornecedores : Form
    {
        Conexao con = new Conexao();
        string id;
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            ListarFornec();
        }

        //Métodos
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
            txtCnpj.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btExcluir.Enabled = true;
           
            txtFornec.Focus();
        }

        //Método p/ validar Tel Fixo e Celular
        public bool ValidarTelefone(string celTel)
        {
            if (celTel.Length == 11)
            {
                celTel = celTel.Substring(0, 7) + "-" + celTel.Substring(7, 4);

            }
            return Regex.IsMatch(celTel, "(\\(?\\d{2}\\)?\\s)?(\\d{4,5}\\-\\d{4})");
        }

        //Método que valida o Email
        public bool ValidaEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
        }

        //Método p/ validar o Cnpj
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        //Listar Forneçedores
        public void ListarFornec()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarFornecedores";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridFornecedores.DataSource = Dt;
            con.FecharConexao();
        }

        //buscar Fornecedor por nome
        private void BuscarFornecNome()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarFornecNome";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Fornecedor", txtBuscar.Text);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridFornecedores.DataSource = Dt;

            con.FecharConexao();
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
            string valor = txtCnpj.Text;
            if (txtFornec.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome do Fornecedor!");
                txtFornec.Focus();
                return;
            }

            if (txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("Informe o Endereço!");
                txtEndereco.Focus();
                return;
            }

            //Cod p/ validar o Celular
            if (txtTel.Text != string.Empty)
            {

                if (!ValidarTelefone(txtTel.Text))
                {
                    MessageBox.Show("Telefone inválido! Informe um Telefone válido!");
                    txtTel.Clear();
                    txtTel.Focus();
                    return;
                }
            }

            //Cód p/ validar Email
            if (txtEmail.Text != string.Empty)
            {
                if (!ValidaEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email inválido! Informe um Email válido!");
                    txtEmail.Clear();
                    txtEmail.Focus();
                    return;
                }
            }
            
            //Cod p/ validação do CNPJ
            if (txtCnpj.Text == string.Empty)
            {
                MessageBox.Show("CNPJ inválido! Informe um CNPJ válido!");
                txtCnpj.Clear();
                txtCnpj.Focus();
                return;
            }

            else if (IsCnpj(valor))
            {
                MessageBox.Show("CNPJ válido! Click em OK para verificar se este CNPJ já está cadastrado no sistema!");
            }

            else
            {
                MessageBox.Show("CNPJ inválido! Informe um CNPJ válido!");
                txtCnpj.Clear();
                txtCnpj.Focus();
                return;
            }
            

            //Cód p/ Salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirFornec";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Fornecedor", txtFornec.Text);
            Cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            Cmd.Parameters.AddWithValue("@Contato", txtContato.Text);
            Cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            Cmd.Parameters.AddWithValue("@Cnpj",txtCnpj.Text);

            //Verificar se o Forneçedor já existe no banco/Cadastrado
            SqlCommand CmdFornec = new SqlCommand();
            CmdFornec.Connection = con.Con;
            CmdFornec.CommandText = "spListarFornecNome";
            CmdFornec.CommandType = CommandType.StoredProcedure;
            CmdFornec.Parameters.AddWithValue("@Fornecedor", txtFornec.Text);
            SqlDataAdapter Daf = new SqlDataAdapter();
            DataTable Dtf = new DataTable();
            Daf.SelectCommand = CmdFornec;
            Daf.Fill(Dtf);

            if (Dtf.Rows.Count > 0)
            {
                MessageBox.Show("Forneçedor já Cadastrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornec.Clear();
                txtFornec.Focus();
                return;
            }

            //Verificar se o CNPJ já existe no banco/Cadastrado
            SqlCommand CmdCPF = new SqlCommand();
            CmdCPF.Connection = con.Con;
            CmdCPF.CommandText = "spListarFornecCnpj";
            CmdCPF.CommandType = CommandType.StoredProcedure;
            CmdCPF.Parameters.AddWithValue("@Cnpj", txtCnpj.Text);
            SqlDataAdapter Dac = new SqlDataAdapter();
            DataTable Dtc = new DataTable();
            Dac.SelectCommand = CmdCPF;
            Dac.Fill(Dtc);

            if (Dtc.Rows.Count > 0)
            {
                MessageBox.Show("CNPJ já Cadastrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCnpj.Clear();
                txtCnpj.Focus();
                return;
            }

            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            ListarFornec();
        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //obtendo o valor da 1ª linha do grid p/ exclusão
            id = gridFornecedores.CurrentRow.Cells["IdFornec"].Value.ToString();
            txtFornec.Text = gridFornecedores.CurrentRow.Cells[1].Value.ToString();

            //extraindo Aluno para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spListarFornecNome";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@Fornecedor", txtFornec.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.nomeFornecedor = Convert.ToString(reader["Fornecedor"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir o Forneçedor - " + Global.nomeFornecedor, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirFornec";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdFornec", id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!");
                LimparCampos();
                ListarFornec();
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
            FrmRelFornecedores frmRelFornecedores = new FrmRelFornecedores();
            frmRelFornecedores.ShowDialog();
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridFornecedores_SelectionChanged(object sender, EventArgs e)
        {
           
            id = gridFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtCod.Text = gridFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtFornec.Text = gridFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = gridFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = gridFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gridFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCnpj.Text = gridFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtContato.Text = gridFornecedores.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void gridFornecedores_DoubleClick(object sender, EventArgs e)
        {
           
            Global.idFornec = gridFornecedores.CurrentRow.Cells[0].Value.ToString();
            Global.nomeFornecedor = gridFornecedores.CurrentRow.Cells[1].Value.ToString();
            Global.contatoFornecedor = gridFornecedores.CurrentRow.Cells[5].Value.ToString();
            Global.telFornecedor = gridFornecedores.CurrentRow.Cells[3].Value.ToString();
            Global.enderecoFornecedor = gridFornecedores.CurrentRow.Cells[2].Value.ToString();
            Global.emailFornecedor = gridFornecedores.CurrentRow.Cells[4].Value.ToString();
            Global.cnpjFornecedor = gridFornecedores.CurrentRow.Cells[6].Value.ToString();
            Close(); 

            FrmGestaoFornecedores frmGestao = new FrmGestaoFornecedores();
            frmGestao.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarFornecNome();
        }
    }
}
