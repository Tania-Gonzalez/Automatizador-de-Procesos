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
    public partial class BusquedaAsesorTecnico : UserControl
    {
        #region Variables
        private int ID_a,ID_jef,ID_ases;
        private string CadenaConexion;

        #endregion
        public BusquedaAsesorTecnico()
        {
            InitializeComponent();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar el asesor tecnico?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditAsesor(ID_a, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        private void panelAsesorTecnico_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetValues(int a, string b)
        {
            ID_a = a;
            CadenaConexion = b;
            Cargar();
            
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datosarea = context.Area.ToList();
                foreach (var valores in datosarea.Where(n => n.ID_Area == ID_a))
                {
                    ID_ases = valores.ID_Asesor.GetValueOrDefault();
                    ID_jef = valores.ID_Jefe_Area.GetValueOrDefault();

                }
                var datosasesor = context.Asesor_Tecnico.ToList();
                foreach (var valores in datosasesor.Where(n => n.ID_Asesor== ID_ases))
                {
                    NomAsesorBA.Text = valores.Nombre1_Asesor + " " + valores.Nombre2_Asesor + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    CargoAsesorBA.Text = valores.Cargo;
                    FichaAsesorBA.Text = valores.Ficha;
                    ExtenAsesorBA.Text = valores.Extension;

                }
                var datosjefe = context.Jefe_Area.ToList();
                foreach (var valores in datosjefe.Where(n => n.ID_Jefe_Area == ID_jef))
                {
                    NomJefeBA.Text = valores.Nombre1_Jefe + " " + valores.Nombre2_Jefe + " " + valores.Apellido_Paterno_Jefe + " " + valores.Apellido_Materno_Jefe;
                    FichaJefeBa.Text = valores.Ficha;
                }


                }

        }
    }
}
