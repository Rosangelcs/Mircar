﻿using System;
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
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet9.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter1.Fill(this.rentcarDataSet9.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet7.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rentcarDataSet7.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet5.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.rentcarDataSet5.Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet4.Empleados' Puede moverla o quitarla según sea necesario.
            /*this.empleadosTableAdapter.Fill(this.rentcarDataSet4.Empleados);*/
            cargar();
        }

        private void cargar()

        {


            RentcarEntities contexto = new RentcarEntities();
            dat1.DataSource = contexto.Renta_Devolucion.ToList();
        }
        private void llenar()
        {
            
            this.textempleado.Text = dat1.SelectedRows[0].Cells[1].Value.ToString();
            this.textvehiculo.Text = dat1.SelectedRows[0].Cells[2].Value.ToString();
            this.textcliente.Text = dat1.SelectedRows[0].Cells[3].Value.ToString();
            dat1.SelectedRows[0].Cells[4].Value = dateTimePicker1.Value.ToString("dd-MM-yyyyy");
            dat1.SelectedRows[0].Cells[5].Value = dateTimePicker1.Value.ToString("dd-MM-yyyyy");
            this.textmonto.Text = dat1.SelectedRows[0].Cells[6].ToString();
            this.textdias.Text = dat1.SelectedRows[0].Cells[7].ToString();
            this.textcomentario.Text = dat1.SelectedRows[0].Cells[8].ToString();
            this.comboestado.Text = dat1.SelectedRows[0].Cells[9].ToString();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
          
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

            ValidarCampos();


            int idempleado = int.Parse(this.textempleado.Text);
            string vehiculo = textvehiculo.Text;
            string cliente = textcliente.Text;
            var Fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int monto = int.Parse(this.textmonto.Text);
            int dias = int.Parse(this.textdias.Text);
            string comentarios = textcomentario.Text;
            string estado = comboestado.Text;

    

            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = new Renta_Devolucion
                {
                   
                    id_empleado = idempleado,
                    Vehiculo = vehiculo,
                    cliente = cliente,
                    Fecha_renta = DateTime.ParseExact(fecha, "yyyy-MM-dd", null),
                    Fecha_devolucion = DateTime.ParseExact(fecha, "yyyy-MM-dd", null),
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

        void ValidarCampos()
        {
            DateTime hoy = DateTime.Today;
            if (dateTimePicker1.Value.Date < hoy)
        {
                MessageBox.Show("Vehiculo rentado", "Seleccione otro día",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            int idempleado = int.Parse(this.textempleado.Text);
            string vehiculo = textvehiculo.Text;
            string cliente = textcliente.Text;

            int monto = int.Parse(this.textmonto.Text);
            int dias = int.Parse(this.textdias.Text);
            string comentarios = textcomentario.Text;
            string estado = comboestado.Text;



            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = contexto.Renta_Devolucion.FirstOrDefault();
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
           
            using (RentcarEntities contexto = new RentcarEntities())
            {

                Renta_Devolucion c = contexto.Renta_Devolucion.FirstOrDefault();
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
