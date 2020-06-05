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
   
    public partial class FolioRegistro : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av;
        private string CadenaConexion;
        #endregion
        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Foliotxt.Text)||comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione alguna opcion o llene el folio a registrar");

            }
            else
            {
                if (comboBox1.SelectedIndex==0)
                {
                    RegistrarFolioAceptacion();

                }
                if (comboBox1.SelectedIndex==1)
                {
                    RegistarFolioCredencial();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    RegistrarFolioTerminacion();
                }

            

            }
        }

        private void RegistrarFolioTerminacion()
        {
            bool existente = false;
            int? f = Int32.Parse(Foliotxt.Text);
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.ToList();
                foreach (var valores in a)
                {
                    if (f == valores.ID_Terminacion)
                    {
                        existente = true;
                    }
                }
            }
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                if (existente == true)
                {
                    MessageBox.Show("El folio que intenta registrar ya ha sido registrado en otro alumno, ingrese otro folio");
                }
                else
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        var ev = a.ID_Terminacion;
                        if (ev == null)
                        {
                            a.ID_Terminacion = f;
                            context.SaveChanges();
                            Foliotxt.Text = null;
                            comboBox1.SelectedIndex = -1;
                            MessageBox.Show("Folio de terminacion registrado con exito");
                        }
                        else
                        {
                            MessageBox.Show("El alumno ya cuenta con un folio de terminacion, elimine el folio actual si desea registrar uno nuevo");
                        }
                    }
                }
            }

        }

        private void RegistarFolioCredencial()
        {
            bool existente = false;
            int? f = Int32.Parse(Foliotxt.Text);
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.ToList();
                foreach (var valores in a)
                {
                    if (f == valores.ID_Credencial)
                    {
                        existente = true;
                    }
                }
            }
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                if (existente == true)
                {
                    MessageBox.Show("El folio que intenta registrar ya ha sido registrado en otro alumno, ingrese otro folio");
                }
                else
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        var ev = a.ID_Credencial;
                        if (ev == null)
                        {
                            a.ID_Credencial = f;
                            context.SaveChanges();
                            Foliotxt.Text = null;
                            comboBox1.SelectedIndex = -1;
                            MessageBox.Show("Folio de credencial registrado con exito");
                        }
                        else
                        {
                            MessageBox.Show("El alumno ya cuenta con un folio de credencial, elimine el folio actual si desea registrar uno nuevo");
                        }
                    }
                }
            }
        }

        private void RegistrarFolioAceptacion()
        {
            bool existente=false;
            int? f = Int32.Parse(Foliotxt.Text);
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var a = context.Avance.ToList();
                foreach (var valores in a)
                {
                    if (f == valores.ID_Aceptacion)
                    {
                        existente = true;
                    }
                }
            }
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {                
                if (existente == true)
                {
                    MessageBox.Show("El folio que intenta registrar ya ha sido registrado en otro alumno, ingrese otro folio");
                }
                else
                {
                    var a = context.Avance.SingleOrDefault(n => n.ID_Avance == this.ID_Av);
                    if (a != null)
                    {
                        var ev = a.ID_Aceptacion;
                        if (ev==null)
                        {
                            a.ID_Aceptacion =f;
                            context.SaveChanges();
                            Foliotxt.Text = null;
                            comboBox1.SelectedIndex = -1;
                            MessageBox.Show("Folio de aceptacion registrado con exito");
                        }
                        else
                        {
                            MessageBox.Show("El alumno ya cuenta con un folio de aceptacion, elimine el folio actual si desea registrar uno nuevo");
                        }                    
                    }
                }
            }            
        }

        public FolioRegistro(string a, int b)
        {
            InitializeComponent();
            this.ID_Est = b;
            this.CadenaConexion = a;
            Cargar();

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
