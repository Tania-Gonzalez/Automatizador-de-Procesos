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
    public partial class EditTutor : Form
    {
        #region Variables
        private int ID_dp;
        private int? ID_t;
        private string CadenaConexion;

        #endregion
        public EditTutor(int a,string b)
        {

            InitializeComponent();
            ID_dp = a;
            CadenaConexion = b;
            Cargar();
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Datos_Personales.ToList();
                foreach (var valores in item.Where(n => n.ID_Datos_Personales == ID_dp))
                {
                    ID_t = valores.ID_Referencia;

                }
                if (ID_t != null)
                {
                    var datostutor = context.Tutor.ToList();
                    foreach (var valores in datostutor.Where(n => n.ID_Ref == ID_t))
                    {
                        NomTutorNR.Text = valores.Nombre1_Tutor;
                        NomTutor2NR.Text = valores.Nombre2_Tutor;
                        ApeTutorNR.Text = valores.Ap_P_T;
                        ApeTutor2NR.Text = valores.AP_M_T;
                        TelTutorNR.Text = valores.TelefonoT;
                        NomRefNR.Text = valores.Nombre1_Ref;
                        NomRef2NR.Text = valores.Nombre2_Ref;
                        ApeRefNR.Text = valores.AP_P_R;
                        ApeRef2NR.Text = valores.AP_M_R;
                        TelRefNR.Text = valores.TelefonoR;
                    }

                }
            }

        }

        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(NomTutorNR.Text) || string.IsNullOrEmpty(ApeTutorNR.Text) || string.IsNullOrEmpty(NomRefNR.Text) || string.IsNullOrEmpty(ApeRefNR.Text))
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

                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Tutor.SingleOrDefault(n => n.ID_Ref== ID_t);
                        if (a != null)
                        {
                            a.Nombre1_Tutor = NomTutorNR.Text.Trim();
                            a.Nombre2_Tutor = NomTutor2NR.Text.Trim();
                            a.Ap_P_T = ApeTutorNR.Text.Trim();
                            a.AP_M_T = ApeTutor2NR.Text.Trim();
                            a.TelefonoT = TelTutorNR.Text.Trim(); 
                            a.Nombre1_Ref = NomRefNR.Text.Trim();
                            a.Nombre2_Ref = NomRef2NR.Text.Trim();
                            a.AP_P_R = ApeRefNR.Text.Trim(); 
                            a.AP_M_R = ApeRef2NR.Text.Trim();
                            a.TelefonoR = TelRefNR.Text.Trim();

                            context.SaveChanges();
                        }


                        MessageBox.Show("Modificacion Correcta");
                        
                    }

                }
            }
        }


        private void PanelTutorNR_Click(object sender, EventArgs e)
        {

            panelTutorNR.Focus();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
