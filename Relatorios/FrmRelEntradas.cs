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
    public partial class FrmRelEntradas : Form
    {
        public FrmRelEntradas()
        {
            InitializeComponent();
        }

        private void FrmRelEntradas_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            BuscarDatas();
            
        } 

        private void BuscarDatas()
        {
            //recuperando os parametros de datas
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            //Passando os TablesAdapters
            this.listarEntradasTableAdapter.Fill(this.academiaDataSet.ListarEntradas, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text));

            this.reportViewer1.RefreshReport();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }
    }
}
