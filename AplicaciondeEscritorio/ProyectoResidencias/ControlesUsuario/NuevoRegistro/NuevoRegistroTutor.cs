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
    public partial class NuevoRegistroTutor : UserControl
    {
        #region Delegados

        public delegate void GTutor(List<string> a);
        public event GTutor GuardarTutor;

        #endregion
        #region Variables
        private List<string> ListaTutor = new List<string>();

        #endregion

        #region Constructores
        public NuevoRegistroTutor()
        {
            InitializeComponent();
        }
        #endregion

        #region MetodosApoyo
        public void Limpiar()
        {
            ListaTutor.Clear();
            NomTutorNR.Text = null;
            NomTutor2NR.Text = null;
            ApeTutorNR.Text = null;
            ApeTutor2NR.Text = null;
            TelTutorNR.Text = null;

            NomRefNR.Text = null;
            NomRef2NR.Text = null;
            ApeRefNR.Text = null;
            ApeRef2NR.Text = null;
            TelRefNR.Text = null;


        }

        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(NomTutorNR.Text) || string.IsNullOrEmpty(ApeTutorNR.Text) ||  string.IsNullOrEmpty(NomRefNR.Text) || string.IsNullOrEmpty(ApeRefNR.Text))
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
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
        public void Cancelar(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider.Clear();

        }

        #endregion

        private void NomTutorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomTutorNR);
        }

        private void NomTutor2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomTutor2NR);
        }

        private void ApeTutorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeTutorNR);
        }

        private void ApeTutor2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeTutor2NR);
        }

        private void NomRefNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomRefNR);
        }

        private void NomRef2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomRef2NR);
        }

        private void ApeRefNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeRefNR);
        }

        private void ApeRef2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeRef2NR);
        }

        private void NomTutorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomTutorNR.Text))
            {
              
              
                errorProvider.SetError(NomTutorNR, "Campo Obligatorio");

            }
            else
            {
       
                errorProvider.SetError(NomTutorNR, null);
            }
        }

        private void ApeTutorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ApeTutorNR.Text))
            {
         
                
                errorProvider.SetError(ApeTutorNR, "Campo Obligatorio");

            }
            else
            {
      
                errorProvider.SetError(ApeTutorNR, null);
            }
        }

        private void TelTutorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TelTutorNR.Text))
            {
       
                errorProvider.SetError(TelTutorNR, "Campo Obligatorio");

            }
            else
            {
    
                errorProvider.SetError(TelTutorNR, null);
            }
        }

        private void NomRefNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomRefNR.Text))
           {        
        
        
                errorProvider.SetError(NomRefNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(NomRefNR, null);
            }
        }

        private void ApeRefNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ApeRefNR.Text))
            { 
                
                errorProvider.SetError(ApeRefNR, "Campo Obligatorio");

            }
            else
            {
              
                errorProvider.SetError(ApeRefNR, null);
            }
        }

        private void TelRefNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TelRefNR.Text))
            {
                
                
                errorProvider.SetError(TelRefNR, "Campo Obligatorio");

            }
            else
            {
                
                errorProvider.SetError(TelRefNR, null);
            }
        }

        private void BtnGuardarTutorNR_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (Comprobar() == false)
                {
                    MessageBox.Show("Datos Incompletos");
                }
                if (Comprobar() == true)
                {
                    ListaTutor.Clear();

                    ListaTutor.Add(NomTutorNR.Text);
                    ListaTutor.Add(NomTutor2NR.Text);
                    ListaTutor.Add(ApeTutorNR.Text);
                    ListaTutor.Add(ApeTutor2NR.Text);
                    ListaTutor.Add(TelTutorNR.Text);
                    ListaTutor.Add(NomRefNR.Text);
                    ListaTutor.Add(NomRef2NR.Text);
                    ListaTutor.Add(ApeRefNR.Text);
                    ListaTutor.Add(ApeRef2NR.Text);
                    ListaTutor.Add(TelRefNR.Text);
                    GuardarTutor.Invoke(ListaTutor);

               
                    
                }                
            }
        }

     
        private void PanelTutorNR_Click(object sender, EventArgs e)
        {

            panelTutorNR.Focus();
        }
    }
}
