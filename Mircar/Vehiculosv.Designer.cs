namespace Mircar
{
    partial class Vehiculosv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculosv));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.textchasi = new System.Windows.Forms.TextBox();
            this.textmotor = new System.Windows.Forms.TextBox();
            this.textplaca = new System.Windows.Forms.TextBox();
            this.combocombustible = new System.Windows.Forms.ComboBox();
            this.tiposCombustiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSet = new Mircar.RentcarDataSet();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.combomarca = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new Mircar.RentcarDataSetTableAdapters.MarcasTableAdapter();
            this.combomodelo = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSet1 = new Mircar.RentcarDataSet();
            this.combotipoveh = new System.Windows.Forms.ComboBox();
            this.tiposVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new Mircar.RentcarDataSetTableAdapters.ModelosTableAdapter();
            this.tipos_VehiculosTableAdapter = new Mircar.RentcarDataSetTableAdapters.Tipos_VehiculosTableAdapter();
            this.tipos_CombustiblesTableAdapter = new Mircar.RentcarDataSetTableAdapters.Tipos_CombustiblesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tiposCombustiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposVehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(143, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(146, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "No.Chasi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(147, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "No.Motor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(146, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "No.Placa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(515, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de Vehiculo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(516, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(516, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(516, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo de Combustible:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(516, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estado:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textdescripcion
            // 
            this.textdescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.textdescripcion.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdescripcion.Location = new System.Drawing.Point(245, 66);
            this.textdescripcion.Multiline = true;
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(220, 30);
            this.textdescripcion.TabIndex = 11;
            // 
            // textchasi
            // 
            this.textchasi.BackColor = System.Drawing.Color.DarkGray;
            this.textchasi.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchasi.Location = new System.Drawing.Point(245, 110);
            this.textchasi.Name = "textchasi";
            this.textchasi.Size = new System.Drawing.Size(220, 26);
            this.textchasi.TabIndex = 12;
            // 
            // textmotor
            // 
            this.textmotor.BackColor = System.Drawing.Color.DarkGray;
            this.textmotor.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmotor.Location = new System.Drawing.Point(245, 162);
            this.textmotor.Name = "textmotor";
            this.textmotor.Size = new System.Drawing.Size(220, 26);
            this.textmotor.TabIndex = 13;
            // 
            // textplaca
            // 
            this.textplaca.BackColor = System.Drawing.Color.DarkGray;
            this.textplaca.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textplaca.Location = new System.Drawing.Point(245, 216);
            this.textplaca.Name = "textplaca";
            this.textplaca.Size = new System.Drawing.Size(220, 26);
            this.textplaca.TabIndex = 14;
            // 
            // combocombustible
            // 
            this.combocombustible.BackColor = System.Drawing.Color.DarkGray;
            this.combocombustible.DataSource = this.tiposCombustiblesBindingSource;
            this.combocombustible.DisplayMember = "Descripcion";
            this.combocombustible.FormattingEnabled = true;
            this.combocombustible.Location = new System.Drawing.Point(680, 200);
            this.combocombustible.Name = "combocombustible";
            this.combocombustible.Size = new System.Drawing.Size(121, 21);
            this.combocombustible.TabIndex = 18;
            this.combocombustible.ValueMember = "Descripcion";
            // 
            // tiposCombustiblesBindingSource
            // 
            this.tiposCombustiblesBindingSource.DataMember = "Tipos_Combustibles";
            this.tiposCombustiblesBindingSource.DataSource = this.rentcarDataSetBindingSource;
            // 
            // rentcarDataSetBindingSource
            // 
            this.rentcarDataSetBindingSource.DataSource = this.rentcarDataSet;
            this.rentcarDataSetBindingSource.Position = 0;
            // 
            // rentcarDataSet
            // 
            this.rentcarDataSet.DataSetName = "RentcarDataSet";
            this.rentcarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboestado
            // 
            this.comboestado.BackColor = System.Drawing.Color.DarkGray;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activo ",
            "Inactivo"});
            this.comboestado.Location = new System.Drawing.Point(583, 255);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(121, 21);
            this.comboestado.TabIndex = 19;
            // 
            // grid2
            // 
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid2.Location = new System.Drawing.Point(35, 333);
            this.grid2.Name = "grid2";
            this.grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid2.Size = new System.Drawing.Size(797, 171);
            this.grid2.TabIndex = 20;
            this.grid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid2_CellContentClick);
            this.grid2.Click += new System.EventHandler(this.grid2_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(627, 287);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(167, 40);
            this.btneliminar.TabIndex = 25;
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
            this.btneditar.Location = new System.Drawing.Point(487, 287);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(167, 40);
            this.btneditar.TabIndex = 24;
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
            this.btnguardar.Location = new System.Drawing.Point(322, 287);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(159, 40);
            this.btnguardar.TabIndex = 23;
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
            this.btnnuevo.Location = new System.Drawing.Point(149, 287);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(167, 40);
            this.btnnuevo.TabIndex = 22;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(433, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Vehiculos";
            // 
            // combomarca
            // 
            this.combomarca.BackColor = System.Drawing.Color.DarkGray;
            this.combomarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.marcasBindingSource, "Descripcion", true));
            this.combomarca.DataSource = this.marcasBindingSource;
            this.combomarca.DisplayMember = "Descripcion";
            this.combomarca.FormattingEnabled = true;
            this.combomarca.Location = new System.Drawing.Point(578, 112);
            this.combomarca.Name = "combomarca";
            this.combomarca.Size = new System.Drawing.Size(121, 21);
            this.combomarca.TabIndex = 27;
            this.combomarca.ValueMember = "Descripcion";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.rentcarDataSetBindingSource;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // combomodelo
            // 
            this.combomodelo.BackColor = System.Drawing.Color.DarkGray;
            this.combomodelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelosBindingSource, "Descripcion", true));
            this.combomodelo.DataSource = this.modelosBindingSource;
            this.combomodelo.DisplayMember = "Descripcion";
            this.combomodelo.FormattingEnabled = true;
            this.combomodelo.Location = new System.Drawing.Point(578, 153);
            this.combomodelo.Name = "combomodelo";
            this.combomodelo.Size = new System.Drawing.Size(121, 21);
            this.combomodelo.TabIndex = 28;
            this.combomodelo.ValueMember = "Descripcion";
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.rentcarDataSet1;
            // 
            // rentcarDataSet1
            // 
            this.rentcarDataSet1.DataSetName = "RentcarDataSet";
            this.rentcarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combotipoveh
            // 
            this.combotipoveh.BackColor = System.Drawing.Color.DarkGray;
            this.combotipoveh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.marcasBindingSource, "Descripcion", true));
            this.combotipoveh.DataSource = this.tiposVehiculosBindingSource;
            this.combotipoveh.DisplayMember = "Descripcion";
            this.combotipoveh.FormattingEnabled = true;
            this.combotipoveh.Location = new System.Drawing.Point(652, 66);
            this.combotipoveh.Name = "combotipoveh";
            this.combotipoveh.Size = new System.Drawing.Size(121, 21);
            this.combotipoveh.TabIndex = 29;
            this.combotipoveh.ValueMember = "Descripcion";
            this.combotipoveh.SelectedIndexChanged += new System.EventHandler(this.combotipoveh_SelectedIndexChanged);
            // 
            // tiposVehiculosBindingSource
            // 
            this.tiposVehiculosBindingSource.DataMember = "Tipos_Vehiculos";
            this.tiposVehiculosBindingSource.DataSource = this.rentcarDataSetBindingSource;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // tipos_VehiculosTableAdapter
            // 
            this.tipos_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tipos_CombustiblesTableAdapter
            // 
            this.tipos_CombustiblesTableAdapter.ClearBeforeFill = true;
            // 
            // Vehiculosv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(924, 516);
            this.Controls.Add(this.combotipoveh);
            this.Controls.Add(this.combomodelo);
            this.Controls.Add(this.combomarca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.combocombustible);
            this.Controls.Add(this.textplaca);
            this.Controls.Add(this.textmotor);
            this.Controls.Add(this.textchasi);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehiculosv";
            this.Text = "Vehiculosv";
            this.Load += new System.EventHandler(this.Vehiculosv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposCombustiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposVehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.TextBox textchasi;
        private System.Windows.Forms.TextBox textmotor;
        private System.Windows.Forms.TextBox textplaca;
        private System.Windows.Forms.ComboBox combocombustible;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox combomarca;
        private RentcarDataSet rentcarDataSet;
        private System.Windows.Forms.BindingSource rentcarDataSetBindingSource;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private RentcarDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        public System.Windows.Forms.ComboBox combomodelo;
        public System.Windows.Forms.ComboBox combotipoveh;
        private RentcarDataSet rentcarDataSet1;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private RentcarDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.BindingSource tiposVehiculosBindingSource;
        private RentcarDataSetTableAdapters.Tipos_VehiculosTableAdapter tipos_VehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tiposCombustiblesBindingSource;
        private RentcarDataSetTableAdapters.Tipos_CombustiblesTableAdapter tipos_CombustiblesTableAdapter;
    }
}