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
    public partial class BusquedaDireccion : UserControl
    {
        #region Variables
        private int ID_p,ID_d,ID_expediente;
        private int? id_r;
        private string CadenaConexion;
        #endregion

        public BusquedaDireccion()
        {
            InitializeComponent();
        }

        public void SetValues(int a, string b,int c)
        {
            ID_expediente=c;
            ID_p = a;
            CadenaConexion = b;
            Cargar();


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar la direccion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditDireccion(ID_d, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar la direccion de renta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditRenta(ID_d, CadenaConexion,ID_expediente))
                {

                    a.ShowDialog();

                }
            }
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datospersonales = context.Datos_Personales.ToList();
                foreach (var valores in datospersonales.Where(n=>n.ID_Datos_Personales==ID_p))
                {
                    ID_d = valores.ID_Direccion;
                }
                var datosdireccion= context.Direccion.ToList();
                foreach(var valores in datosdireccion.Where(n => n.ID_Direccion == ID_p))
                {
                    CalleBA.Text = valores.Calle;
                    NumExteriorBA.Text = valores.Numero_Exterior;
                    ColoniaBA.Text = valores.Colonia;
                    NumInteriorBA.Text = valores.Numero_Interior;
                    MunicipioBA.Text = valores.Municipio;
                    CodigoPostalBA.Text = valores.Codigo_Postal;
                    EstadoBa.Text = valores.Estado;
                    PaisBa.Text = valores.Pais;
                    if (valores.ID_Direccion_Renta==null)
                    {
                        DireccionRentaBA.Text = "Sin hoja de renta";

                    }
                    else
                    {
                        id_r = valores.ID_Direccion_Renta;
                    }
                }
                if (id_r!=null)
                {
                    var datosdireccionrenta = context.DireccionRenta.ToList();
                    foreach (var valores in datosdireccionrenta.Where(n => n.ID_Renta == id_r))
                    {
                        DireccionRentaBA.Text = valores.Calle + " " + valores.Numero_Interior + " " + valores.Colonia + " " + valores.Municipio;
                    }
                }
            }

        }
    }
}
