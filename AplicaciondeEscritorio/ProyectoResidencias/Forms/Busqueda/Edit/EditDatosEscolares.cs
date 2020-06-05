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
    public partial class EditDatosEscolares : Form
    {
        #region Variables
        private int ID_datosescolares;
        private int? ID_esc, ID_persona, ID_car;
        private string CadenaConexion;
        #endregion
        public EditDatosEscolares(int a, string b)
        {
            InitializeComponent();
            this.ID_datosescolares = a;
            this.CadenaConexion = b;
            Cargar();
            LlenarDatosEscolares();
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Datos_Escolares.ToList();
                foreach (var valores in item.Where(n => n.ID_Datos_Escolares == ID_datosescolares))
                {
                    this.ID_esc = valores.ID_Escuela;
                    this.ID_car= valores.ID_Carrera;
                    this.ID_persona = valores.ID_Persona_Enc;
                    MatriculaNR.Text = valores.Matricula;
                    SemestreTxtbox.Text = valores.Semestre;
                    PromedioNR.Text = valores.Promedio_General.ToString();
                }

            }
        }

        public void SoloNumerosDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    

        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(EscuelaNR.Text) || string.IsNullOrEmpty(CarreraNR.Text) || string.IsNullOrEmpty(MatriculaNR.Text) || string.IsNullOrEmpty(PromedioNR.Text) || string.IsNullOrEmpty(NomEncargadoNR.Text)||string.IsNullOrEmpty(SemestreTxtbox.Text) )
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
        }
        public void LlenarDatosEscolares()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Escuela.ToList();
                diccionario.Add("0", "Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Nombre_Escuela;
                    var id = valores.ID_Escuela;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaEscuela.DataSource = new BindingSource(diccionario, null);
                ListaEscuela.DisplayMember = "Value";
                ListaEscuela.ValueMember = "Key";
                ListaEscuela.SelectedValue = ID_esc.ToString();
                   


                ////
                ///

                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();
                var item2 = context.Carrera.ToList();
                diccionario2.Add("0", "Seleccione");


                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre_Carrera;
                    var id = valores.ID_Carrera;
                    diccionario2.Add(id.ToString(), nombre);



                }
                ListaCarrera.DataSource = new BindingSource(diccionario2, null);
                ListaCarrera.DisplayMember = "Value";
                ListaCarrera.ValueMember = "Key";
                ListaCarrera.SelectedValue =ID_car.ToString();


                /////
                Dictionary<string, string> diccionario3 = new Dictionary<string, string>();
                var item3 = context.Encargado_Escuela.ToList();
                diccionario3.Add("0", "Seleccione");

                foreach (var valores in item3)
                {
                    var nombre = valores.Nombre1_Encargado + " " + valores.Nombre2_Encargado + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    var id = valores.ID_Encargado;
                    diccionario3.Add(id.ToString(), nombre);


                }
                ListaEncargado.DataSource = new BindingSource(diccionario3, null);
                ListaEncargado.DisplayMember = "Value";
                ListaEncargado.ValueMember = "Key";
                ListaEncargado.SelectedValue = ID_persona.ToString();



            }

        }


        private void ListaEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEscuela.SelectedIndex > 0)
            {
                EscuelaNR.Text = ((KeyValuePair<string, string>)ListaEscuela.SelectedItem).Value;
                var a = ((KeyValuePair<string, string>)ListaEscuela.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_esc = id;
                Modificar_Escuela.Enabled = true;

            }
            else
            {
                EscuelaNR.Text = null;
                Modificar_Escuela.Enabled = false;
            }





        }

        private void ListaCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCarrera.SelectedIndex > 0)
            {
                CarreraNR.Text = ((KeyValuePair<string, string>)ListaCarrera.SelectedItem).Value;
                var a = ((KeyValuePair<string, string>)ListaCarrera.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_car = id;
                Modificar_Carrera.Enabled = true;


            }
            else
            {
                CarreraNR.Text = null;
                Modificar_Carrera.Enabled = false;
            }

        }




        #region BindOnClickListas  
        private void ListaCarrera_Click(object sender, EventArgs e)
        {
            int a = ListaCarrera.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario2 = new Dictionary<string, string>();
                var item2 = context.Carrera.ToList();

                diccionario2.Add("0", "Seleccione");

                foreach (var valores in item2)
                {
                    var nombre = valores.Nombre_Carrera;
                    var id = valores.ID_Carrera;
                    diccionario2.Add(id.ToString(), nombre);



                }
                ListaCarrera.DataSource = new BindingSource(diccionario2, null);
                ListaCarrera.DisplayMember = "Value";
                ListaCarrera.ValueMember = "Key";



            }

            ListaCarrera.SelectedIndex = a;


        }


        private void ListaEscuela_Click(object sender, EventArgs e)
        {

            int a = ListaEscuela.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Escuela.ToList();
                diccionario.Add("0", "Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Nombre_Escuela;
                    var id = valores.ID_Escuela;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaEscuela.DataSource = new BindingSource(diccionario, null);
                ListaEscuela.DisplayMember = "Value";
                ListaEscuela.ValueMember = "Key";

            }

            ListaEscuela.SelectedIndex = a;


        }

        private void ListaEncargado_Click(object sender, EventArgs e)
        {
            int a = ListaEncargado.SelectedIndex;
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario3 = new Dictionary<string, string>();
                var item3 = context.Encargado_Escuela.ToList();
                diccionario3.Add("0", "Seleccione");

                foreach (var valores in item3)
                {
                    var nombre = valores.Nombre1_Encargado + " " + valores.Nombre2_Encargado + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                    var id = valores.ID_Encargado;
                    diccionario3.Add(id.ToString(), nombre);


                }
                ListaEncargado.DataSource = new BindingSource(diccionario3, null);
                ListaEncargado.DisplayMember = "Value";
                ListaCarrera.ValueMember = "Key";
            }

            ListaEncargado.SelectedIndex = a;

        }


        #endregion

        #region AgregarOpciones

        private void Nueva_Carrera_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea ingresar una nueva Carrera? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertCarrera())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }
        }




        private void Nueva_Escuela_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea ingresar una nueva Escuela? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertEscuela())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }
        }



        private void Nuevo_Encargado_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea ingresar un nuevo Encargado? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new InsertEncargado())
                {
                    a.Cadena(CadenaConexion);
                    a.ShowDialog();

                }
            }
        }


        #endregion

        #region ModificarOpciones

        private void Modificar_Escuela_Click(object sender, EventArgs e)
        {
            if (ListaEscuela.SelectedIndex > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar el nombre de la escuela?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var a = new ModificarEscuela(CadenaConexion, ID_esc.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }
            }

        }

        private void Modificar_Carrera_Click(object sender, EventArgs e)
        {
            if (ListaCarrera.SelectedIndex > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar el nombre de la carrera?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var a = new ModificarCarrera(CadenaConexion, ID_car.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }
            }
        }

        private void Modificar_Encargado_Click(object sender, EventArgs e)
        {
            if (ListaEncargado.SelectedIndex > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea modificar los datos del encargado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var a = new ModificarEncargado(CadenaConexion, ID_persona.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }
            }
        }
        #endregion

        private void ListaEscuela_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EscuelaNR.Text))
            {


                errorProvider.SetError(ListaEscuela, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaEscuela, null);
            }
        }

        private void ListaCarrera_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CarreraNR.Text))
            {


                errorProvider.SetError(ListaCarrera, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaCarrera, null);
            }
        }

        private void ListaEncargado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomEncargadoNR.Text))
            {
                errorProvider.SetError(ListaEncargado, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ListaEncargado, null);
            }
        }

        private void MatriculaNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MatriculaNR.Text))
            {


                errorProvider.SetError(MatriculaNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(MatriculaNR, null);
            }
        }

        private void PromedioNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PromedioNR.Text))
            {


                errorProvider.SetError(PromedioNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(PromedioNR, null);
            }
        }

        private void BtnGuardarDatosEscolaresNR_Click(object sender, EventArgs e)
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
                        var a = context.Datos_Escolares.SingleOrDefault(n => n.ID_Datos_Escolares== ID_datosescolares);
                        if (a != null)
                        {
                            a.Semestre = SemestreTxtbox.Text.Trim();
                            a.Matricula= MatriculaNR.Text.Trim();
                            a.Promedio_General = decimal.Parse(PromedioNR.Text.Trim()); 
                            a.ID_Escuela = this.ID_esc.GetValueOrDefault();
                            a.ID_Carrera = this.ID_esc.GetValueOrDefault();
                            a.ID_Persona_Enc = this.ID_persona.GetValueOrDefault();
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Datos Actualizados");


                }

            }
        }

        private void PanelDatosEscolaresNR_Click(object sender, EventArgs e)
        {
            panelDatosEscolaresNR.Focus();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SemestreTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SemestreTxtbox.Text))
            {


                errorProvider.SetError(SemestreTxtbox, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(SemestreTxtbox, null);
            }
        }

        private void ListaEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEncargado.SelectedIndex > 0)
            {
                var a = ((KeyValuePair<string, string>)ListaEncargado.SelectedItem).Key;
                int id = Int32.Parse(a);
                ID_persona = id;
                Modificar_Encargado.Enabled = true;
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {

                    var item = context.Encargado_Escuela.ToList();

                    foreach (var valores in item.Where(n => n.ID_Encargado == id))
                    {
                        NomEncargadoNR.Text = valores.Nombre1_Encargado;
                        NomEncargado2NR.Text = valores.Nombre2_Encargado;
                        ApeEncargadoNR.Text = valores.Apellido_Paterno;
                        ApeEncargado2NR.Text = valores.Apellido_Materno;
                        CargoEncargadoNR.Text = valores.Cargo;
                        TelEncargadoNR.Text = valores.Telefono;
                        CorreoEncargadoNR.Text = valores.Correo;


                    };

                }

            }
            else
            {
                Modificar_Encargado.Enabled = false;
                NomEncargadoNR.Text = null;
                NomEncargado2NR.Text = null;
                ApeEncargadoNR.Text = null;
                ApeEncargado2NR.Text = null;
                CargoEncargadoNR.Text = null;
                TelEncargadoNR.Text = null;
                CorreoEncargadoNR.Text = null;
            }


        }

    }
}
