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
    public partial class ModificarAsesor : Form
    {
        #region Variables
        private int ID;
        private string Nombre1, Nombre2, Apellido1, Apellido2, Ficha, Cargo, Extension;
        private string CadenaConexion;
        #endregion
        #region Constructores
        public ModificarAsesor(string a,int b)

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
                var item = context.Asesor_Tecnico.ToList();

                foreach (var valores in item.Where(n => n.ID_Asesor == ID))
                {
                    NomAsesorNR.Text = valores.Nombre1_Asesor;
                    NomAsesor2NR.Text = valores.Nombre2_Asesor;
                    ApeAsesorNR.Text = valores.Apellido_Paterno;
                    ApeAsesor2NR.Text = valores.Apellido_Materno;
                    CargoAsesorNR.Text = valores.Cargo;
                    FichaAsesorNR.Text = valores.Ficha;
                    ExtensionNR.Text = valores.Extension;

                }
            }
           
        }
        #endregion

        #region MetodosApoyo

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))

            {
                e.Handled = true;
            }
        }

        private void NomAsesorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomAsesorNR);

        }

        private void NomAsesor2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomAsesor2NR);
        }

        private void ApeAsesorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeAsesorNR);
        }

        private void ApeAsesor2NR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeAsesor2NR);
        }

        private void CargoAsesorNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(CargoAsesorNR);
        }

        private void NomAsesorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomAsesorNR.Text))
            {


                errorProvider.SetError(NomAsesorNR, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(NomAsesorNR, null);
            }
        }

        private void ApeAsesorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ApeAsesorNR.Text))
            {
                errorProvider.SetError(ApeAsesorNR, "Campo Obligatorio");
            }
            else
            {
                errorProvider.SetError(ApeAsesorNR, null);
            }
        }

        private void CargoAsesorNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CargoAsesorNR.Text))
            {
                errorProvider.SetError(CargoAsesorNR, "Campo Obligatorio");
            }
            else
            {
                errorProvider.SetError(CargoAsesorNR, null);
            }
        }

        private void ExtensionNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ExtensionNR.Text))
            {
                errorProvider.SetError(ExtensionNR, "Campo Obligatorio");
            }
            else
            {
                errorProvider.SetError(ExtensionNR, null);
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {

        }

        public void Cadena(string c)
        {
            CadenaConexion = c;
        }



        private void Validar()
        {
            if (NomAsesorNR.Text == "" || ApeAsesorNR.Text == "" || CargoAsesorNR.Text == "" || ExtensionNR.Text == "")
            {
                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nombre1 = NomAsesorNR.Text;
                Nombre2 = NomAsesor2NR.Text;
                Apellido1 = ApeAsesorNR.Text;
                Apellido2 = ApeAsesor2NR.Text;
                Cargo = CargoAsesorNR.Text;
                Ficha = FichaAsesorNR.Text;
                Extension = ExtensionNR.Text;


                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = context.Asesor_Tecnico.SingleOrDefault(n => n.ID_Asesor == ID);
                    if (a!= null)
                    {
                        a.Nombre1_Asesor = Nombre1;
                        a.Nombre2_Asesor = Nombre2;
                        a.Apellido_Paterno = Apellido1;
                        a.Apellido_Materno = Apellido2;
                        a.Cargo = Cargo;
                        a.Ficha = Ficha;
                        a.Extension = Extension;
                        context.SaveChanges();
                    }
                    
                   
                    MessageBox.Show("Modificacion Correcta");
                    this.Dispose();
                    
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



        #endregion


        #region Botones

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Validar();

            }
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion
    }
}
