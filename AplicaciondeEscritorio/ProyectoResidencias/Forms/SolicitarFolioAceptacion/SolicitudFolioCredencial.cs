using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class SolicitudFolioCredencial : Form
    {
        #region Variables
        private string cadenaconexion;
        private List<int> lista = new List<int>();


        #endregion
        public SolicitudFolioCredencial(string a, List<int> b)
        {
            InitializeComponent();
            this.cadenaconexion = a;
            this.lista = b;
            CargarTabla();

        }

        private void CargarTabla()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                     select new SolicitudFolioAceptacionList
                                     {
                                         ID = e.ID_Estudiante,
                                         Numero = "",
                                         Asunto = "Credencial de " + pg.Nombre_Programa + " para " + dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         Destinatario = "NESTOR LARA COBOS JEFE DE DEPTO.DE SERVICIOS CORPORATIVOS AIPBN02"
                                     }).AsQueryable();

                listabusqueda = listabusqueda.Where(l => lista.Contains(l.ID));
                dataGridView2.DataSource = listabusqueda.ToList();


            }

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                foreach (var variable in lista)
                {
                    var registro = context.Avance.SingleOrDefault(n => n.ID_Avance == variable);
                    if (registro != null)
                    {
                        registro.Peticion_Credencial = 1;
                        registro.Fecha_Peticion_Credencial = DateTime.Today;
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Peticion de folio registrada correctamente!");

            }
        }
    }
}
