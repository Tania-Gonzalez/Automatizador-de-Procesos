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
    public partial class EstadoCartaAceptacion : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av;
        private string CadenaConexion;
        #endregion
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        a.Peticion_Carta_Aceptacion=0;
                        a.Fecha_Peticion_Carta_Aceptacion = null;
                        a.Fecha_Llegada_Carta_Aceptacion = null;
                        context.SaveChanges();
                    }
                    MessageBox.Show("Modificacion Correcta");
                    Cargar();
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        a.Peticion_Carta_Aceptacion = 1;
                        a.Fecha_Peticion_Carta_Aceptacion = DateTime.Today;
                        context.SaveChanges();
                    }
                    MessageBox.Show("Modificacion Correcta");
                    Cargar();
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        a.Peticion_Carta_Aceptacion = 2;
                        a.Fecha_Llegada_Carta_Aceptacion = DateTime.Today;
                        context.SaveChanges();
                    }
                    MessageBox.Show("Modificacion Correcta");
                    Cargar();
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        public EstadoCartaAceptacion(string a, int b)
        {
            InitializeComponent();
            this.ID_Est = b;
            this.CadenaConexion = a;
            Cargar();
        }

        private void Cargar()
        {
            byte edo=0;
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
                var item4 = context.Avance.Where(n => n.ID_Avance == this.ID_Av).ToList();
                foreach (var valores in item4)
                {
                    edo = valores.Peticion_Carta_Aceptacion;
                }
            }
            if (edo == 0)
            {
                Estado.Text = "Sin Solicitar";
                comboBox1.SelectedIndex = 0;
            }
            if(edo==1)
            {
                Estado.Text = "Solicitada";
                comboBox1.SelectedIndex = 1;
            }
            if (edo==2)
            {
                Estado.Text = "Recibida";
                comboBox1.SelectedIndex = 2;
            }
        }
    }
}
