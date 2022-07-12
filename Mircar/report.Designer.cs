namespace Mircar
{
    partial class report
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
            report report = this;
            report.components = new System.ComponentModel.Container();
            report.grid = new System.Windows.Forms.DataGridView();
            report.label1 = new System.Windows.Forms.Label();
            report.rentcarDataSet = new Mircar.RentcarDataSet();
            report.clientesBindingSource = new System.Windows.Forms.BindingSource(report.components);
            report.clientesTableAdapter = new Mircar.RentcarDataSetTableAdapters.ClientesTableAdapter();
            report.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.notarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.tipoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            report.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)report.grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)report.rentcarDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)report.clientesBindingSource).BeginInit();
            report.SuspendLayout();
            // 
            // grid
            // 
            report.grid.AllowUserToAddRows = false;
            report.grid.AutoGenerateColumns = false;
            report.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            report.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            report.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            report.idDataGridViewTextBoxColumn,
            report.nombreDataGridViewTextBoxColumn,
            report.cedulaDataGridViewTextBoxColumn,
            report.notarjetaDataGridViewTextBoxColumn,
            report.tipoPersonaDataGridViewTextBoxColumn,
            report.estadoDataGridViewTextBoxColumn});
            report.grid.DataSource = report.clientesBindingSource;
            report.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            report.grid.Location = new System.Drawing.Point(111, 116);
            report.grid.MultiSelect = false;
            report.grid.Name = "grid";
            report.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            report.grid.Size = new System.Drawing.Size(583, 210);
            report.grid.TabIndex = 23;
            // 
            // label1
            // 
            report.label1.AutoSize = true;
            report.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            report.label1.Location = new System.Drawing.Point(365, 24);
            report.label1.Name = "label1";
            report.label1.Size = new System.Drawing.Size(89, 23);
            report.label1.TabIndex = 24;
            report.label1.Text = "Reportes";
            // 
            // rentcarDataSet
            // 
            report.rentcarDataSet.DataSetName = "RentcarDataSet";
            report.rentcarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            report.clientesBindingSource.DataMember = "Clientes";
            report.clientesBindingSource.DataSource = report.rentcarDataSet;
            // 
            // clientesTableAdapter
            // 
            report.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            report.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            report.idDataGridViewTextBoxColumn.HeaderText = "id";
            report.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            report.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            report.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            report.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            report.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            report.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            report.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // notarjetaDataGridViewTextBoxColumn
            // 
            report.notarjetaDataGridViewTextBoxColumn.DataPropertyName = "No_tarjeta";
            report.notarjetaDataGridViewTextBoxColumn.HeaderText = "No_tarjeta";
            report.notarjetaDataGridViewTextBoxColumn.Name = "notarjetaDataGridViewTextBoxColumn";
            // 
            // tipoPersonaDataGridViewTextBoxColumn
            // 
            report.tipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Persona";
            report.tipoPersonaDataGridViewTextBoxColumn.HeaderText = "Tipo_Persona";
            report.tipoPersonaDataGridViewTextBoxColumn.Name = "tipoPersonaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            report.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            report.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            report.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // btnreporte
            // 
            report.btnreporte.Location = new System.Drawing.Point(619, 87);
            report.btnreporte.Name = "btnreporte";
            report.btnreporte.Size = new System.Drawing.Size(75, 23);
            report.btnreporte.TabIndex = 25;
            report.btnreporte.Text = "PDF";
            report.btnreporte.UseVisualStyleBackColor = true;

            // 
            // report
            // 
            report.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            report.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            report.BackColor = System.Drawing.SystemColors.AppWorkspace;
            report.ClientSize = new System.Drawing.Size(800, 450);
            report.Controls.Add(report.btnreporte);
            report.Controls.Add(report.label1);
            report.Controls.Add(report.grid);
            report.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            report.Name = "report";
            report.Text = "report";
            report.Load += new System.EventHandler(report.report_Load);
            ((System.ComponentModel.ISupportInitialize)report.grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)report.rentcarDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)report.clientesBindingSource).EndInit();
            report.ResumeLayout(false);
            report.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private RentcarDataSet rentcarDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private RentcarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnreporte;
    }
}