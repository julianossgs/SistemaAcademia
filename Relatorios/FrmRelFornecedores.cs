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
    public partial class FrmRelFornecedores : Form
    {
        public FrmRelFornecedores()
        {
            InitializeComponent();
        }

        private void FrmRelFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.ListarFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.listarFornecedoresTableAdapter.Fill(this.academiaDataSet.ListarFornecedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
