using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mircar
{
    public partial class combustibles : Form
    {
        public combustibles()
        {
            InitializeComponent();
        }


        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Tipos_Combustibles.ToList();
        }
        private void llenar()
        {
<<<<<<< HEAD
=======
            this.texid.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.textdescripcion.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();

            this.comboestado.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();


        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            texid.Clear();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            textdescripcion.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            int id = int.Parse(this.texid.Text);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            string Descripcion = textdescripcion.Text.Trim();
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {


                Tipos_Combustibles c = new Tipos_Combustibles
                {
<<<<<<< HEAD
                    
=======
                    id = id,
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                    Descripcion = Descripcion,

                    Estado = estado


                };
                contexto.Tipos_Combustibles.Add(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
            string Descripcion = textdescripcion.Text;

            string estado = comboestado.Text;
=======
            int id = Convert.ToInt16(this.texid.Text);
            string Descripcion = textdescripcion.Text;

            String estado = comboestado.Text;
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c


            using (RentcarEntities contexto = new RentcarEntities())
            {

<<<<<<< HEAD
                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault();
=======
                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

                c.Descripcion = Descripcion;

                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
      
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault();
=======
            int id = Convert.ToInt16(this.texid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

                contexto.Tipos_Combustibles.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void combustibles_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dat1_Click(object sender, EventArgs e)
        {
            llenar();

        }
<<<<<<< HEAD

        private void dat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
    }
}
