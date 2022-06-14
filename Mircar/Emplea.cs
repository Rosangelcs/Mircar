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
    public partial class Emplea : Form
    {
        public Emplea()
        {
            InitializeComponent();
        }

        private void Emplea_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Empleados.ToList();
        }
        private void llenar()
        {
          
            this.textnombre.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            
            this.combotanda.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[3].ToString();
            dat1.SelectedRows[0].Cells[4].Value = dateTimePicker1.Value.ToString("dd-MM-yyyyy");


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            
            textnombre.Clear();
            
            text.Clear();



        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            string Nombre = textnombre.Text;
          

            string Tanda_labor = combotanda.Text;
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = contexto.Empleados.FirstOrDefault();
                
                c.Nombre = Nombre;
               
                c.Tanda_labor = Tanda_labor;
                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
         
            string Nombre = textnombre.Text;

         
            string Tanda_labor = combotanda.Text;
            var fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = new Empleados
                {

                    Nombre = Nombre,
                    
                    Fecha_ingreso =   DateTime.ParseExact(fecha, "yyyy-MM-dd", null),
                    Tanda_labor = Tanda_labor,
                    Estado = estado
                };

                contexto.Empleados.Add(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = contexto.Empleados.FirstOrDefault();
                contexto.Empleados.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void dat1_Click(object sender, EventArgs e)
        {
            llenar();

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

