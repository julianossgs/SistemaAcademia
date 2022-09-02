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
    public partial class FrmRelSaidas : Form
    {
        public FrmRelSaidas()
        {
            InitializeComponent();
        }

        private void FrmRelSaidas_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            BuscarDatas();
            //this.listarSaidasTableAdapter.Fill(this.academiaDataSet.ListarSaidas,Convert.ToDateTime("dataInicial").ToString(),Convert.ToDateTime("dataFinal").ToString());
          //  this.reportViewer1.RefreshReport();

        }

        //Método de buscar por datas
        private void BuscarDatas()
        {
            //recuperando os parametros
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            //Passando os TablesAdapters
            this.listarSaidasTableAdapter.Fill(this.academiaDataSet.ListarSaidas,Convert.ToString(dtInicial.Text),Convert.ToString(dtFinal.Text));

            this.reportViewer1.RefreshReport();
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }
    }
}
