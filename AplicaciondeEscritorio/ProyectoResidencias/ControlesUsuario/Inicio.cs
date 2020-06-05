using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;


namespace ProyectoResidencias
{
    public partial class Bienvenida : UserControl
    {
        #region Variables
        private string CadenaConexion;
        private List<Accesoscls> queryaccesos = new List<Accesoscls>();
        private List<ProgramasCls> queryprograma = new List<ProgramasCls>();
        private List<EscuelasCls> queryescuelas = new List<EscuelasCls>();
        private List<CarrerasCls> querycarreras = new List<CarrerasCls>();
        private List<Turnocls> queryturnos = new List<Turnocls>();
        private List<Origencls> queryorigen = new List<Origencls>();

        #endregion
        public Bienvenida()
        {
            InitializeComponent();

            this.MensajeInfo.SetToolTip(ExportarExcel, "Exportar a Excel las gráficas en forma de tablas");
        }
        public void SetCD(string t)
        {
            CadenaConexion = t;
        }
        public void Carga(string? Cadena)
        {
            CadenaConexion = Cadena;

            CargarAccesos();
            CargarProgramas();
            CargarAlumnos();
            CargarEscuelas();
            CargarCarreras();
            CargarTurnos();
            CargarOrigen();
        }

        private void CargarAccesos()
        {
            queryaccesos.Clear();
            GraficoAcessos.Series.Clear();
            GraficoAcessos.Titles.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {                
                var puerta = context.Puerta.ToList();
                foreach (var variables in puerta)
                {
                    var ent = (from e in context.Estudiante 
                               join ar in context.Area on e.ID_Area equals ar.ID_Area
                               join pt in context.Puerta on ar.ID_Puerta equals pt.ID_Puerta
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               where (av.Estado == true && pt.ID_Puerta==variables.ID_Puerta)
                               select e.ID_Estudiante).Count();
                               
                    Accesoscls subquerypuertas = new Accesoscls
                    {
                        Cantidad = ent,
                        Nombre = variables.Nombre
                    };
                    if (subquerypuertas.Cantidad>0)
                    {
                        queryaccesos.Add(subquerypuertas);

                    }
                    
                }          
            }
            GraficoAcessos.Series.Add("Accesos");
            GraficoAcessos.Series["Accesos"].IsValueShownAsLabel = true;
            GraficoAcessos.Series["Accesos"].ChartType=SeriesChartType.Pie;
            GraficoAcessos.Titles.Add("Cantidad de estudiantes por puerta");            
            foreach (var variables in queryaccesos)
            {
                GraficoAcessos.Series["Accesos"].Points.AddXY(variables.Nombre,variables.Cantidad);
            }
            GraficoAcessos.Update();
        }
        private void CargarProgramas()
        {
            GraficoPrograma.Titles.Clear();
            GraficoPrograma.Series.Clear();
            queryprograma.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var cantss = (from e in context.Estudiante
                              join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                              join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                              where (av.Estado == true && pg.Nombre_Programa == "Servicio Social")
                              select e.ID_Estudiante).Count();

                var cantpp = (from e in context.Estudiante
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               where (av.Estado == true && pg.Nombre_Programa== "Prácticas Profesionales")
                               select e.ID_Estudiante).Count();
             
                ProgramasCls programasCls = new ProgramasCls
                {
                    SS= "Servicio Social",
                    PP= "Prácticas Profesionales",
                    CantidadSS=cantss,
                    CantidadPP=cantpp

                };
                queryprograma.Add(programasCls);

            }
            GraficoPrograma.Series.Add("Programa");
         

            GraficoPrograma.Series["Programa"].IsValueShownAsLabel = true;
            GraficoPrograma.Series["Programa"].ChartType = SeriesChartType.Doughnut;
            GraficoPrograma.Titles.Add("Cantidad de estudiantes por programa");
            if (queryprograma[0].CantidadSS>0)
            {
                GraficoPrograma.Series["Programa"].Points.AddXY(queryprograma[0].SS, queryprograma[0].CantidadSS);
            }
            if (queryprograma[0].CantidadPP>0)
            {
                GraficoPrograma.Series["Programa"].Points.AddXY(queryprograma[0].PP, queryprograma[0].CantidadPP);
            }
  
  
          

        }

        private void CargarAlumnos()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                var total = (from e in context.Estudiante
                             join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                             join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                             where (av.Estado == true)
                             select e.ID_Estudiante).Count();
                lbAlmunosActivos.Text = total.ToString();
                var mujeres = (from e in context.Estudiante
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                               where (av.Estado == true && dp.Sexo == "Femenino")
                               select e.ID_Estudiante).Count();
                lbMujeresCantidad.Text = mujeres.ToString();

                var hombres = (from e in context.Estudiante
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                               where (av.Estado == true && dp.Sexo != "Femenino")
                               select e.ID_Estudiante).Count();
                lbHombresCantidad.Text = hombres.ToString();

 
            }
        }
        
        private void CargarEscuelas() 
        {
            queryescuelas.Clear();
            GraficoEscuelas.Titles.Clear();
            GraficoEscuelas.Series.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var escuela = context.Escuela.ToList();
                foreach (var variables in escuela )
                {
                    var ent = (from e in context.Estudiante
                               join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                               join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               where (av.Estado == true && esc.ID_Escuela == variables.ID_Escuela)
                               select e.ID_Estudiante).Count();
                    EscuelasCls subqueryescuelas = new EscuelasCls
                    {
                        Cantidad = ent,
                        Escuela = variables.Nombre_Escuela
                    };
                    if (subqueryescuelas.Cantidad > 0)
                    {
                        queryescuelas.Add(subqueryescuelas);

                    }
                }
            }         
            GraficoEscuelas.Titles.Add("Cantidad de estudiantes por escuela");
            foreach (var variables in queryescuelas)
            {
                Series s = GraficoEscuelas.Series.Add(variables.Escuela);

                s.Label = variables.Cantidad.ToString();
                s.Points.Add(variables.Cantidad);              
            }
        }
        
        private void CargarCarreras()
        {
            querycarreras.Clear();
            GraficoCarreras.Titles.Clear();
            GraficoCarreras.Series.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var carreras = context.Carrera.ToList();
                foreach (var variables in carreras)
                {
                    var ent = (from e in context.Estudiante
                               join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                               join car in context.Carrera on de.ID_Carrera equals car.ID_Carrera
                               join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                               join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                               where (av.Estado == true && car.ID_Carrera == variables.ID_Carrera)
                               select e.ID_Estudiante).Count();
                    CarrerasCls suquerycarreras = new CarrerasCls
                    {
                        NombreCarrera = variables.Nombre_Carrera,
                        Total = ent
                    };
                    if (suquerycarreras.Total > 0)
                    {
                        querycarreras.Add(suquerycarreras);
                    }
                }
            }
            GraficoCarreras.Titles.Add("Cantidad de estudiantes por carrera");
            foreach (var variables in querycarreras)
            {                
                Series s = GraficoCarreras.Series.Add(variables.NombreCarrera);
                GraficoCarreras.Series[variables.NombreCarrera].ChartType = SeriesChartType.Column;
                s.Label = variables.Total.ToString();
                s.Points.Add(variables.Total);
            }
          
        }
        private void CargarTurnos()
        {
            queryturnos.Clear();
            GraficoTurnos.Titles.Clear();
            GraficoTurnos.Series.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
         
                List<string> listamat = new List<string>()
                {
                    "08:00","09:00","10:00","11:00",
                    "08:15","09:15","10:15","11:15",
                    "08:30","09:30","10:30","11:30",
                    "08:45","09:45","10:45","11:45",

                };
                List<string> listaves = new List<string>()
                {
                    "12:00","13:00","14:00",
                    "12:15","13:15","14:15",
                    "12:30","13:30","14:30",
                    "12:45","13:45","14:45",

                };
              
                  
                var entm = (from e in context.Estudiante
                            join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                            join car in context.Carrera on de.ID_Carrera equals car.ID_Carrera
                            join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                            join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                            where (av.Estado == true&& listamat.Contains(pg.Hora_Inicio))
                            select e.ID_Estudiante).Count();

                var entv = (from e in context.Estudiante
                            join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                            join car in context.Carrera on de.ID_Carrera equals car.ID_Carrera
                            join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                            join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                            where (av.Estado == true && listaves.Contains(pg.Hora_Inicio))
                            select e.ID_Estudiante).Count();

                Turnocls turnoves = new Turnocls
                {
                    Turno =  "Vespertino",                 
                    Cantidad = entv
                };
                queryturnos.Add(turnoves);
                Turnocls turnomat = new Turnocls
                {
                    Turno = "Matutino",
                    Cantidad = entm
                };
                queryturnos.Add(turnomat);

            }
            GraficoTurnos.Series.Add("Turnos");


            GraficoTurnos.Series["Turnos"].IsValueShownAsLabel = true;
            GraficoTurnos.Series["Turnos"].ChartType = SeriesChartType.Doughnut;
            GraficoTurnos.Titles.Add("Cantidad de estudiantes por turno");
            if (queryturnos[0].Cantidad > 0)
            {
                GraficoTurnos.Series["Turnos"].Points.AddXY(queryturnos[0].Turno, queryturnos[0].Cantidad);
            }
            if (queryturnos[1].Cantidad > 0)
            {
                GraficoTurnos.Series["Turnos"].Points.AddXY(queryturnos[1].Turno, queryturnos[1].Cantidad);
            }






        }

        private void CargarOrigen()
        {
            queryorigen.Clear();
            GraficoOrigen.Titles.Clear();
            GraficoOrigen.Series.Clear();
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var entloc = (from e in context.Estudiante
                              join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                              join dir in context.Direccion on dp.ID_Direccion equals dir.ID_Direccion
                              join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                              join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                              where (av.Estado == true && dir.ID_Direccion_Renta==null)
                              select e.ID_Estudiante).Count();
                var entfor = (from e in context.Estudiante
                              join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                              join dir in context.Direccion on dp.ID_Direccion equals dir.ID_Direccion
                              join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                              join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                              where (av.Estado == true && dir.ID_Direccion_Renta != null)
                              select e.ID_Estudiante).Count();

                Origencls origenlocal = new Origencls
                {
                    Lugar = "Local",
                    Cantidad = entloc
                };
                queryorigen.Add(origenlocal);
                Origencls origenforaneo = new Origencls
                {
                    Lugar = "Foraneo",
                    Cantidad = entfor
                };
                queryorigen.Add(origenforaneo);
            }
            
            GraficoOrigen.Series.Add("Origen");


            GraficoOrigen.Series["Origen"].IsValueShownAsLabel = true;
            GraficoOrigen.Series["Origen"].ChartType = SeriesChartType.Pie;
            GraficoOrigen.Titles.Add("Cantidad de estudiantes por origen de procedencia");
            if (queryorigen[0].Cantidad > 0)
            {
                GraficoOrigen.Series["Origen"].Points.AddXY(queryorigen[0].Lugar, queryorigen[0].Cantidad);
            }
            if (queryorigen[1].Cantidad > 0)
            {
                GraficoOrigen.Series["Origen"].Points.AddXY(queryorigen[1].Lugar, queryorigen[1].Cantidad);
            }
            GraficoOrigen.Palette = ChartColorPalette.SeaGreen;
            
        }

        private void ExportarGraficas()
        { 
         
        
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
