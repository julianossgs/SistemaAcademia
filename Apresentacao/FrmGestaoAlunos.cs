using Academia.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmGestaoAlunos : Form
    {
        Conexao con = new Conexao();
        FrmAlunos Frm = new FrmAlunos();
        string imagemAlterou;
        public FrmGestaoAlunos()
        {
            InitializeComponent();   
        }

        private void FrmGestaoAlunos_Load(object sender, EventArgs e)
        {
            CarregarCBTurmas();
            HabilitarCampos();
            Frm.LimparFoto();
            txtCod.Text = Global.idAluno;
            txtAluno.Text = Global.nomeAluno;
            txtEmail.Text = Global.emailAluno;
            txtTel.Text = Global.telefoneAluno;
            cBStatus.Text = Global.statusAluno;
            cBTurma.Text = Global.turmaAluno;
            pBoxImagem.ImageLocation =Global.imagemAluno.ToString();

        }

        private void LimparCampos()
        {
            txtAluno.Clear();
            txtCod.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            cBStatus.Text = "A";
            cBTurma.Text = "";
        }
        private void HabilitarCampos()
        {
            txtEmail.Enabled = true;
            txtAluno.Enabled = true;
            txtTel.Enabled = true;
            cBTurma.Enabled = true;
            cBStatus.Enabled = true;
            btCancelar.Enabled = true;
            btAddImagem.Enabled = true;
            btRemoverImagem.Enabled = true;
            txtAluno.Focus();
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
            cBTurma.DisplayMember = "DescricaoTurma";
            con.FecharConexao();
        }

        
        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
           
           //Verificação p/ saber se alterou c/ a imagem e sem a imagem
            if (imagemAlterou == "1")
            {
                con.AbrirConexao();
               SqlCommand CmdAlt = new SqlCommand();
                CmdAlt.Connection = con.Con;
                CmdAlt.CommandText = "spAlterarAlunos";
                CmdAlt.CommandType = CommandType.StoredProcedure;
                CmdAlt.Parameters.AddWithValue("@IdAluno", txtCod.Text);
                CmdAlt.Parameters.AddWithValue("@NomeAluno", txtAluno.Text);
                CmdAlt.Parameters.AddWithValue("@Telefone", txtTel.Text);
                CmdAlt.Parameters.AddWithValue("@Status", cBStatus.Text);
                CmdAlt.Parameters.AddWithValue("@Email", txtEmail.Text);
                CmdAlt.Parameters.AddWithValue("@Id_Turma", cBTurma.SelectedValue);
                CmdAlt.Parameters.AddWithValue("@Imagem", Frm.Img());
                CmdAlt.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro alterado com sucesso!");
                LimparCampos();
                Close();
                imagemAlterou = "";
            }
            else
            {
                con.AbrirConexao();
               SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spAlterouAlunosSemImagem";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdAluno", txtCod.Text);
                Cmd.Parameters.AddWithValue("@NomeAluno", txtAluno.Text);
                Cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);
                Cmd.Parameters.AddWithValue("@Status", cBStatus.Text);
                Cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                Cmd.Parameters.AddWithValue("@Id_Turma", cBTurma.SelectedValue);

                Cmd.ExecuteNonQuery();
                con.FecharConexao();
            }
           
            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
            Close();
            imagemAlterou = "";
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Cancelar a Edição?","ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

        //botão de Add imagem p/ alteração
        private void btAddImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Frm.foto = dialog.FileName.ToString();
                pBoxImagem.ImageLocation = Frm.foto;
                imagemAlterou = "1";
            }
        }

        //botão Remover imagem
        private void btRemoverImagem_Click(object sender, EventArgs e)
        {
            Frm.LimparFoto();
        }
    }
}
