using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class NuevoRegistroDatosEscolares : UserControl
    {
        #region Delegados
        public delegate void GDatosEscolares(List<string> a);
        public event GDatosEscolares GuardarDatosEscolares;
        #endregion
        #region Variables
        private string CadenaConexion;
        private int id_escuela, id_encargado_escuela, id_carrera;
        List<string> ListaDatosEscolares = new List<string>();


        #endregion

        #region Constructores  
        public NuevoRegistroDatosEscolares()
        {
            InitializeComponent();
        }


        #endregion

        #region MetodosApoyo 
        public void Limpiar()
        {

            ListaDatosEscolares.Clear();
            EscuelaNR.Text = "";
            CarreraNR.Text = "";
            MatriculaNR.Text = "";
            PromedioNR.Text = "";
            SemestreTxtbox.Text = "";
            NomEncargadoNR.Text = "";
            NomEncargado2NR.Text = "";
            ApeEncargadoNR.Text = "";
            ApeEncargado2NR.Text = "";
            CargoEncargadoNR.Text = "";
            TelEncargadoNR.Text = "";
            CorreoEncargadoNR.Text = "";

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
        public void SetCadena(string t)
        {
            CadenaConexion = t;

        }
        public bool Comprobar()
        {
            bool r;
            if (string.IsNullOrEmpty(EscuelaNR.Text) || string.IsNullOrEmpty(CarreraNR.Text) || string.IsNullOrEmpty(MatriculaNR.Text) || string.IsNullOrEmpty(PromedioNR.Text)|| string.IsNullOrEmpty(NomEncargadoNR.Text) || string.IsNullOrEmpty(SemestreTxtbox.Text))
            {
                r = false;

            }
            else
            {
                r = true;
            }
            return r;
        }
        public void LlenarDatosEscolares(string t)
        {
            using (var context = new Base_Servicio_PracticasEntities(t))
            {
                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Escuela.ToList();
                diccionario.Add("0","Seleccione");

                foreach (var valores in item)
                {
                    var nombre = valores.Nombre_Escuela;
                    var id = valores.ID_Escuela;
                    diccionario.Add(id.ToString(), nombre);


                }
                ListaEscuela.DataSource = new BindingSource(diccionario, null);
                ListaEscuela.DisplayMember = "Value";
                ListaEscuela.ValueMember = "Key";
                ListaEscuela.SelectedIndex = 0;


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
                ListaCarrera.SelectedIndex = 0;


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
             


            }

        }


        private void ListaEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEscuela.SelectedIndex >0)
            {               
                EscuelaNR.Text = ((KeyValuePair<string, string>)ListaEscuela.SelectedItem).Value;
                var a = ((KeyValuePair<string, string>)ListaEscuela.SelectedItem).Key;
                int id = Int32.Parse(a);
                id_escuela = id;
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
            if (ListaCarrera.SelectedIndex>0)
            {
                CarreraNR.Text = ((KeyValuePair<string, string>)ListaCarrera.SelectedItem).Value;
                var a = ((KeyValuePair<string, string>)ListaCarrera.SelectedItem).Key;
                int id = Int32.Parse(a);
                id_carrera= id;
                Modificar_Carrera.Enabled = true;


            }
            else
            {
                CarreraNR.Text = null;
                Modificar_Carrera.Enabled = false;
            }

        }



        #endregion

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
                diccionario.Add("0","Seleccione");

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
                    using (var a = new ModificarEscuela(CadenaConexion, id_escuela))
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
                    using (var a = new ModificarCarrera(CadenaConexion, id_carrera))
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
                    using (var a = new ModificarEncargado(CadenaConexion, id_encargado_escuela))
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
                    ListaDatosEscolares.Clear();
                    ListaDatosEscolares.Add(SemestreTxtbox.Text);
                    ListaDatosEscolares.Add(MatriculaNR.Text);
                    ListaDatosEscolares.Add(PromedioNR.Text);
                    ListaDatosEscolares.Add(id_escuela.ToString());
                    ListaDatosEscolares.Add(id_encargado_escuela.ToString());
                    ListaDatosEscolares.Add(id_carrera.ToString());

                    GuardarDatosEscolares.Invoke(ListaDatosEscolares);
                }

            }
        }

        private void PanelDatosEscolaresNR_Click(object sender, EventArgs e)
        {
            panelDatosEscolaresNR.Focus();
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



        public void Cancelar(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider.Clear();

        }

        private void ListaEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEncargado.SelectedIndex>0)
            {
                var a = ((KeyValuePair<string, string>)ListaEncargado.SelectedItem).Key;
                int id = Int32.Parse(a);
                id_encargado_escuela = id;
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

