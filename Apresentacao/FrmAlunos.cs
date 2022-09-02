using Academia.Dados;
using Academia.Relatorios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmAlunos : Form
    {
        Conexao con = new Conexao();
        string id;
        public string foto;
       
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            CarregarCBTurmas();
            ListarAlunos();
        } 

        //Métodos
        private void LimparCampos()
        {
            txtAluno.Clear();
            txtTel.Clear();
            txtCod.Clear();
            cBStatus.Text = "";
            cBTurma.Text = "";
            txtEmail.Clear();
        } 

        public void HabilitarCampos()
        {
            txtEmail.Enabled = true;
            txtAluno.Enabled = true;
            txtTel.Enabled = true;
            cBTurma.Enabled = true;
            cBStatus.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btExcluir.Enabled = true;
            btAddImagem.Enabled = true;
            btRemoverImagem.Enabled = true;
            txtAluno.Focus();
        }

        //Listar Alunos
        public void ListarAlunos()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarAlunos";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridAlunos.DataSource = Dt;
            con.FecharConexao();
        }

        //buscar Aluno por nome
        private void BuscarAlunoNome()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spBuscarAlunoNome";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@NomeAluno", txtBuscar.Text);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            gridAlunos.DataSource = Dt;

            con.FecharConexao();
        }

        //Carregar combo Box Turmas
        private void CarregarCBTurmas()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spCarregarCBTurmas";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            cBTurma.DataSource = Dt;
            cBTurma.ValueMember = "IdTurma";
            cBTurma.DisplayMember = "Turma";
            con.FecharConexao();
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

        //Método p/ Limpar foto
        public void LimparFoto()
        {
           
            pBoxImagem.Image = Properties.Resources.sem_foto;
            foto = "Imagens/sem-foto.jpg";
        }

        //Método p/ conversão do arquivo da imagem p/ enviar ao banco
        public byte[] Img()
        {
            byte[] Imagem;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Imagem = br.ReadBytes((int)fs.Length);
            return Imagem;
        }

        //botão Novo
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        //botão SALVAR
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtAluno.Text==string.Empty)
            {
                MessageBox.Show("Informe o Nome do Aluno!");
                txtAluno.Focus();
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

            //Cód p/ Salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirAlunos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@NomeAluno", txtAluno.Text);
            Cmd.Parameters.AddWithValue("@Id_Turma", cBTurma.SelectedValue);
            Cmd.Parameters.AddWithValue("@Status", cBStatus.Text);
            Cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
            Cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            Cmd.Parameters.AddWithValue("@Imagem",Img());
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro inserido com sucesso!");
            LimparCampos();
            LimparFoto();
            ListarAlunos();
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btNovo.Focus();
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //evento de buscar aluno por nome
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlunoNome();
        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //obtendo o valor da 1ª linha do grid p/ exclusão
            id = gridAlunos.CurrentRow.Cells["IdAluno"].Value.ToString();
            txtAluno.Text = gridAlunos.CurrentRow.Cells[1].Value.ToString();

            //extraindo Aluno para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spSelecionarAlunoNome";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@NomeAluno", txtAluno.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.nomeAluno = Convert.ToString(reader["NomeAluno"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir o Aluno(a) - " + Global.nomeAluno, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirAlunos";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdAluno",id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!");
                LimparCampos();
                ListarAlunos();
            }
        }

        //Evento de duplo click na gridView
        private void gridAlunos_DoubleClick(object sender, EventArgs e)
        {
            Close();
            Global.idAluno = gridAlunos.CurrentRow.Cells[0].Value.ToString();
            Global.nomeAluno = gridAlunos.CurrentRow.Cells[1].Value.ToString();
            Global.turmaAluno = gridAlunos.CurrentRow.Cells[5].Value.ToString();
            Global.emailAluno = gridAlunos.CurrentRow.Cells[3].Value.ToString();
            Global.telefoneAluno = gridAlunos.CurrentRow.Cells[2].Value.ToString();
            Global.statusAluno = gridAlunos.CurrentRow.Cells[4].Value.ToString();
            Global.imagemAluno = (byte[])gridAlunos.CurrentRow.Cells[6].Value;

            if (gridAlunos.CurrentRow.Cells[6].Value != DBNull.Value)
            {
                
                byte[] imagem = (byte[])gridAlunos.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(imagem);
                pBoxImagem.Image = System.Drawing.Image.FromStream(ms);
               
            }
            else
            {
                pBoxImagem.Image = Properties.Resources.sem_foto;
            }

            FrmGestaoAlunos frm = new FrmGestaoAlunos();
            frm.ShowDialog();
          
        }

        //Evento de selecionar na GridView
        private void gridAlunos_SelectionChanged(object sender, EventArgs e)
        {
            
            id = gridAlunos.CurrentRow.Cells["IdAluno"].Value.ToString();
            txtCod.Text = gridAlunos.CurrentRow.Cells[0].Value.ToString();
            txtAluno.Text = gridAlunos.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = gridAlunos.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = gridAlunos.CurrentRow.Cells[3].Value.ToString();
            cBTurma.Text = gridAlunos.CurrentRow.Cells[5].Value.ToString();
            cBStatus.Text = gridAlunos.CurrentRow.Cells[4].Value.ToString();

            //recuperando imagem do banco de dados e passando p/ 1 objeto(gridView)
            if (gridAlunos.CurrentRow.Cells[6].Value != DBNull.Value)
            {
                byte[] imagem = (byte[])gridAlunos.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(imagem);
                pBoxImagem.Image = System.Drawing.Image.FromStream(ms);
            }
            else
            {
                pBoxImagem.Image = Properties.Resources.sem_foto;
            }
           
           
        }

        //botão Add Imagem
        private void btAddImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pBoxImagem.ImageLocation = foto;
               
            }
        }

        //botão Remover Imagem
        private void btRemoverImagem_Click(object sender, EventArgs e)
        {
            LimparFoto();
        }

        //botão Imprimir
        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelAlunos frmRelAlunos = new FrmRelAlunos();
            frmRelAlunos.Show();
        }
    }
}
