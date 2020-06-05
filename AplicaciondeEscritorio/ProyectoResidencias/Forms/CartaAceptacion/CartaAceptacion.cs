using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.IO;




namespace ProyectoResidencias
{
    public partial class CartaAceptacion : Form
    {
        #region Variables
        private int ID_Alumno;
        private string CadenaConexion;
        private List<EstudianteCarta> lista = new List<EstudianteCarta>();
  
 
        #endregion
        public CartaAceptacion(int a, string b)
        {
            InitializeComponent();
            this.ID_Alumno = a;
            this.CadenaConexion = b;
            Cargar();
        }
        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                     join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                     join enc in context.Encargado_Escuela on de.ID_Persona_Enc equals enc.ID_Encargado
                                     join car in context.Carrera on de.ID_Escuela equals car.ID_Carrera
                                     join ar in context.Area on e.ID_Area equals ar.ID_Area
                                     join ass in context.Asesor_Tecnico on ar.ID_Asesor equals ass.ID_Asesor
                                     join dep in context.Departamento on ar.ID_Departamento equals dep.ID_Departamento
                                     select new EstudianteCarta

                                     {
                                         ID = e.ID_Estudiante,
                                         FechaActual = DateTime.Today,
                                         FolioAceptacion = av.ID_Aceptacion.ToString(),
                                         NombreEncargadoEscuela = enc.Nombre1_Encargado + " " + enc.Nombre2_Encargado + " " + enc.Apellido_Paterno + " " + enc.Apellido_Materno,
                                         CargoEncargado = enc.Cargo,
                                         Escuela = esc.Nombre_Escuela,
                                         Programa = pg.Nombre_Programa,
                                         NombreEstudiante = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         MatriculaEstudiante = de.Matricula,
                                         Sexo = dp.Sexo,
                                         Estado="Aceptacion",
                                         CarreraEstudiante = car.Nombre_Carrera,
                                         Proyecto = pg.Nombre_Proyecto,
                                         Actividades = pg.Actividades,
                                         Duracion = pg.Horas_Totales.ToString(),
                                         FechaInicioDT = pg.Fecha_Inicio,
                                         FechaTerminoDT=pg.Fecha_Final,
                                         HoraEntrada=pg.Hora_Inicio,
                                         HoraSalida=pg.Hora_Termino,
                                         NombreAsesor=ass.Nombre1_Asesor+" "+ass.Nombre2_Asesor+" "+ass.Apellido_Paterno+" "+ass.Apellido_Materno,
                                         CargoAsesor = ass.Cargo,
                                         Area=dep.Departamento1,
                                         Ubicacion=dep.Direccion,
                                         Extension=ass.Extension

                                     }).Where(f => f.ID.Equals(this.ID_Alumno)).AsQueryable();
                lista = listabusqueda.ToList();
                
            }       
              
            
        }


        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {


            //string RutaArchivo = string.Empty;

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

     


        private void button1_Click(object sender, EventArgs e)

        {


            if (string.IsNullOrEmpty(txtRuta.Text))
            {
                MessageBox.Show("Agrega una Ruta para la Creación del Documento");
            }
            else
            {

                string Origen = Directory.GetCurrentDirectory();
                string Plantilla = Origen + @"\Templates\CartaAceptacion.docx";

                Word.Application App = new Word.Application();
                Document Doc = App.Documents.Add(Plantilla);

                if (System.IO.File.Exists(Plantilla))
                {
                    foreach (var valores in lista)
                    {
                        Doc.Bookmarks["FechaActual"].Range.Text = valores.FechaActualWord;// fecha larga de eleboración
                        Doc.Bookmarks["IdAceptacion"].Range.Text = valores.FolioAceptacion;
                        Doc.Bookmarks["AñoActual"].Range.Text = valores.Año;
                        Doc.Bookmarks["NombreEncargadoEscuela"].Range.Text = valores.NombreEncargadoEscuela;
                        Doc.Bookmarks["CargoEncargado"].Range.Text = valores.CargoEncargado;
                        Doc.Bookmarks["Institucion"].Range.Text = valores.Escuela;
                        Doc.Bookmarks["Programa"].Range.Text = valores.Programa;
                        Doc.Bookmarks["Programa2"].Range.Text = valores.Programa2;
                        Doc.Bookmarks["NombreEstudiante"].Range.Text = valores.NombreEstudiante;
                        Doc.Bookmarks["MatriculaEstudiante"].Range.Text = valores.MatriculaEstudiante;
                        Doc.Bookmarks["Sexo"].Range.Text = valores.Ela; // el o la estudiante
                        Doc.Bookmarks["CarreraEstudiante"].Range.Text = valores.CarreraEstudiante;
                        Doc.Bookmarks["Aceptado"].Range.Text = valores.Motivo;
                        Doc.Bookmarks["Proyecto"].Range.Text = valores.Proyecto;
                        Doc.Bookmarks["Actividades"].Range.Text = valores.Actividades;
                        Doc.Bookmarks["Duracion"].Range.Text =valores.Duracion;
                        Doc.Bookmarks["FechaInicio"].Range.Text = valores.FechaInicio;
                        Doc.Bookmarks["FechaTermino"].Range.Text = valores.FechaTermino;
                        Doc.Bookmarks["HoraEntrada"].Range.Text = valores.HoraEntrada;
                        Doc.Bookmarks["HoraSalida"].Range.Text =" "+valores.HoraSalida;
                        Doc.Bookmarks["NombreAsesor"].Range.Text = valores.NombreAsesor;
                        Doc.Bookmarks["CargoAsesor"].Range.Text = valores.CargoAsesor;
                        Doc.Bookmarks["NombreAsesor2"].Range.Text = valores.NombreAsesor;
                        Doc.Bookmarks["CargoAsesor2"].Range.Text = valores.CargoAsesor;
                        Doc.Bookmarks["Area"].Range.Text = valores.Area;
                        Doc.Bookmarks["Area2"].Range.Text = valores.Area;
                        Doc.Bookmarks["Ubicacion"].Range.Text = valores.Ubicacion;
                        Doc.Bookmarks["Extension"].Range.Text =valores.Extension;

                    }

                    try
                    {
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
                    catch(Exception)
                    {
                        MessageBox.Show("El documento no fue generado debido a que se encuentra abierto, cierre el archivo y vuelva a generar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }             
                                   
                }

                else
                {
                    MessageBox.Show("Falló", "El Programa no encontró la Plantilla ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
