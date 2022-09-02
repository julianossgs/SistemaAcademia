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
    public partial class FrmRelPlanos : Form
    {
        public FrmRelPlanos()
        {
            InitializeComponent();
        }

        private void FrmRelPlanos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.ListarPlanos'. Você pode movê-la ou removê-la conforme necessário.
            this.listarPlanosTableAdapter.Fill(this.academiaDataSet.ListarPlanos);

            this.reportViewer1.RefreshReport();
        }
    }
}
