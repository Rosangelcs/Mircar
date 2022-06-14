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
    public partial class Renta : Form
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Renta_Devolucion.ToList();
        }
        private void llenar()
        {
            this.textrenta.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
            this.textempleado.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            this.textvehiculo.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();
            this.textcliente.Text = dat1.SelectedRows[0].Cells[3].Value.ToString();
            this.textmonto.Text = dat1.SelectedRows[0].Cells[4].ToString();
            this.textdias.Text = dat1.SelectedRows[0].Cells[5].ToString();
            this.textcomentario.Text = dat1.SelectedRows[0].Cells[6].ToString();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[7].ToString();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            textrenta.Clear();
            textempleado.Clear();
            textvehiculo.Clear();
            textcliente.Clear();
            textmonto.Clear();
            textdias.Clear();
            textcomentario.Clear();
            

            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
  

            int id = int.Parse(this.textrenta.Text);
            int idempleado = int.Parse(this.textempleado.Text);
            string vehiculo = textvehiculo.Text;
            string cliente = textcliente.Text;
            int monto = int.Parse(this.textmonto.Text);
            int dias = int.Parse(this.textdias.Text);
            string comentarios = textcomentario.Text;
            string estado = comboestado.Text;

    

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = new Renta_Devolucion
                {
                    id = id,
                    id_empleado = idempleado,
                    Vehiculo = vehiculo,
                    cliente = cliente,
                    monto = monto,
                    Cantidad_Dias = dias,
                    Comentario = comentarios,
                    Estado = estado

                    


                };
                contexto.Renta_Devolucion.Add(c);
                contexto.SaveChanges();
                cargar();
            }


        }


    private void btneditar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(this.textrenta.Text);
            int idempleado = int.Parse(this.textempleado.Text);
            string vehiculo = textvehiculo.Text;
            string cliente = textcliente.Text;

            int monto = int.Parse(this.textmonto.Text);
            int dias = int.Parse(this.textdias.Text);
            string comentarios = textcomentario.Text;
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = contexto.Renta_Devolucion.FirstOrDefault(x => x.id ==id);
                c.id_empleado = idempleado;
                c.Vehiculo = vehiculo;
                c.cliente = cliente;
                c.monto = monto;
                c.Cantidad_Dias = dias;
                c.Comentario = comentarios;
                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.textrenta.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = contexto.Renta_Devolucion.FirstOrDefault(x => x.id == id);
                contexto.Renta_Devolucion.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
