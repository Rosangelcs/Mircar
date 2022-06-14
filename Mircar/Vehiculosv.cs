using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mircar
{
    public partial class Vehiculosv : Form
    {
        public Vehiculosv()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculosv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Tipos_Combustibles' Puede moverla o quitarla según sea necesario.
            this.tipos_CombustiblesTableAdapter.Fill(this.rentcarDataSet.Tipos_Combustibles);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Tipos_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tipos_VehiculosTableAdapter.Fill(this.rentcarDataSet.Tipos_Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet1.Modelos' Puede moverla o quitarla según sea necesario.
            this.modelosTableAdapter.Fill(this.rentcarDataSet1.Modelos);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.rentcarDataSet.Marcas);
            cargar();
        }
        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            grid2.DataSource = contexto.Vehiculos.ToList();
        }
        private void llenar()
        {
            this.textid.Text = grid2.SelectedRows[0].Cells[0].Value.ToString();
            this.textdescripcion.Text = grid2.SelectedRows[0].Cells[1].Value.ToString();
            this.textchasi.Text = grid2.SelectedRows[0].Cells[2].Value.ToString();
            this.textmotor.Text = grid2.SelectedRows[0].Cells[3].Value.ToString();
            this.textplaca.Text = grid2.SelectedRows[0].Cells[4].Value.ToString();
            this.combotipoveh.Text = grid2.SelectedRows[0].Cells[5].Value.ToString();
            this.combomarca.Text = grid2.SelectedRows[0].Cells[6].Value.ToString();
            this.combomodelo.Text = grid2.SelectedRows[0].Cells[7].Value.ToString();
            this.combocombustible.Text = grid2.SelectedRows[0].Cells[8].Value.ToString();
            this.comboestado.Text = grid2.SelectedRows[0].Cells[9].Value.ToString();


        }


        private void btnnuevo_Click(object sender, EventArgs e)
        {
            textid.Clear();
            textdescripcion.Clear();
            textchasi.Clear();
            textmotor.Clear();
            textplaca.Clear();
            




        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textid.Text);
            string Descripcion = textdescripcion.Text;
            int Nochasi = Convert.ToInt32(this.textchasi.Text);
            int Nomotor = Convert.ToInt32(this.textmotor.Text);
            int Noplaca = Convert.ToInt32(this.textplaca.Text);
            string Marca = combomarca.Text.Trim();
            string Modelo = combomodelo.Text.Trim();
            string tipo = combocombustible.Text.Trim();
            string vehiculotipo = combotipoveh.Text;
            string estado = comboestado.Text.Trim();
            try
            {
                using (RentcarEntities contexto = new RentcarEntities())
                {

                    Vehiculos c = new Vehiculos
                    {
                        id = id,
                        Descripcion = Descripcion,
                        No_chasis = Nochasi,
                        No_motor = Nomotor,
                        No_placa = Noplaca,
                        Tipo_Vehiculo = vehiculotipo,
                        Marca = Marca,
                        Modelo = Modelo,
                        Tipo_Combustible = tipo,
                        Estado = estado


                    };
                    contexto.Vehiculos.Add(c);
                    contexto.SaveChanges();
                    cargar();
                }
            }
            catch (DbEntityValidationException error)
            {
                foreach (var eve in error.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                
                throw;
            }  



        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.textid.Text);
            string Descripcion = textdescripcion.Text;
            int Nochasi = Convert.ToInt32(this.textchasi.Text);
            int Nomotor = Convert.ToInt32(this.textmotor.Text);
            int Noplaca = Convert.ToInt32(this.textplaca.Text);
            string Marca = combomarca.Text;
            string Modelo = combomodelo.Text.Trim();
            string tipo = combocombustible.Text.Trim();
            string vehiculotipo = combotipoveh.Text;
            string estado = comboestado.Text.Trim();


            using (RentcarEntities contexto = new RentcarEntities())
            {

                Vehiculos c = contexto.Vehiculos.FirstOrDefault(x => x.id == id);
                c.Descripcion = Descripcion;
                c.No_chasis = Nochasi;
                c.No_motor = Nomotor;
                c.No_placa = Noplaca;
                c.Marca = Marca;
                c.Modelo = Modelo;
                c.Tipo_Combustible = tipo;
                c.Tipo_Vehiculo = vehiculotipo;
                c.Estado = estado;
               
            
                contexto.SaveChanges();
                cargar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textid.Text);
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Vehiculos c = contexto.Vehiculos.FirstOrDefault(x => x.id == id);
                contexto.Vehiculos.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
    }

        private void grid2_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combotipoveh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   }


