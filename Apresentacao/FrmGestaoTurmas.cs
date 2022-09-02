using Academia.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmGestaoTurmas : Form
    {
        Conexao con = new Conexao();
        FrmTurmas Obj = new FrmTurmas();
        public FrmGestaoTurmas()
        {
            InitializeComponent();
           
        } 

        private void FrmGestaoTurmas_Load(object sender, EventArgs e)
        {
            CarregarCBHorarios();
            CarregarCBProfessores();
            HabilitarCampos();
           
        }

        //Métodos
        public void LimparCampos()
        {
            txtCod.Clear();
            txtTurma.Clear();
            cBHorario.Text = "";
            cBProfessor.Text = "";
            cBStatus.Text = "";
            nUDAlunos.Value = 0;
        }

        public void HabilitarCampos()
        {
            txtTurma.Enabled = true;
            cBHorario.Enabled = true;
            cBProfessor.Enabled = true;
            cBStatus.Enabled = true;
            nUDAlunos.Enabled = true;
        } 


        private void ListarTurmas()
        {
            
        }

        //Carregar combo Box Horários
        private void CarregarCBHorarios()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarHorarios";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            cBHorario.DataSource = Dt;
            cBHorario.ValueMember = "IdHorario";
            cBHorario.DisplayMember = "DescricaoHorario";
            con.FecharConexao();
        }

        //Carregar Combo box Professores
        private void CarregarCBProfessores()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarProfessor";
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            cBProfessor.DataSource = Dt;
            cBProfessor.ValueMember = "IdProf";
            cBProfessor.DisplayMember = "NomeProfessor";
            con.FecharConexao();
        }


        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarTurmas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdTurma",txtCod.Text);
            Cmd.Parameters.AddWithValue("@DescricaoTurma", txtTurma.Text);
            Cmd.Parameters.AddWithValue("@Id_Prof", cBProfessor.SelectedValue);
            Cmd.Parameters.AddWithValue("@Id_Horario", cBHorario.SelectedValue);
            Cmd.Parameters.AddWithValue("@MaxAlunos",nUDAlunos.Value);
            Cmd.Parameters.AddWithValue("@Status", cBStatus.Text);
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!");
           // LimparCampos();
           // ListarTurmas();

        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGestaoTurmas_Activated(object sender, EventArgs e)
        {
            
            txtCod.Text = Global.idturma;
            txtTurma.Text = Global.descricaoTurma;
            cBHorario.Text = Global.horario;
            cBProfessor.Text = Global.nomeProfessor;
            cBStatus.Text = Global.status;
            nUDAlunos.Value = Global.maxAlunos;
            
        }

        private void FrmGestaoTurmas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGestaoTurmas frm = new FrmGestaoTurmas();
            frm.LimparCampos();
        }

        private void FrmGestaoTurmas_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmGestaoTurmas frm = new FrmGestaoTurmas();
            frm.LimparCampos();
        }
    }
}
