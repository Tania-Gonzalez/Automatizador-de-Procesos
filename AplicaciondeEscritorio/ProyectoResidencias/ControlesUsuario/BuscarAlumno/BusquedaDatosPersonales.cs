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
    public partial class BusquedaDatosPersonales : UserControl
    {
        #region Variables
        private int ID;
        private string CadenaConexion;
        #endregion


        public BusquedaDatosPersonales()
        {
            InitializeComponent();
        }
        public void SetValues(int a, string b)
        {
            ID = a;
            CadenaConexion = b;
            Cargar();


        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Datos_Personales.ToList();

                foreach (var valores in item.Where(n => n.ID_Datos_Personales == ID))
                {
                    NomEstudianteBA.Text = valores.Nombre1 + " " + valores.Nombre2 + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    CurpBA.Text = valores.Curp;
                    EstadoCivilBA.Text = valores.Estado_Civil;
                    CorreoBA.Text = valores.Correo;
                    FechaNacBA.Text = valores.Fecha_Nacimiento.ToShortDateString();
                    CelularEstBA.Text = valores.Celular;
                    EdadBA.Text = valores.Edad.ToString();
                    GeneroBa.Text = valores.Sexo;
                    BAlabelTelefonoEstudiante.Text = valores.Telefono_Fijo;

                }


            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar los datos personales?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditDatosPersonales(ID,CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }
    }
}
