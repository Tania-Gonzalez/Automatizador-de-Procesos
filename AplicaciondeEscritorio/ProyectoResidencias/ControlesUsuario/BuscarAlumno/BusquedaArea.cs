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
    public partial class BusquedaArea : UserControl
    {
        #region Variables
        private int ID_a;
        private int? ID_p, ID_dep;
        
        private string CadenaConexion;
        #endregion
        public BusquedaArea()
        {
            InitializeComponent();
        }

        public void SetValues(int a, string b)
        {
            ID_a = a;
            CadenaConexion = b;
            Cargar();


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar el area?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditArea(ID_a, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datosarea = context.Area.ToList();
                foreach (var valores in datosarea.Where(n => n.ID_Area == ID_a))
                {
                    ID_p =  valores.ID_Puerta;
                    ID_dep = valores.ID_Departamento;

                }

                var datospuerta = context.Puerta.ToList();
                foreach (var valores in datospuerta.Where(n => n.ID_Puerta== ID_p))
                {
                    PuertaBA.Text = valores.Nombre;
                }
                var datosdepartamento = context.Departamento.ToList();
                foreach (var valores in datosdepartamento.Where(n=>n.ID_Departamento==ID_dep))
                {
                    DepartamnetoBA.Text = valores.Departamento1;
                    ClaveDepBA.Text = valores.Clave_Departamento;
                    subdireccionBA.Text = valores.Subdireccion;
                    ClaveSudBA.Text = valores.Clave_Subdireccion;
                    GerenciaBA.Text = valores.Gerencia_Unidad;
                    ClaveGeBA.Text = valores.Clave_Gerencia;
                    UbicacionBA.Text = valores.Direccion;
                }


            }

        }
    }
}
