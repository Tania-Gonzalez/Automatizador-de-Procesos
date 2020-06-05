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
    public partial class ModificarJefe : Form
    { 
        #region Variables
        private int ID;
        private string Nombre1, Nombre2, Apellido1, Apellido2, Ficha;
        private string CadenaConexion;
        #endregion

        #region Constructores
        public ModificarJefe(string a,int b)
    
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
                var item = context.Jefe_Area.ToList();

                foreach (var valores in item.Where(n => n.ID_Jefe_Area == ID))
                {
                    NomJefe1.Text = valores.Nombre1_Jefe;
                    NomJefe2.Text = valores.Nombre2_Jefe;
                    ApeJefe1.Text = valores.Apellido_Paterno_Jefe;
                    ApeJefe2.Text = valores.Apellido_Materno_Jefe;
                    FichaJefe.Text = valores.Ficha;
                    

                }
            }
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

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))

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

        private void NomJefe1_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomJefe1);
        }

        private void NomJefe2_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NomJefe2);
        }

        private void ApeJefe1_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeJefe1);
        }

        private void ApeJefe2_Leave(object sender, EventArgs e)
        {
            CapitalLetter(ApeJefe2);
        }

        private void NomJefe1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomJefe1.Text))
            {


                errorProvider.SetError(NomJefe1, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(NomJefe1, null);
            }
        }

        private void ApeJefe1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ApeJefe1.Text))
            {


                errorProvider.SetError(ApeJefe1, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(ApeJefe1, null);
            }
        }

        private void ModificarJefe_Load(object sender, EventArgs e)
        {

        }

        public void Cadena(string c)
        {
            CadenaConexion = c;
        }


        private void Validar()
        {
            if (NomJefe1.Text == "" || ApeJefe1.Text == "")
            {
                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nombre1 = NomJefe1.Text;
                Nombre2 = NomJefe2.Text;
                Apellido1 = ApeJefe1.Text;
                Apellido2 = ApeJefe2.Text;
                Ficha = FichaJefe.Text;


                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = context.Jefe_Area.SingleOrDefault(n => n.ID_Jefe_Area== ID);
                    if (a != null)
                    {
                        a.Nombre1_Jefe= Nombre1;
                        a.Nombre2_Jefe = Nombre2;
                        a.Apellido_Paterno_Jefe= Apellido1;
                        a.Apellido_Materno_Jefe= Apellido2;
                        a.Ficha = Ficha;
                        
                        context.SaveChanges();
                    }


                    MessageBox.Show("Modificacion Correcta");
                    this.Dispose();
                }

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
