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
            this.textid.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
            this.textnombre. Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            this.textcedula.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();
            this.combotanda.Text = dat1.SelectedRows[0].Cells[3].Value.ToString();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[4].ToString();


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            textid.Clear();
            textnombre.Clear();
            textcedula.Clear();
            text.Clear();
            
            
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(this.textid .Text);
            string Nombre = textnombre.Text;
            float Cedula = float.Parse(this.textcedula.Text);
            
            string Tanda_labor = combotanda.Text;
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = contexto.Empleados.FirstOrDefault(x => x.id == id);
                c.id = id;
                c.Nombre = Nombre;
                c.Cedula = Cedula;
                c.Tanda_labor= Tanda_labor;
                c.Estado = estado;


                contexto.SaveChanges();
                cargar();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textid.Text);
            string Nombre = textnombre.Text;
        
            float Cedula = float.Parse(this.textcedula.Text);
            string Tanda_labor = combotanda.Text;
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = new Empleados
                {
                    id = id,
                    Nombre = Nombre,
                   Cedula = Cedula,
                 
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
            int id = Convert.ToInt16(this.textid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Empleados c = contexto.Empleados.FirstOrDefault(x => x.id == id);
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
    }
    }

