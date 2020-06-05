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
    public partial class CredencialesSolicitadasUC : UserControl
    {
        private string cadenaconexion;
        public CredencialesSolicitadasUC()
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
                var query = (from e in context.Estudiante
                             join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                             join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                             join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                             where (av.Estado == true && av.Peticion_Credencial == 1 && av.Credencial == false)
                             select new CredencialesDisponiblescls
                             {
                                 ID = e.ID_Estudiante,
                                 Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                 FolioCredencial = av.ID_Credencial.ToString(),
                                 FechaSolicitud = av.Fecha_Peticion_Credencial.ToString(),
                                 FechaDisponible = av.Fecha_Llegada_Credencial.ToString()
                             }).ToList();


                credencialesDisponiblesclsBindingSource.DataSource = query;

            }


        }
    }
}
