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
    public partial class CartasSolicitadasUC : UserControl
    {
        private string cadenaconexion;
        public CartasSolicitadasUC()
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
                var queryacept = (from e in context.Estudiante
                                  join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                  join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                  join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                  where (av.Estado == true && av.Peticion_Carta_Aceptacion == 1 && av.Carta_Aceptacion == false)
                                  select new CartasAceptacionDispliblescls
                                  {
                                      ID = e.ID_Estudiante,
                                      Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                      FolioCarta = av.ID_Aceptacion.ToString(),
                                      FechaSolicitud = av.Fecha_Peticion_Carta_Aceptacion.ToString(),
                                      FechaDisponible = av.Fecha_Llegada_Carta_Aceptacion.ToString()
                                  }).ToList();

                var queryter = (from e in context.Estudiante
                                join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                where (av.Estado == true && av.Peticion_Carta_Terminacion == 1 && av.Carta_Terminacion == false)
                                select new CartasTerminacionDispliblescls
                                {
                                    ID = e.ID_Estudiante,
                                    Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                    FolioCarta = av.ID_Terminacion.ToString(),
                                    FechaSolicitud = av.Fecha_Peticion_Carta_Terminacion.ToString(),
                                    FechaDisponible = av.Fecha_Llegada_Carta_Terminacion.ToString()
                                }).ToList();
                cartasAceptacionDispliblesclsBindingSource.DataSource = queryacept;

                cartasTerminacionDispliblesclsBindingSource.DataSource = queryter;




            }


        }
    }
}
