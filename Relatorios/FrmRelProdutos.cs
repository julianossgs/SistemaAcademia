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
    public partial class FrmRelProdutos : Form
    {
        public FrmRelProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.ListarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.listarProdutosTableAdapter.Fill(this.academiaDataSet.ListarProdutos);

            this.reportViewer1.RefreshReport();
        }
    }
}
