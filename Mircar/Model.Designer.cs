namespace Mircar
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.comboidmarca = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSet = new Mircar.RentcarDataSet();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.marcasTableAdapter = new Mircar.RentcarDataSetTableAdapters.MarcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Marcas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(108, 171);
            this.textdescripcion.Multiline = true;
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(203, 24);
            this.textdescripcion.TabIndex = 7;
            // 
            // comboidmarca
            // 
            this.comboidmarca.DataSource = this.marcasBindingSource;
            this.comboidmarca.DisplayMember = "id";
            this.comboidmarca.FormattingEnabled = true;
            this.comboidmarca.Location = new System.Drawing.Point(108, 118);
            this.comboidmarca.Name = "comboidmarca";
            this.comboidmarca.Size = new System.Drawing.Size(79, 21);
            this.comboidmarca.TabIndex = 8;
            this.comboidmarca.ValueMember = "id";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.rentcarDataSet;
            // 
            // rentcarDataSet
            // 
            this.rentcarDataSet.DataSetName = "RentcarDataSet";
            this.rentcarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboestado
            // 
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboestado.Location = new System.Drawing.Point(108, 233);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(79, 21);
            this.comboestado.TabIndex = 9;
            // 
            // grid2
            // 
            this.grid2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid2.Location = new System.Drawing.Point(334, 111);
            this.grid2.Name = "grid2";
            this.grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid2.Size = new System.Drawing.Size(399, 171);
            this.grid2.TabIndex = 21;
            this.grid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid2_CellContentClick);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(586, 311);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(167, 40);
            this.btneliminar.TabIndex = 29;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(446, 311);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(167, 40);
            this.btneditar.TabIndex = 28;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(281, 311);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(159, 40);
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(108, 311);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(167, 40);
            this.btnnuevo.TabIndex = 26;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.comboidmarca);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Model";
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Model_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.ComboBox comboidmarca;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private RentcarDataSet rentcarDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private RentcarDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
    }
}