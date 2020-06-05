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
    public partial class BusquedaDatosEscolares : UserControl
    {
        #region Variables
        private int ID, idp, idesc, idcar;
        private string CadenaConexion;

        #endregion

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar los datos escolares?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditDatosEscolares(ID, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        public BusquedaDatosEscolares()
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
                var datosescolares = context.Datos_Escolares.ToList();
                var carreras = context.Carrera.ToList();
                var encargados = context.Encargado_Escuela.ToList();
                var escuelas = context.Escuela.ToList();
                foreach (var valores in datosescolares.Where(n => n.ID_Datos_Escolares == ID))
                {
                    PromedioBA.Text = valores.Promedio_General.ToString();
                    SemestreBA.Text = valores.Semestre;
                    MatriculaAB.Text = valores.Matricula;
                    idesc = valores.ID_Escuela;
                    idp = valores.ID_Persona_Enc;
                    idcar = valores.ID_Carrera;

                }
                foreach (var valores in carreras.Where(n=>n.ID_Carrera==idcar))
                {
                    CarreraBA.Text = valores.Nombre_Carrera;
                    NivelAB.Text = valores.Escolaridad;
                }
                foreach (var valores in encargados.Where(n => n.ID_Encargado== idp))
                {
                    NomEncBA.Text = valores.Nombre1_Encargado + " " + valores.Nombre2_Encargado + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    CargoEncBA.Text = valores.Cargo;
                    TelEncBA.Text = valores.Telefono;
                    CorreoEncBA.Text = valores.Correo;


                }
                foreach (var valores in escuelas.Where(n => n.ID_Escuela == idesc))
                {
                    EscuelaBA.Text = valores.Nombre_Escuela;
                }

                }

        }
    }
}
