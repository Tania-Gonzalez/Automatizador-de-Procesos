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
    public partial class EditRenta : Form
    {
        #region Variables
        private int ID_direccion, ID_Exp, ID_Doc;
            private int? ID_Renta;
        private string CadenaConexion;
        List<string> ListaDireccionRenta = new List<string>();
        #endregion
        public EditRenta(int a, string b, int c)
        {
            InitializeComponent();
            ID_direccion = a;
            CadenaConexion = b;
            ID_Exp = c;
            Cargar();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar la hoja de renta? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Direccion.SingleOrDefault(n => n.ID_Direccion== ID_direccion);
                    if (a != null)
                    {
                        a.ID_Direccion_Renta = null;
                        context.SaveChanges();
                    }
                }

                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.DireccionRenta.Where(n => n.ID_Renta == this.ID_Renta).FirstOrDefault();
                    context.DireccionRenta.Remove(a);
                    context.SaveChanges();
                }




                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Expediente.SingleOrDefault(n => n.ID_Expediente == ID_Exp);
                    if (a != null)
                    {
                        ID_Doc = a.ID_Documentacion;
                    }
                }
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Documentos.SingleOrDefault(n => n.ID_Documentos == ID_Doc);
                    if (a != null)
                    {
                        a.Hoja_Renta = false;
                        context.SaveChanges();
                    }
                }
                Cargar();
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            PanelHojaRenta.Enabled = true;



        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

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

        private void DirecccionRentaNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DirecccionRentaNR.Text))
            {


                errorProvider2.SetError(DirecccionRentaNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(DirecccionRentaNR, null);
            }
        }



        private void NoExteriorRenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NoExteriorRenta.Text))
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
            if (string.IsNullOrEmpty(ColoniaRenta.Text))
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
            if (string.IsNullOrEmpty(MunicipioRenta.Text))
            {


                errorProvider2.SetError(MunicipioRenta, "Campo Obligatorio");

            }
            else
            {

                errorProvider2.SetError(MunicipioRenta, null);
            }
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnGuardarDireccionNR_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Comprobar2() == false)
                {
                    MessageBox.Show("Faltan datos por llenar de la hoja de renta");
                }
                else
                {
                    if (checkhojarenta.Checked==false)
                    {
                        ListaDireccionRenta.Clear();
                        ListaDireccionRenta.Add(DirecccionRentaNR.Text.Trim());
                        ListaDireccionRenta.Add(NoExteriorRenta.Text.Trim());
                        ListaDireccionRenta.Add(ColoniaRenta.Text.Trim());
                        ListaDireccionRenta.Add(MunicipioRenta.Text.Trim());
                        int idr;
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = new DireccionRenta()
                            {
                                Calle = ListaDireccionRenta[0],
                                Numero_Interior = ListaDireccionRenta[1],
                                Colonia = ListaDireccionRenta[2],
                                Municipio = ListaDireccionRenta[3]
                            };
                            context.DireccionRenta.Add(a);
                            context.SaveChanges();
                            idr = a.ID_Renta;
                        }
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = context.Direccion.SingleOrDefault(n => n.ID_Direccion == ID_direccion);
                            if (a != null)
                            {
                                a.ID_Direccion_Renta = idr;
                                context.SaveChanges();
                            }
                        }
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = context.Expediente.SingleOrDefault(n => n.ID_Expediente== ID_Exp);
                            if (a != null)
                            {
                                ID_Doc = a.ID_Documentacion;
                            }
                        }
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = context.Documentos.SingleOrDefault(n => n.ID_Documentos == ID_Doc);
                            if (a != null)
                            {
                                a.Hoja_Renta = true;
                                context.SaveChanges();
                            }
                        }

                    }
                    else
                    {
                        ListaDireccionRenta.Clear();
                        ListaDireccionRenta.Add(DirecccionRentaNR.Text.Trim());
                        ListaDireccionRenta.Add(NoExteriorRenta.Text.Trim());
                        ListaDireccionRenta.Add(ColoniaRenta.Text.Trim());
                        ListaDireccionRenta.Add(MunicipioRenta.Text.Trim());
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = context.DireccionRenta.SingleOrDefault(n => n.ID_Renta == this.ID_Renta);
                            if (a != null)
                            {
                                a.Calle = ListaDireccionRenta[0];
                                a.Numero_Interior = ListaDireccionRenta[1];
                                a.Colonia = ListaDireccionRenta[2];
                                a.Municipio = ListaDireccionRenta[3];
                                context.SaveChanges();
                            }
                        }
                    }
                    Cargar();
                }
            }
        }

        private void Cargar()
        {
            PanelHojaRenta.Enabled = false;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datosdireccion = context.Direccion.ToList();
                foreach (var valores in datosdireccion.Where(n => n.ID_Direccion == ID_direccion))
                {
                    ID_Renta = valores.ID_Direccion_Renta;
                }
                if (ID_Renta!=null)
                {
                   
                    btnEliminar.Enabled = true;                
                    checkhojarenta.Checked = true;

                    var datosrenta = context.DireccionRenta.ToList();
                    foreach (var valores in datosrenta.Where(n => n.ID_Renta == this.ID_Renta))
                    {
                        DirecccionRentaNR.Text = valores.Calle;
                        NoExteriorRenta.Text = valores.Numero_Interior;
                        ColoniaRenta.Text = valores.Colonia;
                        MunicipioRenta.Text = valores.Municipio;
                    }

                }
                else
                {
                  
                    btnEliminar.Enabled = false;
                  
                    checkhojarenta.Checked = false;

                    DirecccionRentaNR.Text = null;
                    NoExteriorRenta.Text = null;
                    ColoniaRenta.Text = null;
                    MunicipioRenta.Text = null;
                }


            }

        }
    }
}
