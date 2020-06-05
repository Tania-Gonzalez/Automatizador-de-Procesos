using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProyectoResidencias
{
    public partial class NuevoRegistroDatosPersonales : UserControl
    {
        #region Delegadores
        public delegate void GDatosPersonales(List<string> a);
        public event GDatosPersonales GuardarDatosPersonales;

        #endregion
        #region Variables
        private List<string> ListaDatosPersonales = new List<string>();



        #endregion

        #region Constructores
        public NuevoRegistroDatosPersonales()
        {
            InitializeComponent();
          

        }

        #endregion

        #region MetodosApoyo 
        public void Limpiar()
        {
            ListaDatosPersonales.Clear();

            GeneroNR.SelectedIndex = -1;
            EstadoCivilNR.SelectedIndex = -1;
            NomEstudianteNR.Text = null;
            NomEstudiante2NR.Text = null;
            ApeEstudianteNR.Text = null;
            ApeEstudiante2NR.Text = null;
            CalendarioFechaNacimiento.Value = DateTime.Today;
            EdadNR.Text = "0";
            TextboxGenero.Text = null;
            TextoEdoCivil.Text = null;
            CurpEstudianteNR.Text = null;
            CelularEstudianteNR.Text = null;
            TelFijoEstudianteNR.Text = null;
            CorreoEstudianteNR.Text = null;
            
            


        }
        public void Cancelar(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.Clear();
                          
        }

        public bool Comprobar()
        {
            bool r;
           if( string.IsNullOrEmpty(NomEstudianteNR.Text)|| string.IsNullOrEmpty(ApeEstudianteNR.Text)|| Int32.Parse(EdadNR.Text) < 16|| string.IsNullOrEmpty(TextoEdoCivil.Text) || string.IsNullOrEmpty(TextboxGenero.Text) || string.IsNullOrEmpty(CurpEstudianteNR.Text)|| string.IsNullOrEmpty(CelularEstudianteNR.Text)|| string.IsNullOrEmpty(CorreoEstudianteNR.Text))
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
            if (EstadoCivilNR.SelectedIndex==-1)
            {
                TextoEdoCivil.Text = null;

            }
            else
            {
                TextoEdoCivil.Text = EstadoCivilNR.SelectedItem.ToString();

            }
            
        }







        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            var cumple = CalendarioFechaNacimiento.Value;
            var today = DateTime.Today;

            if (DateTime.Now.DayOfYear < cumple.DayOfYear)
            {
                
                int edad = today.Year - cumple.Year;
                edad = edad - 1;
                EdadNR.Text = edad.ToString();
            }

            else{
                int edad = today.Year - cumple.Year;
                EdadNR.Text = edad.ToString();


            }


        }

        

        public void CapitalLetter(TextBox a)
        {
            if (a.Text==" ")
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
                else { a.Text = "";}
                
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



        #endregion



        private void CalendarioFechaNacimiento_Leave(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var cumple = CalendarioFechaNacimiento.Value;
            int edad = today.Year - cumple.Year;
            if (DateTime.Now.DayOfYear < cumple.Year)
            {
                edad = edad - 1;
            }
            EdadNR.Text = edad.ToString();
           
        }

        private void BtnGuardarDatosPersonalesNR_Click(object sender, EventArgs e)
        {
           
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (Comprobar()==false)
                {
                    MessageBox.Show("Datos Incompletos");
                }
                if (Comprobar() == true)
                {
                    ListaDatosPersonales.Clear();
                    ListaDatosPersonales.Add(NomEstudianteNR.Text);
                    ListaDatosPersonales.Add(NomEstudiante2NR.Text);
                    ListaDatosPersonales.Add(ApeEstudianteNR.Text);
                    ListaDatosPersonales.Add(ApeEstudiante2NR.Text);
                    ListaDatosPersonales.Add(TextboxGenero.Text);
                    ListaDatosPersonales.Add(EdadNR.Text);
                    ListaDatosPersonales.Add(TextoEdoCivil.Text);
                    ListaDatosPersonales.Add(CalendarioFechaNacimiento.Value.ToString());
                    ListaDatosPersonales.Add(TelFijoEstudianteNR.Text);
                    ListaDatosPersonales.Add(CelularEstudianteNR.Text);
                    ListaDatosPersonales.Add(CorreoEstudianteNR.Text);
                    ListaDatosPersonales.Add(CurpEstudianteNR.Text);


                    GuardarDatosPersonales.Invoke(ListaDatosPersonales);
                }
              

            }
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
            if (Int32.Parse(EdadNR.Text)<16)
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
            if (GeneroNR.SelectedIndex==-1)
            {
                TextboxGenero.Text = null;

            }
            else
            {
                TextboxGenero.Text = GeneroNR.SelectedItem.ToString();

            }
            
        }

        private void panelDatosPersonalesNR_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

