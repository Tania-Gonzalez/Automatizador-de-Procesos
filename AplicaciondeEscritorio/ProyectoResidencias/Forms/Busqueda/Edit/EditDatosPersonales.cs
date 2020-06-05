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
    public partial class EditDatosPersonales : Form
    {
        #region Variables
        private int ID_dp;
        private string CadenaConexion;
       
        #endregion
        public EditDatosPersonales(int a, string b)
        {
            InitializeComponent();
            ID_dp = a;
            CadenaConexion = b;
            Cargar();
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Datos_Personales.ToList();
                foreach (var valores in item.Where(n => n.ID_Datos_Personales == ID_dp))
                {
                    NomEstudianteNR.Text = valores.Nombre1;
                    NomEstudiante2NR.Text = valores.Nombre2;
                    ApeEstudianteNR.Text = valores.Apellido_Paterno;
                    ApeEstudiante2NR.Text = valores.Apellido_Materno;
                    CalendarioFechaNacimiento.Value = valores.Fecha_Nacimiento;
                    EdadNR.Text = valores.Edad.ToString();
                    TextboxGenero.Text = valores.Sexo;
                    TextoEdoCivil.Text = valores.Estado_Civil;
                    CurpEstudianteNR.Text = valores.Curp;
                    CelularEstudianteNR.Text = valores.Celular;
                    TelFijoEstudianteNR.Text = valores.Telefono_Fijo;
                    CorreoEstudianteNR.Text = valores.Correo;               
                    

                }

            }
        }

        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(NomEstudianteNR.Text) || string.IsNullOrEmpty(ApeEstudianteNR.Text) || Int32.Parse(EdadNR.Text) < 16 || string.IsNullOrEmpty(TextoEdoCivil.Text) || string.IsNullOrEmpty(TextboxGenero.Text) || string.IsNullOrEmpty(CurpEstudianteNR.Text) || string.IsNullOrEmpty(CelularEstudianteNR.Text) || string.IsNullOrEmpty(CorreoEstudianteNR.Text))
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != ' '))

            {
                e.Handled = true;


            }


        }


        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void GeneroNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextboxGenero.Text = GeneroNR.SelectedItem.ToString();
        }

        private void EstadoCivilNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EstadoCivilNR.SelectedIndex == -1)
            {
                TextoEdoCivil.Text = null;

            }
            else
            {
                TextoEdoCivil.Text = EstadoCivilNR.SelectedItem.ToString();

            }

        }

        private void CalendarioFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var cumple = CalendarioFechaNacimiento.Value;
            int edad = today.Year - cumple.Year;
            if (DateTime.Now.DayOfYear < cumple.DayOfYear)
            {
                edad = edad - 1;
            }
            EdadNR.Text = edad.ToString();
        }



        public void CapitalLetter(TextBox a)
        {
            if (a.Text == " ")
            {
                a.Text = "";
            }

            string texto = a.Text;
            char[] letras;
            List<char> lista = new List<char>();
            if (a.Text.Length > 1)
            {
                letras = texto.ToCharArray();
                for (int i = 0; i <= letras.Length - 2; i++)
                {

                    if (letras[i] == ' ' && letras[i + 1] == ' ')
                    {

                    }
                    else
                    {
                        lista.Add(letras[i]);
                        if (i == letras.Length - 2)
                        {
                            lista.Add(letras[i + 1]);
                        }

                    }

                }

                if (lista.Count > 1)
                {
                    if (lista.First() == ' ')

                    {
                        lista.RemoveAt(0);

                    }

                    if (lista.Last() == ' ')

                    {
                        lista.RemoveAt(lista.Count - 1);

                    }

                    letras = lista.ToArray();
                    texto = new string(letras);


                    String[] Vector1 = texto.Split(' ');
                    String Palabra;


                    for (int i = 0; i < Vector1.Length; i++)

                    {
                        Palabra = Vector1[i];
                        Palabra = Palabra.Substring(0, 1).ToUpper() + Palabra.Substring(1).ToLower(); //0 es el primer char de la palabra y 1 es la palabra
                        Vector1[i] = Palabra;
                    }

                    string union = string.Join(" ", Vector1);
                    a.Text = union;

                }
                else { a.Text = ""; }

            }
        }



        private void NomEstudianteNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomEstudianteNR);



        }

        private void NomEstudiante2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomEstudiante2NR);

        }

        private void ApeEstudianteNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeEstudianteNR);

        }

        private void ApeEstudiante2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeEstudiante2NR);
        }







        private void CalendarioFechaNacimiento_Leave(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var cumple = CalendarioFechaNacimiento.Value;
            int edad = today.Year - cumple.Year;
            EdadNR.Text = edad.ToString();

        }

        private void NomEstudianteNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomEstudianteNR.Text))
            {

                errorProvider1.SetError(NomEstudianteNR, "Campo Obligatorio");


            }
            else
            {

                errorProvider1.SetError(NomEstudianteNR, null);
            }
        }

        private void ApeEstudianteNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ApeEstudianteNR.Text))
            {


                errorProvider1.SetError(ApeEstudianteNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider1.SetError(ApeEstudianteNR, null);
            }
        }

        private void CalendarioFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(EdadNR.Text) < 16)
            {


                errorProvider1.SetError(CalendarioFechaNacimiento, "Edad erronea");

            }
            else
            {

                errorProvider1.SetError(CalendarioFechaNacimiento, null);
            }
        }

        private void GeneroNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TextboxGenero.Text))
            {


                errorProvider1.SetError(GeneroNR, "Seleccione una opcion");

            }
            else
            {

                errorProvider1.SetError(GeneroNR, null);
            }
        }

        private void EstadoCivilNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TextoEdoCivil.Text))
            {

                errorProvider1.SetError(EstadoCivilNR, "Seleccione una opcion");

            }
            else
            {

                errorProvider1.SetError(EstadoCivilNR, null);
            }
        }

        private void CurpEstudianteNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CurpEstudianteNR.Text))
            {

                errorProvider1.SetError(CurpEstudianteNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider1.SetError(CurpEstudianteNR, null);
            }
        }

        private void CelularEstudianteNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CelularEstudianteNR.Text))
            {

                errorProvider1.SetError(CelularEstudianteNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider1.SetError(CelularEstudianteNR, null);
            }
        }

        private void CorreoEstudianteNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CorreoEstudianteNR.Text))
            {


                errorProvider1.SetError(CorreoEstudianteNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider1.SetError(CorreoEstudianteNR, null);
            }
        }

        private void PanelDatosPersonalesNR_Click(object sender, EventArgs e)
        {
            panelDatosPersonalesNR.Focus();
        }

        private void GeneroNR_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (GeneroNR.SelectedIndex == -1)
            {
                TextboxGenero.Text = null;

            }
            else
            {
                TextboxGenero.Text = GeneroNR.SelectedItem.ToString();

            }

        }

        private void BtnGuardarDatosPersonalesNR_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Comprobar() == false)
                {
                    MessageBox.Show("Datos Incompletos");
                }
                if (Comprobar() == true)
                {
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Datos_Personales.SingleOrDefault(n => n.ID_Datos_Personales == ID_dp);
                        if (a != null)
                        {
                            a.Nombre1 = NomEstudianteNR.Text.Trim();
                            a.Nombre2 = NomEstudiante2NR.Text.Trim();
                            a.Apellido_Paterno = ApeEstudianteNR.Text.Trim();
                            a.Apellido_Materno = ApeEstudiante2NR.Text.Trim();
                            a.Sexo = TextboxGenero.Text;
                            a.Edad = byte.Parse(EdadNR.Text);
                            a.Estado_Civil = TextoEdoCivil.Text;
                            a.Fecha_Nacimiento = CalendarioFechaNacimiento.Value;
                            a.Telefono_Fijo = TelFijoEstudianteNR.Text;
                            a.Celular = CelularEstudianteNR.Text;
                            a.Curp = CurpEstudianteNR.Text;
                            a.Correo = CorreoEstudianteNR.Text;
                            context.SaveChanges();
                        }


                        MessageBox.Show("Modificacion Correcta");
                        this.Dispose();
                    }

                    }

                }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
