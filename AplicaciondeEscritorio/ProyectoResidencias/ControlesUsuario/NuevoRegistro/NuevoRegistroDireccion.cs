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
    public partial class NuevoRegistroDireccion : UserControl
    {
        #region Delegados

        public delegate void GDireccion(List<string> a, List<string> b, bool c);
        public event GDireccion GuardarDireccion;

        #endregion

        #region Variables

        private bool hojarenta = false;
        List<string> ListaDireccion = new List<string>();
        List<string> ListaDireccionRenta = new List<string>();

        #endregion

        #region Constructor
        public NuevoRegistroDireccion()
        {
            InitializeComponent();
        }
        #endregion

        #region MetodosApoyo                        
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

        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(CalleNR.Text) || string.IsNullOrEmpty(NoExteriorNR.Text) || string.IsNullOrEmpty(ColoniaNR.Text) || string.IsNullOrEmpty(MunicipioNR.Text)|| string.IsNullOrEmpty(EstadoNR.Text)|| string.IsNullOrEmpty(PaisNR.Text)||string.IsNullOrEmpty(CodigoPostalNR.Text))
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
        }
        public bool Comprobar2()
        {
            bool r;

             if (string.IsNullOrEmpty(DirecccionRentaNR.Text) || string.IsNullOrEmpty(NoExteriorRenta.Text) || string.IsNullOrEmpty(ColoniaRenta.Text) || string.IsNullOrEmpty(MunicipioRenta.Text))

                {

                    r = false;

                }
                else
                {
                    r = true;
                }   
          
            
            return r;
        }


        public void Limpiar()
        {
           
            
            ListaDireccion.Clear();
            ListaDireccionRenta.Clear();
            ListaEstados.SelectedIndex = -1;
            HojaRentaCheck.Checked = false;
            CalleNR.Text = null;
            NoExteriorNR.Text = null;
            NoInteriorNR.Text = null;
            ColoniaNR.Text = null;
            MunicipioNR.Text = null;
            EstadoNR.Text = null;
            PaisNR.Text = null;
            CodigoPostalNR.Text = null;
            DirecccionRentaNR.Text = null;
            NoExteriorRenta.Text = null;
            ColoniaRenta.Text = null;
            MunicipioRenta.Text= null;



        }

        private void ListaEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEstados.SelectedIndex == -1)
            {
                PaisNR.Text = "";
            }
            else
            { 
                EstadoNR.Text = ListaEstados.SelectedItem.ToString();
                PaisNR.Text = "México";
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HojaRentaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HojaRentaCheck.Checked==true)
            {
                PanelHojaRenta.Visible = true;
                hojarenta = true;
                DirecccionRentaNR.Text = null;
                NoExteriorRenta.Text = null;
                ColoniaRenta.Text = null;
                MunicipioRenta.Text = null;
            }
            else
            {
                PanelHojaRenta.Visible = false;
                hojarenta = false;
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

        #endregion

        private void CalleNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(CalleNR);
        }

        private void NoExteriorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NoExteriorNR);
        }

        private void NoInteriorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NoInteriorNR);
        }

        private void ColoniaNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ColoniaNR);
        }

        private void MunicipioNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(MunicipioNR);
        }

        private void DirecccionRentaNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(DirecccionRentaNR);
        }

        private void NoExteriorRenta_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NoExteriorRenta);
        }

        private void ColoniaRenta_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ColoniaRenta);
        }

        private void MunicipioRenta_Leave(object sender, EventArgs e)
        {
            CapitalLetter(MunicipioRenta);
        }

        private void CalleNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CalleNR.Text))
            {
               

                errorProvider.SetError(CalleNR, "Campo Obligatorio");

            }
            else
            {
              
                errorProvider.SetError(CalleNR, null);
            }
        }

        private void NoExteriorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NoExteriorNR.Text))
            {
              

                errorProvider.SetError(NoExteriorNR, "Campo Obligatorio");

            }
            else
            {
       
                errorProvider.SetError(NoExteriorNR, null);
            }
        }

        private void ColoniaNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ColoniaNR.Text))
            {
          
     
                errorProvider.SetError(ColoniaNR, "Campo Obligatorio");

            }
            else
            {
                     errorProvider.SetError(ColoniaNR, null);
            }
        }

        private void MunicipioNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MunicipioNR.Text))
            {
            

                errorProvider.SetError(MunicipioNR, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(MunicipioNR, null);
            }
        }

        private void EstadoNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EstadoNR.Text))
            {
          

                errorProvider.SetError(EstadoNR, "Campo Obligatorio");

            }
            else
            {
           
                errorProvider.SetError(EstadoNR, null);
            }
        }

        private void PaisNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PaisNR.Text))
            {
            

                errorProvider.SetError(PaisNR, "Campo Obligatorio");

            }
            else
            {
               
                errorProvider.SetError(PaisNR, null);
            }
        }

        private void CodigoPostalNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoPostalNR.Text))
            {
                
  
                errorProvider.SetError(CodigoPostalNR, "Campo Obligatorio");

            }
            else
            {
                
                errorProvider.SetError(CodigoPostalNR, null);
            }
        }

        private void BtnGuardarDireccionNR_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (Comprobar() == false)
                {
                    MessageBox.Show("Faltan Campos Por Llenar");
                }
                else
                {

                    if (hojarenta == true)
                    {
                        if (Comprobar2() == false)
                        {
                            MessageBox.Show("Faltan datos por llenar de la hoja de renta");

                        }
                        else
                        {
                            ListaDireccion.Clear();
                            ListaDireccionRenta.Clear();

                            ListaDireccion.Add(CalleNR.Text);
                            ListaDireccion.Add(NoInteriorNR.Text);
                            ListaDireccion.Add(NoExteriorNR.Text);
                            ListaDireccion.Add(ColoniaNR.Text);
                            ListaDireccion.Add(MunicipioNR.Text);
                            ListaDireccion.Add(EstadoNR.Text);
                            ListaDireccion.Add(PaisNR.Text);
                            ListaDireccion.Add(CodigoPostalNR.Text);

                            ListaDireccionRenta.Add(DirecccionRentaNR.Text);
                            ListaDireccionRenta.Add(NoExteriorRenta.Text);
                            ListaDireccionRenta.Add(ColoniaRenta.Text);
                            ListaDireccionRenta.Add(MunicipioRenta.Text);

                            GuardarDireccion.Invoke(ListaDireccion, ListaDireccionRenta, true);
                          
                           
                        }

                    }
                    if (hojarenta == false)
                    {
                        ListaDireccion.Clear();

                        ListaDireccion.Add(CalleNR.Text);
                        ListaDireccion.Add(NoInteriorNR.Text);
                        ListaDireccion.Add(NoExteriorNR.Text);
                        ListaDireccion.Add(ColoniaNR.Text);
                        ListaDireccion.Add(MunicipioNR.Text);
                        ListaDireccion.Add(EstadoNR.Text);
                        ListaDireccion.Add(PaisNR.Text);
                        ListaDireccion.Add(CodigoPostalNR.Text);
                        GuardarDireccion.Invoke(ListaDireccion,ListaDireccionRenta,false);
                        
                        


                    }

                }
                
            }
        }
        public void Cancelar(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider.Clear();
            errorProvider2.Clear();

        }

        private void PanelDireccionNR2_Click(object sender, EventArgs e)
        {
            panelDireccionNR2.Focus();
        }

        private void ListaEstados_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EstadoNR.Text))
            {


                errorProvider.SetError(EstadoNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(EstadoNR, null);
            }
            if (string.IsNullOrEmpty(PaisNR.Text))
            {


                errorProvider.SetError(PaisNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(PaisNR, null);
            }
        }

        private void NoExteriorRenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NoExteriorRenta.Text) && hojarenta == true)
            {


                errorProvider2.SetError(NoExteriorRenta, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(NoExteriorRenta, null);
            }
        }

        private void ColoniaRenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ColoniaRenta.Text) && hojarenta == true)
            {


                errorProvider2.SetError(ColoniaRenta, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(ColoniaRenta, null);
            }
        }

        private void MunicipioRenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MunicipioRenta.Text) && hojarenta == true)
            {


                errorProvider2.SetError(MunicipioRenta, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(MunicipioRenta, null);
            }
        }

        private void DirecccionRentaNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DirecccionRentaNR.Text)&&hojarenta==true)
            {


                errorProvider2.SetError(DirecccionRentaNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(DirecccionRentaNR, null);
            }
        }
    }
}
