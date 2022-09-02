using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        FrmUsuarios FrmUsuarios = new FrmUsuarios();
        public FrmPrincipal()
        {
            InitializeComponent();
           
        }

        private void usuáriosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GestaUsuario();
           
            lblUsuario.Text = Global.usuario;
            pbLogado.Image = Properties.Resources.iconfinder_Ball_Green_345551;
            lblAcesso.Text = Global.nivel.ToString();
            FrmUsuarios.NUDowp.Value = Global.nivel;
        }

        //Método / controlar acesso dos usuários do sistema
        private void GestaUsuario()
        {
            //Nivel 1 - acesso somente aos cadastros de alunos
            //Nivel 3 - acesso total ao sistema

            if (Global.logado == true && Global.nivel == 3)
            {
               
                    cadastrosToolStripMenuItem.Enabled = true;
                    financeiroToolStripMenuItem.Enabled = true;
                    loginToolStripMenuItem.Enabled = true;
               
            }
            else if(Global.logado == true && Global.nivel == 1)
            {
              
                    cadastrosToolStripMenuItem.Enabled = true;
                    financeiroToolStripMenuItem.Enabled = false;
                    loginToolStripMenuItem.Enabled = true;
              
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.logado = false;
            lblAcesso.Text = "0";
            lblUsuario.Text = "Não há Usuário logado!";
            pbLogado.Image = Properties.Resources.iconfinder_cross_48_10298;
           // pbLogado.ImageLocation = Properties.Resources.iconfinder_Ball_Red_345561.ToString();
            cadastrosToolStripMenuItem.Enabled = false;
            financeiroToolStripMenuItem.Enabled = false;

        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorarios frmHorarios = new FrmHorarios();
            frmHorarios.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void gestãoDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestaoProfessores frmGestaoProfessores = new FrmGestaoProfessores();
            frmGestaoProfessores.ShowDialog();
        }

        private void cadastrarNovoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessores frmProfessores = new FrmProfessores();
            frmProfessores.ShowDialog();
        }

        private void cadastrarNovaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurmas frmTurmas = new FrmTurmas();
            frmTurmas.ShowDialog();
        }

        private void cadastrarNovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlunos frmAlunos = new FrmAlunos();
            frmAlunos.ShowDialog();
        }

        private void cadastrarNovoForneçedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores frmFornecedores = new FrmFornecedores();
            frmFornecedores.Show();
        }

        private void cadastrarNovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();
        }

        private void pedidosParaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoque frmEstoque = new FrmEstoque();
            frmEstoque.ShowDialog();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanos frmPlanos = new FrmPlanos();
            frmPlanos.ShowDialog();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmMovimentacoes = new FrmMovimentacoes();
            frmMovimentacoes.ShowDialog();
        }

        private void saídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaidas frmSaidas = new FrmSaidas();
            frmSaidas.ShowDialog();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradas frmEntradas = new FrmEntradas();
            frmEntradas.ShowDialog();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmContasPagar frmContasPagar = new FrmContasPagar();
            frmContasPagar.ShowDialog();
        }

        private void contasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasPagas frmContasPagas = new FrmContasPagas();
            frmContasPagas.ShowDialog();
        }
    }
}
