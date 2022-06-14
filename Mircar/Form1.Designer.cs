namespace Mircar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menuvertical = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSubmenumedio = new System.Windows.Forms.Panel();
            this.btncombustibles = new System.Windows.Forms.Button();
            this.btnmodelo = new System.Windows.Forms.Button();
            this.btnmarcas = new System.Windows.Forms.Button();
            this.btntiposveh = new System.Windows.Forms.Button();
            this.btnvehiculos = new System.Windows.Forms.Button();
            this.btninspeccion = new System.Windows.Forms.Button();
            this.btnmantenimientos = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnrentar = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Iconmaximizar = new System.Windows.Forms.PictureBox();
            this.Iconrestraurar = new System.Windows.Forms.PictureBox();
            this.Iconminimizar = new System.Windows.Forms.PictureBox();
            this.Iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.rentcarDataSet1 = new Mircar.RentcarDataSet();
            this.Menuvertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSubmenumedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconrestraurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menuvertical
            // 
            this.Menuvertical.AutoScroll = true;
            this.Menuvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menuvertical.Controls.Add(this.report);
            this.Menuvertical.Controls.Add(this.pictureBox1);
            this.Menuvertical.Controls.Add(this.PanelSubmenumedio);
            this.Menuvertical.Controls.Add(this.btnvehiculos);
            this.Menuvertical.Controls.Add(this.btninspeccion);
            this.Menuvertical.Controls.Add(this.btnmantenimientos);
            this.Menuvertical.Controls.Add(this.btnempleados);
            this.Menuvertical.Controls.Add(this.btnrentar);
            this.Menuvertical.Controls.Add(this.btnclientes);
            this.Menuvertical.Controls.Add(this.btninicio);
            this.Menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menuvertical.Location = new System.Drawing.Point(0, 0);
            this.Menuvertical.Name = "Menuvertical";
            this.Menuvertical.Size = new System.Drawing.Size(172, 650);
            this.Menuvertical.TabIndex = 0;
            this.Menuvertical.Paint += new System.Windows.Forms.PaintEventHandler(this.Menuvertical_Paint);
            // 
            // report
            // 
            this.report.FlatAppearance.BorderSize = 0;
            this.report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report.Image = ((System.Drawing.Image)(resources.GetObject("report.Image")));
            this.report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report.Location = new System.Drawing.Point(-3, 319);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(197, 40);
            this.report.TabIndex = 10;
            this.report.Text = "Reporte";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelSubmenumedio
            // 
            this.PanelSubmenumedio.Controls.Add(this.btncombustibles);
            this.PanelSubmenumedio.Controls.Add(this.btnmodelo);
            this.PanelSubmenumedio.Controls.Add(this.btnmarcas);
            this.PanelSubmenumedio.Controls.Add(this.btntiposveh);
            this.PanelSubmenumedio.Location = new System.Drawing.Point(-3, 414);
            this.PanelSubmenumedio.Name = "PanelSubmenumedio";
            this.PanelSubmenumedio.Size = new System.Drawing.Size(172, 116);
            this.PanelSubmenumedio.TabIndex = 7;
            this.PanelSubmenumedio.Visible = false;
            this.PanelSubmenumedio.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSubmenumedio_Paint);
            // 
            // btncombustibles
            // 
            this.btncombustibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncombustibles.FlatAppearance.BorderSize = 0;
            this.btncombustibles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btncombustibles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btncombustibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncombustibles.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncombustibles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncombustibles.Location = new System.Drawing.Point(0, 79);
            this.btncombustibles.Name = "btncombustibles";
            this.btncombustibles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btncombustibles.Size = new System.Drawing.Size(169, 27);
            this.btncombustibles.TabIndex = 7;
            this.btncombustibles.Text = "Combustibles";
            this.btncombustibles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncombustibles.UseVisualStyleBackColor = true;
            this.btncombustibles.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnmodelo
            // 
            this.btnmodelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodelo.FlatAppearance.BorderSize = 0;
            this.btnmodelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmodelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnmodelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodelo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodelo.Location = new System.Drawing.Point(6, 21);
            this.btnmodelo.Name = "btnmodelo";
            this.btnmodelo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnmodelo.Size = new System.Drawing.Size(169, 23);
            this.btnmodelo.TabIndex = 1;
            this.btnmodelo.Text = "Modelo";
            this.btnmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodelo.UseVisualStyleBackColor = true;
            this.btnmodelo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmarcas
            // 
            this.btnmarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmarcas.FlatAppearance.BorderSize = 0;
            this.btnmarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnmarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmarcas.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmarcas.Location = new System.Drawing.Point(6, 50);
            this.btnmarcas.Name = "btnmarcas";
            this.btnmarcas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnmarcas.Size = new System.Drawing.Size(169, 23);
            this.btnmarcas.TabIndex = 6;
            this.btnmarcas.Text = "Marcas";
            this.btnmarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmarcas.UseVisualStyleBackColor = true;
            this.btnmarcas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btntiposveh
            // 
            this.btntiposveh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntiposveh.FlatAppearance.BorderSize = 0;
            this.btntiposveh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btntiposveh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btntiposveh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntiposveh.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiposveh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntiposveh.Location = new System.Drawing.Point(3, -2);
            this.btntiposveh.Name = "btntiposveh";
            this.btntiposveh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btntiposveh.Size = new System.Drawing.Size(169, 27);
            this.btntiposveh.TabIndex = 0;
            this.btntiposveh.Text = "Tipos de Vehiculos";
            this.btntiposveh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntiposveh.UseVisualStyleBackColor = true;
            this.btntiposveh.Click += new System.EventHandler(this.btntiposveh_Click);
            // 
            // btnvehiculos
            // 
            this.btnvehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvehiculos.FlatAppearance.BorderSize = 0;
            this.btnvehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnvehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvehiculos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvehiculos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnvehiculos.Image")));
            this.btnvehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvehiculos.Location = new System.Drawing.Point(0, 143);
            this.btnvehiculos.Name = "btnvehiculos";
            this.btnvehiculos.Size = new System.Drawing.Size(203, 32);
            this.btnvehiculos.TabIndex = 2;
            this.btnvehiculos.Text = "Vehiculos";
            this.btnvehiculos.UseVisualStyleBackColor = true;
            this.btnvehiculos.Click += new System.EventHandler(this.btnvehiculos_Click);
            // 
            // btninspeccion
            // 
            this.btninspeccion.FlatAppearance.BorderSize = 0;
            this.btninspeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btninspeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btninspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninspeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninspeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninspeccion.Image = ((System.Drawing.Image)(resources.GetObject("btninspeccion.Image")));
            this.btninspeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninspeccion.Location = new System.Drawing.Point(-3, 273);
            this.btninspeccion.Name = "btninspeccion";
            this.btninspeccion.Size = new System.Drawing.Size(197, 37);
            this.btninspeccion.TabIndex = 9;
            this.btninspeccion.Text = "Inspección";
            this.btninspeccion.UseVisualStyleBackColor = true;
            this.btninspeccion.Click += new System.EventHandler(this.btninspeccion_Click);
            // 
            // btnmantenimientos
            // 
            this.btnmantenimientos.FlatAppearance.BorderSize = 0;
            this.btnmantenimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnmantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmantenimientos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmantenimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnmantenimientos.Image")));
            this.btnmantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmantenimientos.Location = new System.Drawing.Point(-3, 364);
            this.btnmantenimientos.Name = "btnmantenimientos";
            this.btnmantenimientos.Size = new System.Drawing.Size(197, 42);
            this.btnmantenimientos.TabIndex = 6;
            this.btnmantenimientos.Text = "Mantenimientos";
            this.btnmantenimientos.UseVisualStyleBackColor = true;
            this.btnmantenimientos.Click += new System.EventHandler(this.btnmantenimientos_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnempleados.Image = ((System.Drawing.Image)(resources.GetObject("btnempleados.Image")));
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(-6, 227);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(178, 40);
            this.btnempleados.TabIndex = 4;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btnrentar
            // 
            this.btnrentar.FlatAppearance.BorderSize = 0;
            this.btnrentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnrentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrentar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrentar.Image = ((System.Drawing.Image)(resources.GetObject("btnrentar.Image")));
            this.btnrentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrentar.Location = new System.Drawing.Point(-3, 181);
            this.btnrentar.Name = "btnrentar";
            this.btnrentar.Size = new System.Drawing.Size(206, 40);
            this.btnrentar.TabIndex = 3;
            this.btnrentar.Text = "Rentar- Devolver";
            this.btnrentar.UseVisualStyleBackColor = true;
            this.btnrentar.Click += new System.EventHandler(this.btnrentar_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 109);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(203, 34);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btninicio
            // 
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(203, 109);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninicio.TabIndex = 0;
            this.btninicio.TabStop = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.Iconmaximizar);
            this.panel2.Controls.Add(this.Iconrestraurar);
            this.panel2.Controls.Add(this.Iconminimizar);
            this.panel2.Controls.Add(this.Iconcerrar);
            this.panel2.Controls.Add(this.btnSlide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 50);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Iconmaximizar
            // 
            this.Iconmaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("Iconmaximizar.Image")));
            this.Iconmaximizar.Location = new System.Drawing.Point(1065, 12);
            this.Iconmaximizar.Name = "Iconmaximizar";
            this.Iconmaximizar.Size = new System.Drawing.Size(20, 20);
            this.Iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconmaximizar.TabIndex = 3;
            this.Iconmaximizar.TabStop = false;
            this.Iconmaximizar.Click += new System.EventHandler(this.Iconmaximizar_Click);
            // 
            // Iconrestraurar
            // 
            this.Iconrestraurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Iconrestraurar.Image = ((System.Drawing.Image)(resources.GetObject("Iconrestraurar.Image")));
            this.Iconrestraurar.Location = new System.Drawing.Point(1065, 12);
            this.Iconrestraurar.Name = "Iconrestraurar";
            this.Iconrestraurar.Size = new System.Drawing.Size(20, 20);
            this.Iconrestraurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconrestraurar.TabIndex = 2;
            this.Iconrestraurar.TabStop = false;
            this.Iconrestraurar.Click += new System.EventHandler(this.Iconrestraurar_Click);
            // 
            // Iconminimizar
            // 
            this.Iconminimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("Iconminimizar.Image")));
            this.Iconminimizar.Location = new System.Drawing.Point(1039, 12);
            this.Iconminimizar.Name = "Iconminimizar";
            this.Iconminimizar.Size = new System.Drawing.Size(20, 20);
            this.Iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconminimizar.TabIndex = 4;
            this.Iconminimizar.TabStop = false;
            this.Iconminimizar.Click += new System.EventHandler(this.Iconminimizar_Click);
            // 
            // Iconcerrar
            // 
            this.Iconcerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("Iconcerrar.Image")));
            this.Iconcerrar.Location = new System.Drawing.Point(1091, 12);
            this.Iconcerrar.Name = "Iconcerrar";
            this.Iconcerrar.Size = new System.Drawing.Size(20, 20);
            this.Iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconcerrar.TabIndex = 1;
            this.Iconcerrar.TabStop = false;
            this.Iconcerrar.Click += new System.EventHandler(this.Iconcerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelcontenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(172, 50);
            this.panelcontenedor.MinimumSize = new System.Drawing.Size(1000, 550);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1128, 600);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // rentcarDataSet1
            // 
            this.rentcarDataSet1.DataSetName = "RentcarDataSet";
            this.rentcarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Menuvertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Menuvertical";
            this.Menuvertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSubmenumedio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconrestraurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menuvertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.PictureBox Iconminimizar;
        private System.Windows.Forms.PictureBox Iconcerrar;
        private System.Windows.Forms.PictureBox Iconmaximizar;
        private System.Windows.Forms.PictureBox Iconrestraurar;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnrentar;
        private System.Windows.Forms.Button btnvehiculos;
        private System.Windows.Forms.Button btntiposveh;
        private System.Windows.Forms.Button btnmodelo;
        private System.Windows.Forms.Button btnmarcas;
        private System.Windows.Forms.Button btncombustibles;
        private System.Windows.Forms.Button btnmantenimientos;
        private System.Windows.Forms.Panel PanelSubmenumedio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btninspeccion;
        private RentcarDataSet rentcarDataSet1;
        private System.Windows.Forms.Button report;
    }
}

