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
    public partial class FrmRelTurmas : Form
    {
        public FrmRelTurmas()
        {
            InitializeComponent();
        }

        private void FrmRelTurmas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.ListarTurmas'. Você pode movê-la ou removê-la conforme necessário.
            this.listarTurmasTableAdapter.Fill(this.academiaDataSet.ListarTurmas);

            this.reportViewer1.RefreshReport();
        }
    }
}
