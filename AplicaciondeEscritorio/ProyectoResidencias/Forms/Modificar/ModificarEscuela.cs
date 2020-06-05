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
    public partial class ModificarEscuela : Form
    {
        #region Variables
        private int ID;
        private string CadenaConexion;
        private string nombreescuela;
        #endregion

        #region Constructor
        public ModificarEscuela(string a, int b)
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
                var item = context.Escuela.ToList();

                foreach (var valores in item.Where(n => n.ID_Escuela== ID))
                {
                    NombreEsc.Text = valores.Nombre_Escuela;
                }
            }
        }
        #endregion


        #region MetodosApoyo
        private void NombreEsc_Leave(object sender, EventArgs e)
        {
            CapitalLetter(NombreEsc);
        }

        public void Cadena(string c)
        {
            CadenaConexion = c;
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

        private void Validar()
        {
            if (NombreEsc.Text == "")
            {

                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nombreescuela = NombreEsc.Text;

                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = context.Escuela.SingleOrDefault(n => n.ID_Escuela== ID);
                    if (a != null)
                    {
                        a.Nombre_Escuela = nombreescuela;
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
            this.Dispose();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Validar();
        }
        #endregion
    }
}
