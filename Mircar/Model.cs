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
    public partial class Model : Form
    {
        public Model()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            grid2.DataSource = contexto.Modelos.ToList();
        }
        private void llenar()
        {
<<<<<<< HEAD
=======
            this.textid.Text = grid2.SelectedRows[0].Cells[0].Value.ToString();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            this.comboidmarca.Text = grid2.SelectedRows[0].Cells[1].Value.ToString();
            this.textdescripcion.Text = grid2.SelectedRows[0].Cells[21].Value.ToString();
            this.comboestado.Text = grid2.SelectedRows[0].Cells[3].Value.ToString();


        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            textid.Clear();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            textdescripcion.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            int id = int.Parse(this.textid.Text);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            int id_marca = int.Parse(this.comboidmarca.Text);
            string Descripcion = textdescripcion.Text;
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Modelos c = new Modelos
                {
<<<<<<< HEAD
=======
                    id = id,
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                    id_marca = id_marca,
                    Descripcion = Descripcion,
                    Estado = estado


                };
                contexto.Modelos.Add(c);
                contexto.SaveChanges();
                cargar();
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======
            int id = Convert.ToInt16(this.textid.Text);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

            int id_marca = int.Parse(this.comboidmarca.Text);

            string Descripcion = textdescripcion.Text;
            
            string estado = comboestado.Text;


            using (RentcarEntities contexto = new RentcarEntities())
            {

<<<<<<< HEAD
                Modelos c = contexto.Modelos.FirstOrDefault();
=======
                Modelos c = contexto.Modelos.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                c.id_marca = id_marca;

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

                Modelos c = contexto.Modelos.FirstOrDefault();
=======
            int id = Convert.ToInt16(this.textid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Modelos c = contexto.Modelos.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                contexto.Modelos.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void Model_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.rentcarDataSet.Marcas);

        }
<<<<<<< HEAD

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar();
        }
=======
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
    }
}
