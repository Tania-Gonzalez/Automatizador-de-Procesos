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
    public partial class ModificarEncargado : Form
    {
        #region Variables
        private int ID;
        private string CadenaConexion;
        private string nombre1, nombre2, apep, apem, cargo, telefono, correo;
        #endregion

        #region Constructor
        public ModificarEncargado(string a, int b)
        {
            InitializeComponent();
            CadenaConexion = a;
            ID = b;
            Cargar();
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Encargado_Escuela.ToList();

                foreach (var valores in item.Where(n => n.ID_Encargado == ID))
                {
                    NomEncargadoNR.Text = valores.Nombre1_Encargado;
                    NomEncargado2NR.Text = valores.Nombre2_Encargado;
                    ApeEncargadoNR.Text = valores.Apellido_Paterno;
                    ApeEncargado2NR.Text = valores.Apellido_Materno;
                    CargoEncargadoNR.Text = valores.Cargo;
                    TelEncargadoNR.Text = valores.Telefono;
                    CorreoEncargadoNR.Text = valores.Telefono;

                }
            }
         }
        #endregion

        #region MetodosApoyo
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NomEncargadoNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomEncargadoNR);
        }

        private void NomEncargado2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomEncargado2NR);
        }

        private void ApeEncargadoNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeEncargadoNR);
        }

        private void ApeEncargado2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeEncargado2NR);
        }

        private void CargoEncargadoNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(CargoEncargadoNR);
        }

        private void NomEncargadoNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomEncargadoNR.Text))
            {


                errorProvider.SetError(NomEncargadoNR, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(NomEncargadoNR, null);
            }
        }

        private void ApeEncargadoNR_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(ApeEncargadoNR.Text))
            {


                errorProvider.SetError(ApeEncargadoNR, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(ApeEncargadoNR, null);
            }
        }

        private void CargoEncargadoNR_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(CargoEncargadoNR.Text))
            {


                errorProvider.SetError(CargoEncargadoNR, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(CargoEncargadoNR, null);
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

        public void Cadena(string c)
        {
            CadenaConexion = c;
        }
        private void Validar()
        {
            if (NomEncargadoNR.Text == "" || ApeEncargadoNR.Text == "" || CargoEncargadoNR.Text == "")
            {

                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nombre1 = NomEncargadoNR.Text; nombre2 = NomEncargado2NR.Text; apep = ApeEncargadoNR.Text;
                apem = ApeEncargado2NR.Text; cargo = CargoEncargadoNR.Text; telefono = TelEncargadoNR.Text;
                correo = CorreoEncargadoNR.Text;
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = context.Encargado_Escuela.SingleOrDefault(n => n.ID_Encargado == ID);
                    if (a != null)
                    {
                        a.Nombre1_Encargado = nombre1;
                        a.Nombre2_Encargado = nombre2;
                        a.Apellido_Paterno = apep;
                        a.Apellido_Materno = apem;
                        a.Cargo = cargo;
                        a.Telefono = telefono;
                        a.Correo = correo;
                        context.SaveChanges();


                    }
                 
                    MessageBox.Show("Modificacion Correcta");
                    this.Dispose();
                }




            }
        }
        #endregion

        #region Botones
        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Validar();

            }
        }
        #endregion
    }
}
