using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias.Forms.Curso
{

    public partial class Programar_curso : Form
    {

        #region Variables
        private string cadenaconexion;
        private List<int> lista = new List<int>();


        #endregion
        public Programar_curso(string a, List<int> b)
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
                                     join ar in context.Area on e.ID_Area equals ar.ID_Area
                                     join dep in context.Departamento on ar.ID_Departamento equals dep.ID_Departamento
                                     join ase in context.Asesor_Tecnico on ar.ID_Asesor equals ase.ID_Asesor
                                     select new Curso_Prog_Induccion
                                     {
                                         ID = e.ID_Estudiante,
                                         Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         Area = dep.Departamento1,
                                         Asesor = ase.Nombre1_Asesor + " " + ase.Nombre2_Asesor + " " + ase.Apellido_Paterno + " " + ase.Apellido_Materno,
                                         Correo = dp.Correo,


                                     }).AsQueryable();

                listabusqueda = listabusqueda.Where(l => lista.Contains(l.ID));
                dataGridViewCurso.DataSource = listabusqueda.ToList();


            }

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void Programar_Click(object sender, EventArgs e)
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                foreach (var variable in lista)
                {
                    var registro = context.Avance.SingleOrDefault(n => n.ID_Avance == variable);
                    if (registro != null)
                    {
                        registro.Curso_De_Induccion = 1;
                        registro.Fecha_Curso_Induccion = DateTime.Today;
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("¡Curso Programado correctamente!");

            }
        }
    }
}
