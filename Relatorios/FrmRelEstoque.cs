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
    public partial class FrmRelEstoque : Form
    {
        public FrmRelEstoque()
        {
            InitializeComponent();
        }

        private void FrmRelEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.PedidoEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoEstoqueTableAdapter.Fill(this.academiaDataSet.PedidoEstoque);

            this.reportViewer1.RefreshReport();
        }
    }
}
