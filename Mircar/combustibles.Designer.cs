namespace Mircar
{
    partial class combustibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(combustibles));
            this.label1 = new System.Windows.Forms.Label();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dat1 = new System.Windows.Forms.DataGridView();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de Combustibles";
            // 
            // comboestado
            // 
            this.comboestado.BackColor = System.Drawing.Color.DarkGray;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboestado.Location = new System.Drawing.Point(100, 178);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(102, 21);
            this.comboestado.TabIndex = 59;
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
            this.btneliminar.Location = new System.Drawing.Point(611, 307);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(143, 40);
            this.btneliminar.TabIndex = 58;
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
            this.btneditar.Location = new System.Drawing.Point(462, 307);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(143, 40);
            this.btneditar.TabIndex = 57;
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
            this.btnguardar.Location = new System.Drawing.Point(321, 307);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(135, 40);
            this.btnguardar.TabIndex = 56;
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
            this.btnnuevo.Location = new System.Drawing.Point(172, 307);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(143, 40);
            this.btnnuevo.TabIndex = 55;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dat1
            // 
            this.dat1.BackgroundColor = System.Drawing.Color.Silver;
            this.dat1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat1.Location = new System.Drawing.Point(270, 102);
            this.dat1.Name = "dat1";
            this.dat1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat1.Size = new System.Drawing.Size(367, 172);
            this.dat1.TabIndex = 54;
            this.dat1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat1_CellContentClick);
            this.dat1.Click += new System.EventHandler(this.dat1_Click);
            // 
            // textdescripcion
            // 
            this.textdescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.textdescripcion.Location = new System.Drawing.Point(99, 121);
            this.textdescripcion.Multiline = true;
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(165, 30);
            this.textdescripcion.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Descripción:";
            // 
            // combustibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dat1);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "combustibles";
            this.Text = "combustibles";
            this.Load += new System.EventHandler(this.combustibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dat1;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}