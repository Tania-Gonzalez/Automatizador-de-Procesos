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
    public partial class ModificarArea : Form
    {
        

        #region Variables
        private int ID;
        private string CadenaConexion;
        private string departamento, clavedep, subdireccion, clavesubdireccion, gerencia, clavegerencia, direccion;

        private void DireccionNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(DireccionNR);
        }

        private void DepartamentoNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(DepartamentoNR);
        }

        private void SubdireccionNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(SubdireccionNR);
        }

        private void GerenciaNR_Leave(object sender, EventArgs e)
        {
            CapitalLetter(GerenciaNR);
        }

        private void DepartamentoNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DepartamentoNR.Text))
            {


                errorProvider.SetError(DepartamentoNR, "Seleccione una opcion");

            }
            else
            {
                errorProvider.SetError(DepartamentoNR, null);
            }
        }

        private void DireccionNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DireccionNR.Text))
            {


                errorProvider.SetError(DireccionNR, "Seleccione una opcion");

            }
            else
            {
                errorProvider.SetError(DireccionNR, null);
            }
        }


        #endregion

        #region Constructores
        public ModificarArea(string a, int b)
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
                var item = context.Departamento.ToList();

                foreach (var valores in item.Where(n => n.ID_Departamento== ID))
                {
                    DepartamentoNR.Text = valores.Departamento1;
                    ClaveDepNR.Text = valores.Clave_Departamento;
                    SubdireccionNR.Text = valores.Subdireccion;
                    ClaveSubNR.Text = valores.Clave_Subdireccion;
                    GerenciaNR.Text = valores.Gerencia_Unidad;
                    ClaveGerenciaNR.Text = valores.Clave_Gerencia;
                    DireccionNR.Text = valores.Direccion;

                }
            }
        }
        #endregion

        #region MetodosApoyo
        public void Cadena(string c)
        {
            CadenaConexion = c;
        }


        private void Validar()
        {
            if (DepartamentoNR.Text == "" || DireccionNR.Text == "")
            {

                MessageBox.Show("Falta llenar campos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                departamento = DepartamentoNR.Text;
                clavedep = ClaveDepNR.Text;
                subdireccion = SubdireccionNR.Text;
                clavesubdireccion = ClaveSubNR.Text;
                gerencia = GerenciaNR.Text;
                clavegerencia = ClaveGerenciaNR.Text;
                direccion = DireccionNR.Text;

                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var a = context.Departamento.SingleOrDefault(n => n.ID_Departamento == ID);
                    if (a != null)
                    {
                        a.Departamento1 = departamento;
                        a.Clave_Departamento = clavedep;
                        a.Subdireccion = subdireccion;
                        a.Clave_Subdireccion = clavesubdireccion;
                        a.Gerencia_Unidad = gerencia;
                        a.Clave_Gerencia = clavegerencia;
                        a.Direccion = direccion;
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
