using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class CursoInduccionUC : UserControl
    {
        private string cadenaconexion;
        public CursoInduccionUC()
        {
            InitializeComponent();
        }
        public void setCD(string t)
        {
            cadenaconexion = t;
            Cargar();
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var querysincurso = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     where (av.Estado == true && av.Curso_De_Induccion == 0)
                                     select new Cursocls
                                     {
                                         ID = e.ID_Estudiante,
                                         FolioAceptacion = av.ID_Aceptacion.ToString(),
                                         Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         Estado = "Sin Curso Programado"
                                     }).ToList();

                var queryprogramado = (from e in context.Estudiante
                                       join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                       join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                       join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                       where (av.Estado == true && av.Curso_De_Induccion == 1)
                                       select new Cursocls
                                       {
                                           ID = e.ID_Estudiante,
                                           FolioAceptacion = av.ID_Aceptacion.ToString(),
                                           Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                           Estado = "Curso Programado",
                                           FechaProgramado = av.Fecha_Curso_Induccion.ToString(),

                                       }).ToList();

                estudiantesSinCursoBindingSource.DataSource = querysincurso;

                estudiantesConCursoBindingSource.DataSource = queryprogramado;

              




            }


        }
    }
}
