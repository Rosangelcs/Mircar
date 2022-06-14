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
            this.texid.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
            this.textdescripcion.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();

            this.comboestado.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();


        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            texid.Clear();
            textdescripcion.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.texid.Text);
            string Descripcion = textdescripcion.Text;
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

               Tipos_Vehiculos c = new Tipos_Vehiculos
                {
                    id = id,
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
            int id = Convert.ToInt16(this.texid.Text);
            string Descripcion = textdescripcion.Text;

            string estado = comboestado.Text;


            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault(x => x.id == id);

                c.Descripcion = Descripcion;

                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.texid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Vehiculos c = contexto.Tipos_Vehiculos.FirstOrDefault(x => x.id == id);

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
