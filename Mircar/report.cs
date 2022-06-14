using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;

namespace Mircar
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rentcarDataSet.Clientes);

        }

        private void btnreporte_Click(object sender, EventArgs e, Document document)
        {
            if (grid.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf)";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if(save.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(save.FileName))
                    {

                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        } 
                    }
                        if (!ErrorMessage)
                         {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(grid.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 10;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in grid.Columns)
                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);


                            }
                            foreach (DataGridViewRow  viewRow in grid.Rows)
                            {
                                foreach (DataGridViewCell dCell in viewRow.Cells)
                                {
                                  pTable.AddCell(dCell.Value.ToString());

                                }

                            }


                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {
                                Document document1 = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();


                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }



                        catch (Exception ex)
                        {
                        MessageBox.Show("Error while exporting Data"+ex.Message);
                                    
                                }   
                }

            }
        }
    
         else
     {
        MessageBox.Show("No Record Found","Info");
    }

    }



    }

}



