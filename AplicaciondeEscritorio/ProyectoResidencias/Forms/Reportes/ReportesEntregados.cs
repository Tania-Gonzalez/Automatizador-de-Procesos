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
    public partial class ReportesEntregados : Form
    {
        private string CadenaConexion;
        private int ID_EST;
     
        public ReportesEntregados(string a, int b)
        {
            InitializeComponent();
            CadenaConexion = a;
            ID_EST = b;
            Cargar();
        }
        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var query = (from e in context.Estudiante
                             join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                             join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                             join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                             join r in context.Reportes on av.ID_Avance equals +r.ID_Avance
                             where (av.Estado == true && e.ID_Estudiante == ID_EST)
                             select new ReportesEntregadoscls
                             {
                                 ID=e.ID_Estudiante,
                                 Nombre=dp.Nombre1+" "+dp.Nombre2+" "+dp.Apellido_Paterno+" "+dp.Apellido_Materno,
                                 MesEntregado=r.Mes_Entrega,
                                 FechaDT=r.Fecha_Entrega,
                                 FolioAcept=av.ID_Aceptacion.ToString(),
                                 Estado=av.Estado.ToString()



                             }
                             ).AsQueryable().ToList();
                dataGridView1.DataSource = query;
               
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                using (var a = new AgregarReporte(CadenaConexion, ID_EST))

                {
                    a.ShowDialog();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                using (var a = new EliminarReporte(CadenaConexion, ID_EST))

                {
                    a.ShowDialog();
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
