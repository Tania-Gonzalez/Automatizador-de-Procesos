using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias.ControlesUsuario.BuscarAlumno
{
    public partial class BusquedaTutor : UserControl
    {
        #region Variables
        private int ID,ID_referencia; 
        private string CadenaConexion;

        #endregion
        public BusquedaTutor()
        {
            InitializeComponent();
        }

        public void SetValues(int a, string b)
        {
            ID = a;
            CadenaConexion = b;
            Cargar();


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar la referencia?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditTutor(ID, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datospersonales = context.Datos_Personales.ToList();
                foreach (var valores in datospersonales.Where(n=>n.ID_Datos_Personales==ID))
                {
                    ID_referencia = valores.ID_Referencia;

                }
                


                var datostutores = context.Tutor.ToList();
                foreach (var valores in datostutores.Where(n => n.ID_Ref== ID_referencia))
                {
                    NomTutorBA.Text = valores.Nombre1_Tutor + " " + valores.Nombre2_Tutor + " " + valores.Ap_P_T + " " + valores.AP_M_T;
                    TelTutorBA.Text = valores.TelefonoT;
                    NomRefBA.Text = valores.Nombre1_Ref + " " + valores.Nombre2_Ref + " " + valores.AP_P_R + " " + valores.AP_M_R;
                    TelRefBA.Text = valores.TelefonoR;

                }

            }

        }
    }
}
