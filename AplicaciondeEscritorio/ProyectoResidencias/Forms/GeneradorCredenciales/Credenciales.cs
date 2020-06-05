using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.IO;


namespace ProyectoResidencias

{
    public partial class Credenciales : Form
    {
        #region variables
        private string CadenaConexion;
        private List<int> ListaIds = new List<int>();
        private List<CredencialesCls> listaapoyo = new List<CredencialesCls>();
        private List<CredencialesCls> Agregar_Info = new List<CredencialesCls>();


        #endregion
        public Credenciales(string cadena, List<int> ids)
        {
            InitializeComponent();
            this.CadenaConexion = cadena;
            this.ListaIds = ids;
            Cargar();
        }

        public void Cargar()
        {        
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                for (int i = 0; i <= ListaIds.Count - 1; i++)
                {
                    int num = ListaIds[i];
                    listaapoyo.Clear();
                    var listabusqueda = (from e in context.Estudiante
                                         join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                         join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                         join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                         join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                         join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                         join enc in context.Encargado_Escuela on de.ID_Persona_Enc equals enc.ID_Encargado
                                         join ar in context.Area on e.ID_Area equals ar.ID_Area                          
                                         join dep in context.Departamento on ar.ID_Departamento equals dep.ID_Departamento
                                         select new CredencialesCls

                                         {
                                             ID = e.ID_Estudiante,
                                             Area = dep.Departamento1,
                                             FechaInicioDT=pg.Fecha_Inicio,
                                             FechaTerminoDT=pg.Fecha_Final,
                                             HoraEntrada=pg.Hora_Inicio,
                                             HoraSalida=pg.Hora_Termino,
                                             FolioAceptacion = av.ID_Aceptacion.ToString(),
                                             Escuela = esc.Nombre_Escuela,
                                             Programa = pg.Nombre_Programa,
                                             Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,


                                         }).Where(f => f.ID.Equals(num)).AsQueryable();
                    listaapoyo = listabusqueda.ToList();

                    Agregar_Info.Add(listaapoyo[0]);
                }

            }
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
                    txtRuta.Text += ".docx";
                }
            }
        }

        private void GenerarEtiquetas_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtRuta.Text))
            {

                MessageBox.Show("Agrega una Ruta para la Creación del Documento");

            }

            else
            {

             

                if (string.IsNullOrEmpty(txtRuta.Text))
                {
                    MessageBox.Show("Agrega una Ruta para la Creación del Documento");
                }
                else
                {
                    string origen = Directory.GetCurrentDirectory();
                    string Plantilla = origen + @"\Templates\Credenciales.docx";
                    string Imagen = origen + @"\Templates\Credencial.png";

                    Word.Application App = new Word.Application();
                    Document Doc = App.Documents.Add(Plantilla);

                    if (System.IO.File.Exists(Plantilla) && System.IO.File.Exists(Imagen))
                    {
                        for (int c = 0; c <= ListaIds.Count-1; c++)
                        {

                            Doc.Bookmarks["NOMBRE" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["ID" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorRed;
                            Doc.Bookmarks["PROGRAMA" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["AREA" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["ENTRADASALIDA" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["ESCUELA" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["PERIODO" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
             

                            Doc.Bookmarks["ACTIVIDAD" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["COORDINACION" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["HORARIO" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["INSTITUCION" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;
                            Doc.Bookmarks["VIGENCIA" + Convert.ToString(c+1)].Range.Font.Color = Word.WdColor.wdColorBlack;


                            Doc.Bookmarks["NOMBRE" + Convert.ToString(c+1)].Range.Text = "C. " + Agregar_Info[c].Nombre + ".";
                            Doc.Bookmarks["ID" + Convert.ToString(c+1)].Range.Text = "ID:" + Agregar_Info[c].FolioAceptacion;
                            Doc.Bookmarks["PROGRAMA" + Convert.ToString(c+1)].Range.Text = Agregar_Info[c].Programa;
                            Doc.Bookmarks["AREA" + Convert.ToString(c+1)].Range.Text = Agregar_Info[c].Area;
                            Doc.Bookmarks["ENTRADASALIDA" + Convert.ToString(c+1)].Range.Text = "DE " + Agregar_Info[c].HoraEntrada + " A " + Agregar_Info[c].HoraSalida + " HRS.";
                            Doc.Bookmarks["ESCUELA" + Convert.ToString(c+1)].Range.Text = Agregar_Info[c].Escuela;// Abreviatura
                            Doc.Bookmarks["PERIODO" + Convert.ToString(c+1)].Range.Text = "DEL " + Agregar_Info[c].FechaInicio + " AL " + Agregar_Info[c].FechaTermino;
                      


                            var AgregarImagen = Doc.InlineShapes.AddPicture(Imagen);
                            AgregarImagen.Height = 152;
                            AgregarImagen.Width = 270;

                            GenerarEtiquetas.Visible = false;
                            labelGenerando.Visible = true;
                            labelGenerando.Location = new System.Drawing.Point(192, 281);

                        }
                        try
                        {
                           
                            GenerarEtiquetas.Visible = true;
                            labelGenerando.Visible = false;
                            Doc.SaveAs2(txtRuta.Text);
                            App.Quit();
                            DialogResult Resultado = MessageBox.Show("¡Documento generado correctamente! \n ¿Desea abrir el documento?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                            if (Resultado == DialogResult.Yes)
                            {


                                Word.Application ap = new Word.Application();
                                Document g = ap.Documents.Open(txtRuta.Text);
                                ap.Visible = true;
                                this.Dispose();
                                


                            }
                            if (Resultado == DialogResult.No)
                            {

                                this.Dispose();

                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El documento no fue generado debido a que se encuentra abierto, cierre el archivo y vuelva a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    else
                    {
                        MessageBox.Show("Falló", "El Programa no encontró las Plantillas ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
