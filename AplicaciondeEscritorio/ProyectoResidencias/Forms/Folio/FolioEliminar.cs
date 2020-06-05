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
    public partial class FolioEliminar : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av;
        private string CadenaConexion;

        #endregion
        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if ( comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione alguna opcion o llene el folio a registrar");

            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    EliminarFolioAceptacion();

                }
                if (comboBox1.SelectedIndex == 1)
                {
                    EliminarFolioCredencial();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    EliminarFolioTerminacion();
                }



            }
        }

        private void EliminarFolioTerminacion()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.ID_Terminacion = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");
                comboBox1.SelectedIndex = -1;

            }
        }

        private void EliminarFolioCredencial()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.ID_Credencial = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");
                comboBox1.SelectedIndex = -1;

            }
        }

        private void EliminarFolioAceptacion()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                if (a != null)
                {
                    a.ID_Aceptacion = null;
                    context.SaveChanges();
                }
                MessageBox.Show("Modificacion Correcta");
                comboBox1.SelectedIndex = -1;

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        public FolioEliminar(string a, int b)
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
