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
    public partial class EditArea : Form
    {
        #region Variables
        private string CadenaConexion;
        private int? ID_Departamento, ID_Puerta;
        private int ID_Area;
        #endregion

        public EditArea(int a, string b)
        {
            InitializeComponent();
            ID_Area = a;
            CadenaConexion = b;
            Cargar();
            LlenarArea();
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Area.ToList();
                foreach (var valores in item.Where(n => n.ID_Area == ID_Area))
                {
                    ID_Puerta = valores.ID_Puerta;
                    ID_Departamento = valores.ID_Departamento;
                }               

            }

        }

        public bool Comprobar()
        {
            if (ListaArea.SelectedIndex < 1 || ListaPuerta.SelectedIndex < 1)
            {
                return false;

            }
            else
            {
                return true;
            }

        }


        public void LlenarArea()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Departamento.ToList();
                diccionario.Add("0", "Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Departamento1 + " - " + valores.Direccion;
                    var id = valores.ID_Departamento;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaArea.DataSource = new BindingSource(diccionario, null);
                ListaArea.DisplayMember = "Value";
                ListaArea.ValueMember = "Key";
                ListaArea.SelectedValue = ID_Departamento.ToString();


                ////
                ///

                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();

                var item2 = context.Puerta.ToList();
                diccionario2.Add("0", "Seleccione");

                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre;
                    var id = valores.ID_Puerta;
                    diccionario2.Add(id.ToString(), nombre);


                }
                ListaPuerta.DataSource = new BindingSource(diccionario2, null);
                ListaPuerta.DisplayMember = "Value";
                ListaPuerta.ValueMember = "Key";
                ListaPuerta.SelectedValue = ID_Puerta.ToString();

            }
        }



        private void ListaArea_Click(object sender, EventArgs e)
        {
            int a = ListaArea.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Departamento.ToList();
                diccionario.Add("0", "Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Departamento1 + " - " + valores.Direccion;
                    var id = valores.ID_Departamento;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaArea.DataSource = new BindingSource(diccionario, null);
                ListaArea.DisplayMember = "Value";
                ListaArea.ValueMember = "Key";
            }
            ListaArea.SelectedIndex = a;
        }



        private void ListaPuerta_Click(object sender, EventArgs e)
        {
            int a = ListaPuerta.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();

                var item2 = context.Puerta.ToList();
                diccionario2.Add("0", "Seleccione");

                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre;
                    var id = valores.ID_Puerta;
                    diccionario2.Add(id.ToString(), nombre);


                }
                ListaPuerta.DataSource = new BindingSource(diccionario2, null);
                ListaPuerta.DisplayMember = "Value";
                ListaPuerta.ValueMember = "Key";
                ListaPuerta.SelectedIndex = 0;
            }
            ListaPuerta.SelectedIndex = a;

        }

        private void AgregarArea_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea ingresar una nueva área?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertArea())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }


        }

        private void AgregarPuerta_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea ingresar una nueva puerta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertPuerta())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }
        }

        private void ModificarArea_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar el área seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new ModificarArea(CadenaConexion, ID_Departamento.GetValueOrDefault()))
                {

                    a.ShowDialog();

                }
            }
        }

        private void ModificarPuerta_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea modificar la opcion seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new ModificarPuerta(ID_Puerta.GetValueOrDefault(), CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }
        private void ListaArea_Validating(object sender, CancelEventArgs e)
        {
            if (ListaArea.SelectedIndex == 0)
            {


                errorProvider.SetError(ListaArea, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaArea, null);
            }
        }

        private void ListaPuerta_Validating(object sender, CancelEventArgs e)
        {
            if (ListaPuerta.SelectedIndex == 0)
            {


                errorProvider.SetError(ListaPuerta, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaPuerta, null);
            }
        }

        private void BtnGuardarAreaNR_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Comprobar() == false)
                {
                    MessageBox.Show("Datos Incompletos");
                }
                else
                {
                   

                }

            }
        }

        private void ListaArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaArea.SelectedIndex > 0)
            {
                ModificarArea.Enabled = true;
                var a = ((KeyValuePair<string, string>)ListaArea.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_Departamento = id;
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var item = context.Departamento.ToList();

                    foreach (var valores in item.Where(n => n.ID_Departamento == id))
                    {
                        DepartamentoNR.Text = valores.Departamento1;
                        ClaveDepNR.Text = valores.Clave_Departamento;
                        SubdireccionNR.Text = valores.Subdireccion;
                        ClaveSubNR.Text = valores.Clave_Subdireccion;
                        GerenciaNR.Text = valores.Gerencia_Unidad;
                        ClaveGerenciaNR.Text = valores.Clave_Gerencia;
                        UbicacionNR.Text = valores.Direccion;
                    };
                }
            }
            else
            {
                ModificarArea.Enabled = false;
                DepartamentoNR.Text = null;
                ClaveDepNR.Text = null;
                SubdireccionNR.Text = null;
                ClaveSubNR.Text = null;
                GerenciaNR.Text = null;
                ClaveGerenciaNR.Text = null;
                UbicacionNR.Text = null;
            }
        }

        private void PanelAreaNR_Click(object sender, EventArgs e)
        {
            panelAreaNR.Focus();
        }

        private void BtnGuardarAreaNR_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Comprobar() == false)
                {
                    MessageBox.Show("Datos Incompletos");
                }
                else
                {
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Area.SingleOrDefault(n => n.ID_Area == ID_Area);
                        if (a != null)
                        {
                            a.ID_Departamento = this.ID_Departamento;
                            a.ID_Puerta= this.ID_Puerta;
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Datos Actualizados");

                }

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaPuerta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaPuerta.SelectedIndex > 0)
            {
                ModificarPuerta.Enabled = true;
                var a = ((KeyValuePair<string, string>)ListaPuerta.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_Puerta = id;

            }
            else
            {
                ModificarPuerta.Enabled = false;
            }
        }


    }
}
