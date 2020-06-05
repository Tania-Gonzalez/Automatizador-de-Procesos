using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectoResidencias.Forms.GenerarExcel
{
    public partial class ExportarExcelGraficas : Form
    {

        #region variables

        private string CadenaConexion;
        private List<int> ListaIds = new List<int>();


        #endregion
        public ExportarExcelGraficas(string cadena, List<int> ids)
        {
            InitializeComponent();
            this.CadenaConexion = cadena;
            this.ListaIds = ids;

        }
    

        private void GenerarExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            
            

        }

        private void Generar()
        {
            Excel.Application App = new Excel.Application();
            Excel.Workbook Libro = null;
            Excel.Worksheet Hoja = null;
            Excel.Range Rango = null;

            String Titulo = "REPORTE GENERAL DE INFORMACIÓN DE ESTUDIANTES";
            Libro = (Excel.Workbook)App.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Hoja = (Excel.Worksheet)Libro.Worksheets.Add();
            Hoja.Name = "REPORTE";
            ((Excel.Worksheet)App.ActiveWorkbook.Sheets["Hoja1"]).Delete();

            Hoja.Cells[2, 2] = Titulo;

            Libro.SaveAs(txtRuta.Text);
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            string RutaArchivo = string.Empty;
            SaveFileDialog GuardarRuta = new SaveFileDialog();

            if (GuardarRuta.ShowDialog() == DialogResult.OK)
            {
                RutaArchivo = GuardarRuta.FileName;
                RutaArchivo = RutaArchivo.Trim('.');
                txtRuta.Text = RutaArchivo;

                if (Path.HasExtension(txtRuta.Text) == false)
                {
                    txtRuta.Text += ".xlsx";
                }
            }
        }

       
    }
}
