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
    public partial class tipo : Form
    {
        public tipo()
        {
            InitializeComponent();
        }
        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Tipos_Vehiculos.ToList();
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
            string Descripcion = textdescripcion.Text;
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

               Tipos_Vehiculos c = new Tipos_Vehiculos
                {
<<<<<<< HEAD
                    
=======
                    id = id,
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                    Descripcion = Descripcion,

                    Estado = estado


                };
                contexto.Tipos_Vehiculos.Add(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            int id = Convert.ToInt16(this.texid.Text);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            string Descripcion = textdescripcion.Text;

            string estado = comboestado.Text;


            using (RentcarEntities contexto = new RentcarEntities())
            {

<<<<<<< HEAD
                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault();
=======
                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault(x => x.id == id);
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

                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault();
=======
            int id = Convert.ToInt16(this.texid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

                contexto.Tipos_Vehiculos.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void tipo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dat1_Click(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
