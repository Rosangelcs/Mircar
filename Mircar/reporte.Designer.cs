namespace Mircar
{
    partial class Reporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientereport = new Mircar.Clientereport();
            this.clientereportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Mircar.ClientereportTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientereport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientereportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Clientereport";
            reportDataSource1.Value = this.clientesBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mircar.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientereport
            // 
            this.clientereport.DataSetName = "Clientereport";
            this.clientereport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientereportBindingSource
            // 
            this.clientereportBindingSource.DataSource = this.clientereport;
            this.clientereportBindingSource.Position = 0;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clientereport;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.clientereport;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.clientereport;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientereport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientereportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientereportBindingSource;
        private Clientereport clientereport;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ClientereportTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
    }
}