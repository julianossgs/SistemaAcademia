using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Relatorios
{
    public partial class FrmRelAlunos : Form
    {
        public FrmRelAlunos()
        {
            InitializeComponent();
        }

        private void FrmRelAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.ListarAlunos'. Você pode movê-la ou removê-la conforme necessário.
            this.listarAlunosTableAdapter.Fill(this.academiaDataSet.ListarAlunos);

            this.reportViewer1.RefreshReport();
        }
    }
}
