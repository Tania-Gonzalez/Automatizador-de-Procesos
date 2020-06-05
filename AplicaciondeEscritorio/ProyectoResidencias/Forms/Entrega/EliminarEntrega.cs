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
    public partial class EliminarEntrega : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av;
        private string CadenaConexion;

        #endregion
        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                EliminarCartaAceptacion();
               

            }
            if (comboBox1.SelectedIndex == 1)
            {
                EliminarCredencial();

            }

            if (comboBox1.SelectedIndex == 2)
            {
                EliminarTerminacionArea();

            }

            if (comboBox1.SelectedIndex == 3)
            {
                EliminarCartaTerminacion();

            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una opcion");
            }
        }

        private void EliminarCartaTerminacion()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.Carta_Terminacion = false;
                    a.Fecha_Carta_Terminacion = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");

            }
        }

        private void EliminarTerminacionArea()
        {

            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.Carta_Terminacion_Area = false;
                    a.Fecha_Carta_Terminacion_Area = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");

            }
        }

        private void EliminarCredencial()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.Credencial = false;
                    a.Fecha_Credencial = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");

            }
        }

        private void EliminarCartaAceptacion()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.Carta_Aceptacion = false;
                    a.Fecha_Carta_Aceptacion = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public EliminarEntrega(string a, int b)
        {
            InitializeComponent();
            this.ID_Est = b;
            this.CadenaConexion = a;
            Cargar();
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Estudiante.ToList();
                foreach (var valores in item.Where(n => n.ID_Estudiante == ID_Est))
                {
                    this.ID_Prog = valores.ID_Programa;
                    this.ID_Dp = valores.ID_Datos_Personales;
                }
                var item2 = context.Programa.ToList();
                foreach (var valores in item2.Where(n => n.ID_Programa == this.ID_Prog))
                {
                    this.ID_Av = valores.ID_Avance;
                }
                var item3 = context.Datos_Personales.ToList();
                foreach (var valores in item3.Where(n => n.ID_Datos_Personales == this.ID_Dp))
                {
                    Nombre.Text = valores.Nombre1 + " " + valores.Nombre2 + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                }
            }
        }
    }
}
