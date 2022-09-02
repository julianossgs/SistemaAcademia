using Academia.Dados;
using Academia.Relatorios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmTurmas : Form
    {
        Conexao con = new Conexao();
        public string id;

        public FrmTurmas()
        {
            InitializeComponent();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
           
            ListarTurmas();
            CarregarCBHorarios();
            CarregarCBProfessores();
            AtualizarGrid();
        }

        //Método de Atualizar o grid
        private void AtualizarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[0].Width = 50;
            grid.Columns[0].Visible = true;
            grid.Columns[1].HeaderText = "Turma";
            grid.Columns[1].Width = 190;
            grid.Columns[2].HeaderText = "Nº de Alunos";
            grid.Columns[2].Width = 100;
            grid.Columns[3].HeaderText = "Professor";
            grid.Columns[3].Width = 190;
            grid.Columns[4].HeaderText = "Horário";
            grid.Columns[4].Width = 120;
            grid.Columns[5].HeaderText = "Status";
            grid.Columns[5].Width = 130;
        }
       
        private void LimparCampos()
        {
            txtCod.Clear();
            txtTurma.Clear();
            cBHorario.Text = "";
            cBProfessor.Text = "";
            cBStatus.Text = "";
            nUDAlunos.Value = 0;
        } 

        private void HabilitarCampos()
        {
            txtTurma.Enabled = true;
            cBStatus.Enabled = true;
            cBProfessor.Enabled = true;
            cBHorario.Enabled = true;
            nUDAlunos.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtTurma.Enabled = false;
            cBStatus.Enabled = false;
            cBProfessor.Enabled = false;
            cBHorario.Enabled = false;
            nUDAlunos.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        } 

        private void ListarTurmas()
        {
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spListarTurmas";
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            grid.DataSource = Dt;
            con.FecharConexao();
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

        //Método p/ calcular o número de vagas restante
        private void VagasRestantes()
        {
            int vr1 = Convert.ToInt32(nUDAlunos.Value);
            int vr2 = Convert.ToInt32(txtVagas.Text);
            int total;
            total = vr1 - vr2;
            txtVagas.Text = total.ToString();
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
            if (txtTurma.Text == string.Empty)
            {
                MessageBox.Show("Informe o Turma!");
                txtTurma.Focus();
                return;
            }

            if (cBProfessor.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome do Professor!");
                cBProfessor.Focus();
                return;
            }

            if (nUDAlunos.Text == string.Empty)
            {
                MessageBox.Show("Informe o Número de Alunos!");
                nUDAlunos.Focus();
                return;
            }

            if (cBHorario.Text == string.Empty)
            {
                MessageBox.Show("Informe o Horário!");
                cBHorario.Focus();
                return;
            }

            if (cBStatus.Text == string.Empty)
            {
                MessageBox.Show("Informe o Status!");
                cBStatus.Focus();
                return;
            }

            //Cód p/ salvar
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirTurmas";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@DescricaoTurma", txtTurma.Text);
            Cmd.Parameters.AddWithValue("@Id_Prof", cBProfessor.SelectedValue);
            Cmd.Parameters.AddWithValue("@Id_Horario", cBHorario.SelectedValue);
            Cmd.Parameters.AddWithValue("@MaxAlunos", nUDAlunos.Value);
            Cmd.Parameters.AddWithValue("@Status",cBStatus.Text);

            //Verificar se a Turma já está registrada
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spVerificarTurmas";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            CmdVerificar.Parameters.AddWithValue("@DescricaoTurma", txtTurma.Text);
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = CmdVerificar;
            Da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("Turma já cadastrada!");
                txtTurma.Clear();
                txtTurma.Focus();
                return;
            }

            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!");
            LimparCampos();
            DesabilitarCampos();
            ListarTurmas();
            btNovo.Focus();
        }

        //botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            btNovo.Focus();
        }

        //botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
           
            Global.idturma = grid.CurrentRow.Cells[0].Value.ToString();
            Global.descricaoTurma = grid.CurrentRow.Cells[1].Value.ToString();
            Global.status = grid.CurrentRow.Cells[5].Value.ToString();
            Global.nomeProfessor = grid.CurrentRow.Cells[3].Value.ToString();
            Global.maxAlunos = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
            Global.horario = grid.CurrentRow.Cells[4].Value.ToString();
            FrmGestaoTurmas frm = new FrmGestaoTurmas();
            frm.Show();

        }

        //botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //obtendo o valor da 1ª linha do grid p/ exclusão
            id = grid.CurrentRow.Cells["IdTurma"].Value.ToString();
            txtTurma.Text = grid.CurrentRow.Cells[1].Value.ToString();

            //extraindo turma para exclusão
            con.AbrirConexao();
            SqlCommand CmdExtrair = new SqlCommand();
            CmdExtrair.Connection = con.Con;
            CmdExtrair.CommandText = "spVerificarTurmas";
            CmdExtrair.CommandType = CommandType.StoredProcedure;
            CmdExtrair.Parameters.AddWithValue("@DescricaoTurma", txtTurma.Text);
            SqlDataReader reader;
            reader = CmdExtrair.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Global.descricaoTurma = Convert.ToString(reader["DescricaoTurma"]);
                }

            }

            var result = MessageBox.Show("Deseja Excluir a Turma - " + Global.descricaoTurma, "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirTurmas";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdTurma",id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!");
                LimparCampos();
                ListarTurmas();
            }
        }

        //Evento de seleção no GridView
        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            //obtendo o valor da 1ª linha do grid
            id = grid.CurrentRow.Cells["IdTurma"].Value.ToString();
            txtCod.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtTurma.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cBProfessor.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cBHorario.Text = grid.CurrentRow.Cells[4].Value.ToString();
            nUDAlunos.Value = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
            cBStatus.Text = grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void FrmTurmas_Activated(object sender, EventArgs e)
        {
           
        }

        //Evento de calcular vargas
        private void txtVagas_TextChanged(object sender, EventArgs e)
        {
            VagasRestantes();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelTurmas frmRelTurmas = new FrmRelTurmas();
            frmRelTurmas.Show();
        }
    }
}
