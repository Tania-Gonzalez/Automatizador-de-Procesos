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
    public partial class InsertCarrera : Form
    {
        #region Variables
        private int ID;
        private string CadenaConexion;
        private string nombrecarrera, nivel;
        #endregion

        #region Constructores
        public InsertCarrera()
        {
            InitializeComponent();
            ListaNivel.SelectedIndex = 0;
        }
        #endregion
         

        #region MetodosApoyo
        public void Cadena(string c)
        {
            CadenaConexion = c;
        }
        public void Sololetras(object sender,KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != ' ')&& (e.KeyChar != '.'))

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


        private void ListaNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            NivelCampo.Text = ListaNivel.SelectedItem.ToString();
        }

        private void Validar()
        {
            if (NivelCampo.Text == "" || NombreCarrera.Text == "")
            {

                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               nivel=NivelCampo.Text; nombrecarrera = NombreCarrera.Text;

                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = new Carrera()
                    {
                        Nombre_Carrera = nombrecarrera, Escolaridad = nivel
                    };
                    context.Carrera.Add(a);
                    context.SaveChanges();
                    ID = a.ID_Carrera;
                    MessageBox.Show("Insercion Correcta");
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

        private void NombreCarrera_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NombreCarrera);
        }

        private void NombreCarrera_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NombreCarrera.Text))
            {


                errorProvider.SetError(NombreCarrera, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(NombreCarrera, null);
            }
        }

        private void ListaNivel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NivelCampo.Text))
            {


                errorProvider.SetError(NivelCampo, "Campo Obligatorio");

            }
            else
            {
                errorProvider.SetError(NivelCampo, null);
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
