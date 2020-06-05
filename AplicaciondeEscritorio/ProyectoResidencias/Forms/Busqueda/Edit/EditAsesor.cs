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
    public partial class EditAsesor : Form
    {
        #region Variables

        private string CadenaConexion;
        private int? ID_Asesor, ID_Jefe;
        private int ID_Area;

        #endregion

        public EditAsesor(int a,string b)
        {
            InitializeComponent();
            ID_Area = a;
            CadenaConexion = b;
            Cargar();
            LlenarAsesores();
          
        }
        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Area.ToList();
                foreach (var valores in item.Where(n => n.ID_Area== ID_Area))
                {
                    ID_Asesor = valores.ID_Asesor;
                    ID_Jefe = valores.ID_Jefe_Area;
                }

            }

        }

       
        public void LlenarAsesores()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Asesor_Tecnico.ToList();
                diccionario.Add("0", "Seleccione");
                

                foreach (var valores in item)
                {
                    var nombre = valores.Nombre1_Asesor + " " + valores.Nombre2_Asesor + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    var id = valores.ID_Asesor;
                    diccionario.Add(id.ToString(), nombre);
                }

                ListaAsesores.DataSource = new BindingSource(diccionario, null);
                ListaAsesores.DisplayMember = "Value";
                ListaAsesores.ValueMember = "Key";
                ListaAsesores.SelectedValue = ID_Asesor.ToString();


                ////
                ///
                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();

                var item2 = context.Jefe_Area.ToList();
                diccionario2.Add("0", "Seleccione");

                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre1_Jefe + " " + valores.Nombre2_Jefe + " " + valores.Apellido_Paterno_Jefe + " " + valores.Apellido_Materno_Jefe;
                    var id = valores.ID_Jefe_Area;
                    diccionario2.Add(id.ToString(), nombre);


                }
                ListaJefes.DataSource = new BindingSource(diccionario2, null);
                ListaJefes.DisplayMember = "Value";
                ListaJefes.ValueMember = "Key";
                ListaJefes.SelectedValue = ID_Jefe.ToString() ;

            }


        }

        private void ListaAsesores_Click(object sender, EventArgs e)
        {
            int a = ListaAsesores.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {

                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Asesor_Tecnico.ToList();
                diccionario.Add("0", "Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Nombre1_Asesor + " " + valores.Nombre2_Asesor + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    var id = valores.ID_Asesor;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaAsesores.DataSource = new BindingSource(diccionario, null);
                ListaAsesores.DisplayMember = "Value";
                ListaAsesores.ValueMember = "Key";

            }
            ListaAsesores.SelectedIndex = a;
        }

        private void ListaJefes_Click(object sender, EventArgs e)
        {
            int a = ListaJefes.SelectedIndex;

            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();

                var item2 = context.Jefe_Area.ToList();
                diccionario2.Add("0", "Seleccione");

                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre1_Jefe + " " + valores.Nombre2_Jefe + " " + valores.Apellido_Paterno_Jefe + " " + valores.Apellido_Materno_Jefe;
                    var id = valores.ID_Jefe_Area;
                    diccionario2.Add(id.ToString(), nombre);


                }
                ListaJefes.DataSource = new BindingSource(diccionario2, null);
                ListaJefes.DisplayMember = "Value";
                ListaJefes.ValueMember = "Key";
            }
            ListaJefes.SelectedIndex = a;


        }



     
        private void AgregarAsesorTecnico_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea ingresar un nuevo asesor técnico ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertAsesor())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea ingresar un nuevo Jefe de Área ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertJefe())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }
        }


        private void ModificarAsesorTecnico_Click(object sender, EventArgs e)
        {
            if (ListaAsesores.SelectedIndex > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar el asesor tecnico?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var a = new ModificarAsesor(CadenaConexion, ID_Asesor.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }
            }
        }

        private void ModificarJefeArea_Click(object sender, EventArgs e)
        {

            if (ListaJefes.SelectedIndex > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar el Jefe?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var a = new ModificarJefe(CadenaConexion, ID_Jefe.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }
            }
        }


        private void ListaAsesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaAsesores.SelectedIndex > 0)
            {
                ModificarAsesorTecnico.Enabled = true;
                var a = ((KeyValuePair<string, string>)ListaAsesores.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_Asesor = id;
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var item = context.Asesor_Tecnico.ToList();

                    foreach (var valores in item.Where(n => n.ID_Asesor == id))
                    {
                        NomAsesorNR.Text = valores.Nombre1_Asesor;
                        NomAsesor2NR.Text = valores.Nombre2_Asesor;
                        ApeAsesorNR.Text = valores.Apellido_Paterno;
                        ApeAsesor2NR.Text = valores.Apellido_Materno;
                        CargoAsesorNR.Text = valores.Cargo;
                        FichaAsesorNR.Text = valores.Ficha;
                        ExtensionNR.Text = valores.Extension;



                    };

                }

            }
            else
            {
                ModificarAsesorTecnico.Enabled = false;
                NomAsesorNR.Text = null;
                NomAsesor2NR.Text = null;
                ApeAsesorNR.Text = null;
                ApeAsesor2NR.Text = null;
                CargoAsesorNR.Text = null;
                FichaAsesorNR.Text = null;
                ExtensionNR.Text = null;
            }


        }


        private void ListaJefes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListaJefes.SelectedIndex > 0)
            {
                ModificarJefeArea.Enabled = true;
                var a = ((KeyValuePair<string, string>)ListaJefes.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_Jefe = id;
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var item = context.Jefe_Area.ToList();

                    foreach (var valores in item.Where(n => n.ID_Jefe_Area == id))
                    {
                        NomJefeNR.Text = valores.Nombre1_Jefe;
                        NomJefe2NR.Text = valores.Nombre2_Jefe;
                        ApeJefeNR.Text = valores.Apellido_Paterno_Jefe;
                        ApeJefe2NR.Text = valores.Apellido_Materno_Jefe;
                        FichaJefe.Text = valores.Ficha;




                    };

                }

            }
            else
            {
                ModificarJefeArea.Enabled = false;
                NomJefeNR.Text = null;
                NomJefe2NR.Text = null;
                ApeJefeNR.Text = null;
                ApeJefe2NR.Text = null;
                FichaJefe.Text = null;

            }
        }

        private void PanelAsesorTecnicoNR_Click(object sender, EventArgs e)
        {
            panelAsesorTecnicoNR.Focus();
        }
        private void ListaAsesores_Validating(object sender, CancelEventArgs e)
        {
            if (ListaAsesores.SelectedIndex == 0)
            {


                errorProvider.SetError(ListaAsesores, "Seleccione una opcion");

            }
            else
            {
                errorProvider.SetError(ListaAsesores, null);
            }
        }
        public bool Comprobar()
        {
            if (ListaAsesores.SelectedIndex < 1 || ListaJefes.SelectedIndex < 1)
            {
                return false;

            }
            else
            {
                return true;
            }

        }

        private void BtnGuardarNR_Click(object sender, EventArgs e)
        {
            if (Comprobar() == false)
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Area.SingleOrDefault(n => n.ID_Area== ID_Area);
                    if (a != null)
                    {
                        a.ID_Asesor = this.ID_Asesor;
                        a.ID_Jefe_Area = this.ID_Jefe;
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Datos Actualizados");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaJefes_Validating(object sender, CancelEventArgs e)
        {
            if (ListaJefes.SelectedIndex == 0)
            {


                errorProvider.SetError(ListaJefes, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaJefes, null);
            }
        }

    }
}
