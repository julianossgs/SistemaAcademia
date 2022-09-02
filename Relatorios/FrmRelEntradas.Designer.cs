
namespace Academia.Relatorios
{
    partial class FrmRelEntradas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pConsulta = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.academiaDataSet = new Academia.AcademiaDataSet();
            this.listarEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarEntradasTableAdapter = new Academia.AcademiaDataSetTableAdapters.ListarEntradasTableAdapter();
            this.pConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEntradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pConsulta
            // 
            this.pConsulta.BackColor = System.Drawing.Color.Gainsboro;
            this.pConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pConsulta.Controls.Add(this.dtFinal);
            this.pConsulta.Controls.Add(this.dtInicial);
            this.pConsulta.Controls.Add(this.label3);
            this.pConsulta.Controls.Add(this.label2);
            this.pConsulta.Controls.Add(this.label1);
            this.pConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConsulta.Location = new System.Drawing.Point(0, 0);
            this.pConsulta.Name = "pConsulta";
            this.pConsulta.Size = new System.Drawing.Size(701, 100);
            this.pConsulta.TabIndex = 1;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(361, 43);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(114, 20);
            this.dtFinal.TabIndex = 2;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(94, 43);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(114, 20);
            this.dtInicial.TabIndex = 1;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta por Datas";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "ListarEntradas";
            reportDataSource3.Value = this.listarEntradasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Academia.Relatorios.RelEntradas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(677, 543);
            this.reportViewer1.TabIndex = 2;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarEntradasBindingSource
            // 
            this.listarEntradasBindingSource.DataMember = "ListarEntradas";
            this.listarEntradasBindingSource.DataSource = this.academiaDataSet;
            // 
            // listarEntradasTableAdapter
            // 
            this.listarEntradasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 661);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pConsulta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Entradas";
            this.Load += new System.EventHandler(this.FrmRelEntradas_Load);
            this.pConsulta.ResumeLayout(false);
            this.pConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEntradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pConsulta;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listarEntradasBindingSource;
        private AcademiaDataSet academiaDataSet;
        private AcademiaDataSetTableAdapters.ListarEntradasTableAdapter listarEntradasTableAdapter;
    }
}