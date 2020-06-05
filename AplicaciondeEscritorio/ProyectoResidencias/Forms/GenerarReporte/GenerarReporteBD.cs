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
using ProyectoResidencias.Clases;
using System.Diagnostics;

namespace ProyectoResidencias.Forms.GenerarReporte
{
    public partial class GenerarReporteBD : Form
    {
        #region variables

        public string Cadenaconexion;
        private List<int> ListaIds = new List<int>();
        private List<int> ListaIdsTodos = new List<int>();

        private List<Base> Listaapoyo = new List<Base>();
        private List<Base> Agregar_Info = new List<Base>();
        private List<LstReportes> ListaReportes = new List<LstReportes>();
        private List<LstReportes> ListaApoyoReportes = new List<LstReportes>();
        private List<ReportesEnt> ListaApoyoFinalReportes = new List<ReportesEnt>();
        private List<ReportesEnt> ListaFinalReportes = new List<ReportesEnt>();

        #endregion

        public GenerarReporteBD(string cadena)
        {
            InitializeComponent();
            Cadenaconexion = cadena;

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

        private void Obtener_Estudiantes_Activos()
        {
            using (var context = new Base_Servicio_PracticasEntities(Cadenaconexion))
            {
                var conteo = (from e in context.Estudiante
                              join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                              join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                              where (av.Estado == true)
                              select e.ID_Estudiante);


                ListaIds = conteo.ToList();

            }


        }

        private void Obtener_Todos_Los_Estudiantes()
        {
            using (var context = new Base_Servicio_PracticasEntities(Cadenaconexion))
            {
                var conteo = (from e in context.Estudiante
                              join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                              join av in context.Avance on pg.ID_Programa equals av.ID_Avance

                              select e.ID_Estudiante);


                ListaIdsTodos = conteo.ToList();

            }


        }


        private void Obtener_Lista_Reportes()
        {
            using (var context = new Base_Servicio_PracticasEntities(Cadenaconexion))
            {
                for (int i = 0; i <= ListaIds.Count - 1; i++)
                {
                    int num = ListaIds[i];
                    ListaApoyoReportes.Clear();
                    var listabusqueda = (from r in context.Reportes
                                         select new LstReportes

                                         {
                                             ID = r.ID_Reportes,
                                             ID_Avance = r.ID_Avance,
                                             Mes_Entrega = r.Mes_Entrega,
                                             FechaEntrega = r.Fecha_Entrega
                                         }).Where(f => f.ID_Avance.Equals(num)).AsQueryable();
                    ListaApoyoReportes = listabusqueda.ToList();
                    if (ListaApoyoReportes.Count > 0)
                    {
                        for (int j = 0; j <= ListaApoyoReportes.Count - 1; j++)
                        {
                            ListaReportes.Add(ListaApoyoReportes[j]);
                        }
                    }
                }
            }
        }

        private void CrearListaFinalReportes()
        {
            using (var context = new Base_Servicio_PracticasEntities(Cadenaconexion))
            {
                for (int i = 0; i <= ListaIds.Count - 1; i++)
                {
                    int num = ListaIds[i];
                    ListaApoyoFinalReportes.Clear();
                    var listabusqueda = (from e in context.Estudiante
                                         join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                         join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                         join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                         select new ReportesEnt
                                         {
                                             ID = e.ID_Estudiante,
                                             FolioAcept = av.ID_Aceptacion.ToString(),
                                             Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                             FechaInicio = pg.Fecha_Inicio,
                                             FechaTermino = pg.Fecha_Final,

                                         }).Where(f => f.ID.Equals(num)).AsQueryable();
                    ListaApoyoFinalReportes = listabusqueda.ToList();

                    foreach (var item in ListaReportes.Where(n => n.ID_Avance == num))
                    {
                        ListaApoyoFinalReportes[0].MesEntregado = ListaApoyoFinalReportes[0].MesEntregado + item.Mes_Entrega + ",";
                    }

                    ListaFinalReportes.Add(ListaApoyoFinalReportes[0]);

                }
            }
        }

        private void Obtener_Datos_Base()
        {

            using (var context = new Base_Servicio_PracticasEntities(Cadenaconexion))
            {
                for (int i = 0; i <= ListaIdsTodos.Count - 1; i++)
                {
                    int num = ListaIdsTodos[i];
                    Listaapoyo.Clear();
                    var listabusqueda = (from e in context.Estudiante
                                         join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                         join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                         join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                         join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                         join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                         join car in context.Carrera on de.ID_Carrera equals car.ID_Carrera
                                         join enc in context.Encargado_Escuela on de.ID_Persona_Enc equals enc.ID_Encargado
                                         join ar in context.Area on e.ID_Area equals ar.ID_Area
                                         join ast in context.Asesor_Tecnico on ar.ID_Asesor equals ast.ID_Asesor
                                         join dep in context.Departamento on ar.ID_Departamento equals dep.ID_Departamento

                                         select new Base

                                         {
                                             ID = e.ID_Estudiante,
                                             FolioAcept = av.ID_Aceptacion.ToString(),
                                             FolioCred = av.ID_Credencial.ToString(),
                                             FolioTerm = av.ID_Terminacion.ToString(),
                                             Area = dep.Departamento1,
                                             FechaEntrada = pg.Fecha_Inicio,
                                             FechaTermino = pg.Fecha_Final,
                                             HoraEntrada = pg.Hora_Inicio,
                                             HoraSalida = pg.Hora_Termino,
                                             Escuela = esc.Nombre_Escuela,
                                             Carrera = car.Nombre_Carrera,
                                             Matricula = de.Matricula,
                                             Programa = pg.Nombre_Programa,
                                             Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                             Asesor = ast.Nombre1_Asesor + " " + ast.Nombre2_Asesor + " " + ast.Apellido_Paterno + " " + ast.Apellido_Materno,
                                             Extension = ast.Extension,
                                             Edad = dp.Edad.ToString(),
                                             Correo = dp.Correo,
                                             Genero = dp.Sexo,
                                             Celular = dp.Celular,
                                             Duracion = pg.Horas_Totales,
                                             Estado_Del_Curso = av.Curso_De_Induccion.ToString(),
                                             Estado = av.Estado.ToString(),



                                         }).Where(f => f.ID.Equals(num)).AsQueryable();
                    Listaapoyo = listabusqueda.ToList();

                    Agregar_Info.Add(Listaapoyo[0]);
            

                }

            }

        }


        private void  Crear_Excel()
        {
            Excel.Application Aplicacion = new Excel.Application();
            Excel.Workbook Libro = null;
            Excel.Worksheet BaseDatos = null;
            Excel.Worksheet Reportes = null;


            string Origen = Directory.GetCurrentDirectory();
            string Plantilla = Origen + @"\Templates\BasedeDatos.xlsx";
            Libro = (Excel.Workbook)Aplicacion.Workbooks.Add(Plantilla);

            
            BaseDatos = Libro.Worksheets[1];
            Reportes = Libro.Worksheets[2];

            Generar_Base_De_Datos(Aplicacion, Libro, BaseDatos);
            Generar_Reportes_Entregdos( Reportes);
            Abrir_Excel_Generado(Aplicacion,Libro);

        }

        private void Generar_Base_De_Datos(Excel.Application App, Excel.Workbook Book, Excel.Worksheet SheetBase)
        {

            for (int fila = 2; fila <= Agregar_Info.Count + 1; fila++)
            {

                for (int celda = 0; celda <= Agregar_Info.Count - 1; celda++)
                {
                    fila += 1;
                    SheetBase.Cells[fila, 1] = Agregar_Info[celda].FolioAcept;
                    SheetBase.Cells[fila, 2] = Agregar_Info[celda].FolioCred;
                    SheetBase.Cells[fila, 3] = Agregar_Info[celda].FolioTerm;
                    SheetBase.Cells[fila, 4] = Agregar_Info[celda].Nombre;
                    SheetBase.Cells[fila, 5] = Agregar_Info[celda].Programa;
                    SheetBase.Cells[fila, 6] = Agregar_Info[celda].MesEntradaString;
                    SheetBase.Cells[fila, 7] = Agregar_Info[celda].FechaEntrada;
                    SheetBase.Cells[fila, 8] = Agregar_Info[celda].FechaTermino;
                    SheetBase.Cells[fila, 9] = Agregar_Info[celda].HoraEntrada;
                    SheetBase.Cells[fila, 10] = Agregar_Info[celda].HoraSalida;
                    SheetBase.Cells[fila, 11] = Agregar_Info[celda].Duracion + " HRS.";
                    SheetBase.Cells[fila, 12] = Agregar_Info[celda].Area;
                    SheetBase.Cells[fila, 13] = Agregar_Info[celda].Asesor;
                    SheetBase.Cells[fila, 14] = Agregar_Info[celda].Extension;
                    SheetBase.Cells[fila, 15] = Agregar_Info[celda].Escuela;
                    SheetBase.Cells[fila, 16] = Agregar_Info[celda].Carrera;
                    SheetBase.Cells[fila, 17] = Agregar_Info[celda].Matricula;
                    SheetBase.Cells[fila, 18] = Agregar_Info[celda].Edad;
                    SheetBase.Cells[fila, 19] = Agregar_Info[celda].Genero;
                    SheetBase.Cells[fila, 20] = Agregar_Info[celda].Celular;
                    SheetBase.Cells[fila, 21] = Agregar_Info[celda].Correo;
                    SheetBase.Cells[fila, 22] = Agregar_Info[celda].Estado_Del_Curso; //Curso
                    SheetBase.Cells[fila, 23] = Agregar_Info[celda].Estado; //Estado



                }

            }

        }

        private void Generar_Reportes_Entregdos(Excel.Worksheet SheetReportes)
        {


            for (int fila = 1; fila <= ListaIds.Count + 1; fila++)
            {

                for (int celda = 0; celda <= ListaFinalReportes.Count - 1; celda++)
                {
                    fila += 1;
                    SheetReportes.Cells[fila, 1] = ListaFinalReportes[celda].FolioAcept;
                    SheetReportes.Cells[fila, 2] = ListaFinalReportes[celda].Nombre;
                    SheetReportes.Cells[fila, 3] = ListaFinalReportes[celda].FechaTermino;
                    SheetReportes.Cells[fila, 4] = ListaFinalReportes[celda].FechaTermino;
                    SheetReportes.Cells[fila, 5] = ListaFinalReportes[celda].MesEntregado;


                }


            }

        }

        private void Abrir_Excel_Generado(Excel.Application App, Excel.Workbook Book)
        {

            Book.SaveAs(txtRuta.Text);
            Book.Close();
            Book = null;
            App.Visible = false;
            App.Quit();

            try
                {

                    DialogResult Resultado = MessageBox.Show("¡Documento generado correctamente! \n ¿Desea abrir el documento?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Resultado == DialogResult.Yes)
                    {
                        Excel.Application Abrir = new Excel.Application();
                        Excel.Workbook Libro2;
                        Libro2 = Abrir.Workbooks.Open(txtRuta.Text);
                        Abrir.Visible = true;
                        this.Dispose();

                    }
                    if (Resultado == DialogResult.No)
                    {

                        App.Quit();
                        this.Dispose();

                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("El documento no fue generado debido a que se encuentra abierto, cierre el archivo y vuelva a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void GenerarReporteDB_Click(object sender, EventArgs e)
        {
            Obtener_Estudiantes_Activos();
            Obtener_Todos_Los_Estudiantes();
            Obtener_Datos_Base();
            Obtener_Lista_Reportes();
            CrearListaFinalReportes();
            //Obtener_Datos_Reportes();
            Crear_Excel();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}