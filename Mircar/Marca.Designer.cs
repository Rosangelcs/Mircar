namespace Mircar
{
    partial class Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marca));
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
=======
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texid = new System.Windows.Forms.TextBox();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.dat1 = new System.Windows.Forms.DataGridView();
            this.textbusqueda = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
<<<<<<< HEAD
=======
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(101, 118);
=======
            this.label3.Location = new System.Drawing.Point(99, 132);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(101, 175);
=======
            this.label4.Location = new System.Drawing.Point(99, 189);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
<<<<<<< HEAD
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(104, 139);
=======
            // texid
            // 
            this.texid.Location = new System.Drawing.Point(103, 109);
            this.texid.Name = "texid";
            this.texid.Size = new System.Drawing.Size(45, 20);
            this.texid.TabIndex = 4;
            this.texid.TextChanged += new System.EventHandler(this.texid_TextChanged);
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(102, 153);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.textdescripcion.Multiline = true;
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(165, 30);
            this.textdescripcion.TabIndex = 5;
            this.textdescripcion.TextChanged += new System.EventHandler(this.textdescripcion_TextChanged);
            // 
            // dat1
            // 
            this.dat1.BackgroundColor = System.Drawing.Color.Silver;
            this.dat1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat1.Location = new System.Drawing.Point(273, 118);
            this.dat1.Name = "dat1";
            this.dat1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat1.Size = new System.Drawing.Size(392, 172);
            this.dat1.TabIndex = 22;
            this.dat1.Click += new System.EventHandler(this.dat1_Click);
            // 
            // textbusqueda
            // 
            this.textbusqueda.Location = new System.Drawing.Point(505, 92);
            this.textbusqueda.Multiline = true;
            this.textbusqueda.Name = "textbusqueda";
            this.textbusqueda.Size = new System.Drawing.Size(106, 21);
            this.textbusqueda.TabIndex = 24;
            this.textbusqueda.TextChanged += new System.EventHandler(this.textbusqueda_TextChanged);
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
            this.btneliminar.Location = new System.Drawing.Point(642, 296);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(143, 40);
            this.btneliminar.TabIndex = 33;
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
            this.btneditar.Location = new System.Drawing.Point(493, 296);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(143, 40);
            this.btneditar.TabIndex = 32;
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
            this.btnguardar.Location = new System.Drawing.Point(352, 296);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(135, 40);
            this.btnguardar.TabIndex = 31;
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
            this.btnnuevo.Location = new System.Drawing.Point(203, 296);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(143, 40);
            this.btnnuevo.TabIndex = 30;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // comboestado
            // 
            this.comboestado.BackColor = System.Drawing.Color.DarkGray;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
<<<<<<< HEAD
            this.comboestado.Location = new System.Drawing.Point(105, 196);
=======
            this.comboestado.Location = new System.Drawing.Point(103, 210);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(102, 21);
            this.comboestado.TabIndex = 35;
            this.comboestado.SelectedIndexChanged += new System.EventHandler(this.comboestado_SelectedIndexChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(617, 91);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(48, 23);
            this.btnbuscar.TabIndex = 36;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.textbusqueda);
            this.Controls.Add(this.dat1);
            this.Controls.Add(this.textdescripcion);
<<<<<<< HEAD
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
=======
            this.Controls.Add(this.texid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
=======
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texid;
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.DataGridView dat1;
        private System.Windows.Forms.TextBox textbusqueda;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.Button btnbuscar;
    }
}