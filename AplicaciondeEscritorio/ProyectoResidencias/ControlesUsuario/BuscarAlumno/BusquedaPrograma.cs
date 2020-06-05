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
    public partial class BusquedaPrograma : UserControl
    {
        #region Variables
        private int ID;
        private string CadenaConexion;

        #endregion

        public BusquedaPrograma()
        {
            InitializeComponent();
        }

        public void SetValues(int a, string b)
        {
            ID = a;
            CadenaConexion = b;
            Cargar();


        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datosprograma = context.Programa.ToList();

                foreach (var valores in datosprograma.Where(n => n.ID_Programa== ID))

                {
                    ProgramaBA.Text = valores.Nombre_Programa;
                    HorasTotalesBA.Text = valores.Horas_Totales.ToString();
                    HorasDiariasBA.Text = valores.Horas_Diarias.ToString();
                    FechaInicioBA.Text = valores.Fecha_Inicio.ToShortDateString();
                    FechaTerminacionBA.Text = valores.Fecha_Final.ToShortDateString();
                    HoraEntradaBA.Text = valores.Hora_Inicio;
                    HoraSalidaBA.Text = valores.Hora_Termino;
                    txtActividades.Text = valores.Actividades;
                    txtProyecto.Text = valores.Nombre_Proyecto;
                }

                }

            }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditPrograma(ID, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }
    }
}
