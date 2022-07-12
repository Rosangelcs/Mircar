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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {
            cargar();
        }
       //cargar grid
        private void cargar()

        {
            
            
        RentcarEntities contexto = new RentcarEntities();
        grid.DataSource = contexto.Clientes.ToList();
        }

        //para rellenar el grid
        private void llenar ()
        {
<<<<<<< HEAD
          
=======
          this.textid.Text =  grid.SelectedRows[0].Cells[0].Value.ToString();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
          this.textnombre.Text = grid.SelectedRows[0].Cells[1].Value.ToString();
          this.textcedula.Text = grid.SelectedRows[0].Cells[2].Value.ToString();
          this.texttarjeta.Text = grid.SelectedRows[0].Cells[3].Value.ToString();
          this.combotipo.Text = grid.SelectedRows[0].Cells[4].Value.ToString();
          this.comboestado.Text = grid.SelectedRows[0].Cells[5].Value.ToString();




        }


        //para agregar 
        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            {

                if (validarFormulario() == true){ 
                guardarDatos();
           

            string Nombre= textnombre.Text;
            string Cedula= textcedula.Text;
            float Notarjeta = float.Parse(this.texttarjeta.Text);
            string tipo= combotipo.Text;
            string estado =comboestado.Text;
=======
            int id= int.Parse(this.textid.Text);
            string Nombre= textnombre.Text;
            float Cedula= float.Parse(this.textcedula.Text);
            float Notarjeta = float.Parse(this.texttarjeta.Text);
            string tipo= combotipo.Text;
            String estado =comboestado.Text;
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Clientes c = new Clientes
                {
<<<<<<< HEAD
                    
=======
                    id = id,
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                    Nombre = Nombre,
                    Cedula = Cedula,
                    No_tarjeta = Notarjeta,
                    Tipo_Persona = tipo,
                    Estado = estado
               

                };
                contexto.Clientes.Add(c);
                contexto.SaveChanges();
<<<<<<< HEAD



                cargar();
                }
                }

            }

        }


        //Validacion//
        private bool validarFormulario()
        {
            if (!validaCedula(textcedula.Text)) { 
                MessageBox.Show("La cedula es incorrecta");
              return false;
            }
            else { return true; }

            
        }

    public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        

        public void guardarDatos()
        {
            MessageBox.Show("Datos Guardados");

        }

        
=======
                cargar();
                }

           

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Clientes c = new Clientes
                {
                    id = id,
                    Nombre = Nombre,
                    Cedula = Cedula,
                    No_tarjeta = Notarjeta,
                    Tipo_Persona = tipo,
                    Estado = estado
               

                };
                contexto.Clientes.Add(c);
                contexto.SaveChanges();
                cargar();
                }
        
            }

>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
        //para limpiar
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            textnombre.Clear();
            textcedula.Clear();
            texttarjeta.Clear();
<<<<<<< HEAD
            
=======
            textid.Clear();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
           
        }

        private void grid_Click(object sender, EventArgs e)
        {
            llenar();
        }

        //para editar
        private void btneditar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
            string Nombre = textnombre.Text;
            string Cedula = textcedula.Text;
            float Notarjeta = float.Parse(this.texttarjeta.Text);
            string tipo = combotipo.Text;
            string estado = comboestado.Text;
=======
            int id = Convert.ToInt16(this.textid.Text);
            string Nombre = textnombre.Text;
            float Cedula = float.Parse(this.textcedula.Text);
            float Notarjeta = float.Parse(this.texttarjeta.Text);
            string tipo = combotipo.Text;
            String estado = comboestado.Text;
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c



            using (RentcarEntities contexto = new RentcarEntities())
            {

<<<<<<< HEAD
                Clientes c = contexto.Clientes.FirstOrDefault();
=======
                Clientes c = contexto.Clientes.FirstOrDefault(x => x.id== id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                c.Nombre = Nombre;
                c.Cedula = Cedula;
                c.No_tarjeta = Notarjeta;
                c.Tipo_Persona = tipo;
                c.Estado = estado;
                contexto.SaveChanges();
                cargar();
            }
      }
        //para eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Clientes c = contexto.Clientes.FirstOrDefault();
=======
            int id = Convert.ToInt16(this.textid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Clientes c = contexto.Clientes.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                contexto.Clientes.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

<<<<<<< HEAD

=======
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
        }

        private void textcedula_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
    }
    
    }

=======
            
        }
        public static bool textcedula_TextChange(string pCedula)
        {

            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

    }
}
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
