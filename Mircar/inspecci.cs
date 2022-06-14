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
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet11.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter3.Fill(this.rentcarDataSet11.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet10.Empleados' Puede moverla o quitarla según sea necesario.
          /*  this.empleadosTableAdapter2.Fill(this.rentcarDataSet10.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet8.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter1.Fill(this.rentcarDataSet8.Empleados);*/
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rentcarDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Empleados' Puede moverla o quitarla según sea necesario.
           /* this.empleadosTableAdapter.Fill(this.rentcarDataSet.Empleados);*/
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Tipos_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tipos_VehiculosTableAdapter.Fill(this.rentcarDataSet.Tipos_Vehiculos);
            cargar();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            
            combovehiculo.Items.Clear();
            comboidcliente.Items.Clear();
            comboempleado.Items.Clear();
            

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string Vehiculo = combovehiculo.Text.Trim();
            int idcliente = int.Parse(this.comboidcliente.Text);
            string ralladura = comboralladura.Text;
            string cantidadcomb = combocombustible.Text;
            string gomares = combogoma.Text;
            string gato = combogato.Text;
            string cristal = comborotura.Text;
            string estadogom = checkBox6.Text;
           
            int idemple = int.Parse(this.comboempleado.Text);
            var fecha = datetime.Value.ToString("yyyy-MM-dd");
            string estado = comboestado.Text;

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Inspeccion c = new Inspeccion
                {
                    
                    Vehiculo = Vehiculo,
                    id_cliente = idcliente,
                    Ralladura = ralladura,
                    Cantidad_Combustible = cantidadcomb,
                    Goma_repueta = gomares,
                    Gato = gato,
                    Cristal = cristal,
                     Estado_gomas = estadogom,
                     id_empleado = idemple,
                    Fecha = DateTime.ParseExact(fecha, "yyyy-MM-dd", null),
                    Estado = estado


                };
                contexto.Inspeccion.Add(c);
                contexto.SaveChanges();
                cargar();
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            
            string Vehiculo = combovehiculo.Text;
            int idcliente = int.Parse(this.comboidcliente.Text);
            string ralladura = comboralladura.Text;
            string cantidadcomb = combocombustible.Text;
            string gomares = combogoma.Text;
            string gato = combogato.Text;
            string cristal = comborotura.Text;
            string estadogom = checkBox6.Text;
            int idemple = int.Parse(this.comboempleado.Text);
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Inspeccion c = contexto.Inspeccion.FirstOrDefault();
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

            using (RentcarEntities contexto = new RentcarEntities())
            {
               
                Inspeccion c = contexto.Inspeccion.FirstOrDefault();
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
            this.combovehiculo.Text = dat1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            this.comboidcliente.Text = dat1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            this.comboralladura.Text = dat1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            this.combocombustible.Text = dat1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            this.combogoma.Text = dat1.SelectedRows[0].Cells[5].Value.ToString().Trim();
            this.combogato.Text = dat1.SelectedRows[0].Cells[6].Value.ToString().Trim();
            this.comborotura.Text = dat1.SelectedRows[0].Cells[7].Value.ToString().Trim();
            this.checkBox5.Text = dat1.SelectedRows[0].Cells[8].Value.ToString().Trim();
            this.comboempleado.Text = dat1.SelectedRows[0].Cells[9].Value.ToString().Trim();
            dat1.SelectedRows[0].Cells[10].Value = datetime.Value.ToString("dd-MM-yyyyy");
            this.checkBox7.Text = dat1.SelectedRows[0].Cells[11].Value.ToString().Trim();
            this.checkBox8.Text = dat1.SelectedRows[0].Cells[12].Value.ToString().Trim();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[13].Value.ToString().Trim(); 

        
           
          
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

