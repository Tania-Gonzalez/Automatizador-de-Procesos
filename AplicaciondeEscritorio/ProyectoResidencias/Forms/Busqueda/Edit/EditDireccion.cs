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
    public partial class EditDireccion : Form
    {
        #region Variables
        private int ID_dir;
        private string CadenaConexion;
        #endregion

        public EditDireccion(int a, string b)
        {
            InitializeComponent();
            ID_dir = a;
            CadenaConexion = b;
            Cargar();

           
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Direccion.ToList();
                foreach (var valores in item.Where(n => n.ID_Direccion== ID_dir))
                {
                    CalleNR.Text = valores.Calle;
                    NoExteriorNR.Text = valores.Numero_Exterior;
                    NoInteriorNR.Text = valores.Numero_Interior;
                    ColoniaNR.Text = valores.Colonia;
                    MunicipioNR.Text = valores.Municipio;
                    EstadoNR.Text = valores.Estado;
                    PaisNR.Text = valores.Pais;
                    CodigoPostalNR.Text = valores.Codigo_Postal;
                }



            }
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
        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(CalleNR.Text) || string.IsNullOrEmpty(NoExteriorNR.Text) || string.IsNullOrEmpty(ColoniaNR.Text) || string.IsNullOrEmpty(MunicipioNR.Text) || string.IsNullOrEmpty(EstadoNR.Text) || string.IsNullOrEmpty(PaisNR.Text) || string.IsNullOrEmpty(CodigoPostalNR.Text))
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
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

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != ' '))

            {
                e.Handled = true;
            }
        }

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
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Direccion.SingleOrDefault(n => n.ID_Direccion== ID_dir);
                        if (a != null)
                        {
                            a.Calle = CalleNR.Text.Trim();
                            a.Numero_Interior = NoInteriorNR.Text.Trim();
                            a.Numero_Exterior = NoExteriorNR.Text.Trim();
                            a.Colonia = ColoniaNR.Text.Trim();
                            a.Municipio = MunicipioNR.Text.Trim();
                            a.Estado = EstadoNR.Text.Trim();
                            a.Pais = PaisNR.Text.Trim();
                            a.Codigo_Postal = CodigoPostalNR.Text.Trim();

                            context.SaveChanges();
                        }


                        MessageBox.Show("Modificacion Correcta");
                       

                    }
                    }
                }
            }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
