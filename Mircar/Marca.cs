using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mircar
{
    public partial class Marca : Form
    {
        
        public Marca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void Marca_Load(object sender, EventArgs e)
        {
            cargar();

        }
        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Marcas.ToList();
        }
        private void llenar()
        {
<<<<<<< HEAD
            
            this.textdescripcion.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            
            this.comboestado.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();
=======
            this.texid.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
            this.textdescripcion.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            
            this.comboestado.Text = dat1.SelectedRows[0].Cells[9].Value.ToString();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c


        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            texid.Clear();
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
            textdescripcion.Clear();
            textbusqueda.Clear();
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

                 Marcas c = new Marcas
                {
<<<<<<< HEAD
                    
=======
                    id = id,
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
                    Descripcion = Descripcion,
                    
                    Estado = estado


                };
                contexto.Marcas.Add(c);
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
                Marcas c = contexto.Marcas.FirstOrDefault();
=======
                Marcas c = contexto.Marcas.FirstOrDefault(x => x.id == id);
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

                Marcas c = contexto.Marcas.FirstOrDefault();
=======
            int id = Convert.ToInt16(this.texid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Marcas c = contexto.Marcas.FirstOrDefault(x => x.id == id);
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c

                contexto.Marcas.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        
    }

        public List<Marcas> buscarId(int pId)
        {
            try
            {
                using (RentcarEntities contexto = new RentcarEntities())

                    return contexto.Marcas.Where(P => P.id == pId).ToList();
                 
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
                return null;

            }

        }
        private void comboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(textbusqueda.Text != "")
            {
                dat1.CurrentCell = null;
                foreach(DataGridViewRow r in dat1.Rows )
                {
                    r.Visible = false;

                }

                foreach (DataGridViewRow r in dat1.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(textbusqueda.Text.ToUpper()) ==0)
                         {
                            r.Visible = true;
                            break;

                        }

                }
                  }
            }



            else
            {
                
            }
        }
        private void textdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void texid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dat1_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
    }

