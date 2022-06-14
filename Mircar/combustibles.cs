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
            this.textdescripcion.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();

            this.comboestado.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();


        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
            textdescripcion.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string Descripcion = textdescripcion.Text.Trim();
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {


                Tipos_Combustibles c = new Tipos_Combustibles
                {
                    
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
            
            string Descripcion = textdescripcion.Text;

            string estado = comboestado.Text;


            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault();

                c.Descripcion = Descripcion;

                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
      
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Tipos_Combustibles c = contexto.Tipos_Combustibles.FirstOrDefault();

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

        private void dat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
