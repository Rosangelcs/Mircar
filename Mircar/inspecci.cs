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
    public partial class inspecci : Form
    {
        public inspecci()
        {
            InitializeComponent();
        }

        private void inspecci_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rentcarDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.rentcarDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Tipos_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tipos_VehiculosTableAdapter.Fill(this.rentcarDataSet.Tipos_Vehiculos);
            cargar();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            textid.Clear();
            

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textid.Text);
            string Vehiculo = combovehiculo.Text.Trim();
            int idcliente = int.Parse(this.comboidcliente.Text);
            string ralladura = checkBox1.Text;
            string cantidadcomb = checkBox2.Text;
            string gomares = checkBox3.Text;
            string gato = checkBox4.Text;
            string cristal = checkBox5.Text;
            string estadogom = checkBox6.Text;
            int idemple = int.Parse(this.comboempleado.Text);
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Inspeccion c = new Inspeccion
                {
                    id_Transacción = id,
                    Vehiculo = Vehiculo,
                    id_cliente = idcliente,
                    Ralladura = ralladura,
                    Cantidad_Combustible = cantidadcomb,
                    Goma_repueta = gomares,
                    Gato = gato,
                    Cristal = cristal,
                     Estado_gomas = estadogom,
                     id_empleado = idemple,
                    Estado = estado


                };
                contexto.Inspeccion.Add(c);
                contexto.SaveChanges();
                cargar();
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.textid.Text);
            string Vehiculo = combovehiculo.Text;
            int idcliente = int.Parse(this.comboidcliente.Text);
            string ralladura = checkBox1.Text;
            string cantidadcomb = checkBox2.Text;
            string gomares = checkBox3.Text;
            string gato = checkBox4.Text;
            string cristal = checkBox5.Text;
            string estadogom = checkBox6.Text;
            int idemple = int.Parse(this.comboempleado.Text);
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Inspeccion c = contexto.Inspeccion.FirstOrDefault(x => x.id_Transacción == id);

                c.Vehiculo = Vehiculo;
                c.id_cliente = idcliente;
                c.Ralladura = ralladura;
                c.Cantidad_Combustible = cantidadcomb;
                c.Goma_repueta = gomares;
                c.Gato = gato;
            
                c.Estado = estadogom;
                c.id_empleado = idemple;
                c.Estado = estado;



                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(this.textid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Inspeccion c = contexto.Inspeccion.FirstOrDefault(x => x.id_Transacción == id);
                contexto.Inspeccion.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void dat1_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Inspeccion.ToList();
        }

        //para rellenar el grid
        private void llenar()
        {
            this.textid.Text = dat1.SelectedRows[0].Cells[0].Value.ToString();
            this.combovehiculo.Text = dat1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            this.comboidcliente.Text = dat1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            this.checkBox1.Text = dat1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            this.checkBox2.Text = dat1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            this.checkBox3.Text = dat1.SelectedRows[0].Cells[5].Value.ToString().Trim();
            this.checkBox4.Text = dat1.SelectedRows[0].Cells[6].Value.ToString().Trim();
            this.checkBox5.Text = dat1.SelectedRows[0].Cells[7].Value.ToString().Trim();
            this.comboempleado.Text = dat1.SelectedRows[0].Cells[8].Value.ToString().Trim();
            this.checkBox7.Text = dat1.SelectedRows[0].Cells[9].Value.ToString().Trim();
            this.checkBox8.Text = dat1.SelectedRows[0].Cells[10].Value.ToString().Trim();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[11].Value.ToString().Trim(); 
        
           
          
        }

        private void dat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dat1_Click_1(object sender, EventArgs e)
        {
            llenar();
        }
    }


    }

