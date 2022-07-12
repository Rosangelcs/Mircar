using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mircar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

               
        }

        private void customizeDesing()
        {
            PanelSubmenumedio.Visible = false;

        }

        private void hideSubmenu()
        {
            if (PanelSubmenumedio.Visible == true)
                PanelSubmenumedio.Visible =false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false) {
                hideSubmenu();
                SubMenu.Visible = true;

            } 
            else 
                SubMenu.Visible = false;
        }


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (Menuvertical.Width == 250) {
                Menuvertical.Width = 80;
                
            }
            else {
                Menuvertical.Width = 250;
        }
    }

        private void Iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Iconmaximizar_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Maximized;
            Iconmaximizar.Visible= false;
            Iconrestraurar.Visible = true;
        }

        private void Iconrestraurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Iconrestraurar.Visible = false;
            Iconmaximizar.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {

            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void btnclientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new client());

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new inicio());
        }

        
        private void btnvehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vehiculosv());

           

        }

        private void btnrentar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Renta());
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            AbrirFormInPanel(new report());
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Emplea());
                
        }

        private void btntiposveh_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new tipo());
            PanelSubmenumedio.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Model());
            PanelSubmenumedio.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Marca());
            PanelSubmenumedio.Visible=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new combustibles());
            PanelSubmenumedio.Visible=false;
        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmantenimientos_Click(object sender, EventArgs e)
        {
            PanelSubmenumedio.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelSubmenumedio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninspeccion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new inspecci());
        }
<<<<<<< HEAD

        private void report_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }
=======
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
    }
}

