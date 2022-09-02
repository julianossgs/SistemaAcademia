
namespace Academia.Relatorios
{
    partial class FrmRelContasPagar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listarContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet = new Academia.AcademiaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listarContasPagarTableAdapter = new Academia.AcademiaDataSetTableAdapters.ListarContasPagarTableAdapter();
            this.pConsulta = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listarContasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            this.pConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // listarContasPagarBindingSource
            // 
            this.listarContasPagarBindingSource.DataMember = "ListarContasPagar";
            this.listarContasPagarBindingSource.DataSource = this.academiaDataSet;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ListarContasPagar";
            reportDataSource1.Value = this.listarContasPagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Academia.Relatorios.RelContasPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(788, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // listarContasPagarTableAdapter
            // 
            this.listarContasPagarTableAdapter.ClearBeforeFill = true;
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
            this.pConsulta.Size = new System.Drawing.Size(814, 115);
            this.pConsulta.TabIndex = 1;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(421, 50);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(132, 21);
            this.dtFinal.TabIndex = 2;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(110, 50);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(132, 21);
            this.dtInicial.TabIndex = 1;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta por Datas";
            // 
            // FrmRelContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 661);
            this.Controls.Add(this.pConsulta);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRelContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de ContasPagar";
            this.Load += new System.EventHandler(this.FrmRelContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarContasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            this.pConsulta.ResumeLayout(false);
            this.pConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listarContasPagarBindingSource;
        private AcademiaDataSet academiaDataSet;
        private AcademiaDataSetTableAdapters.ListarContasPagarTableAdapter listarContasPagarTableAdapter;
        private System.Windows.Forms.Panel pConsulta;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}