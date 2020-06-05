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
    public partial class UCGeneradorCredenciales : UserControl
    {
        #region Delegador

        public delegate void PasarBool(bool t);
        public delegate void Clickeado(object sender, EventArgs e);



        public event PasarBool Booleano;
        public event Clickeado Oprimido;


        #endregion
        #region Variables
        public string cadenaconexion;
        private int idestudiante;
        private List<int> ListaSolicitar = new List<int>();
        #endregion
        public UCGeneradorCredenciales()
        {
            InitializeComponent();
        }
        public void setCD(string t)
        {
            cadenaconexion = t;


        }
        private int? GetID()
        {
            try
            {
                var a = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                idestudiante = Int32.Parse(a);
                return idestudiante;
            }
            catch
            {
                return null;

            }
        }


        public void Sololetras(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != ' '))

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

        private void Activar()
        {
            btnBuscarEstudiante.Visible = false;
            BtnTerminar.Visible = true;
            panel1.Visible = true;



        }
        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Booleano.Invoke(false);
            Ocultar();
        }
        private void Ocultar()
        {
            BtnTerminar.Visible = false;
            btnBuscarEstudiante.Visible = true;
            dataGridView1.DataSource = null;
            TextFolio.Text = null;
            TextNombre.Text = null;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void BtnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea realizar una nueva solicitud de folio?", "Busqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                Oprimido.Invoke(sender, e);
                Booleano.Invoke(true);
                Activar();

            }
        }

        private void LlenarTabla(int? a)
        {


            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join exp in context.Expediente on e.ID_Expediente equals exp.ID_Expediente
                                     select new GeneradorCredenciales
                                     {
                                         ID = e.ID_Estudiante,
                                         FolioAcept = av.ID_Aceptacion.ToString(),
                                         Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         Credencial = av.Credencial.ToString(),
                                         Estado = av.Estado.ToString()



                                     }).AsQueryable();
                if (a == null)
                {
                    if (!string.IsNullOrEmpty(TextFolio.Text))
                    {
                        listabusqueda = listabusqueda.Where(f => f.FolioAcept.Contains(TextFolio.Text.Trim()));
                        dataGridView1.DataSource = listabusqueda.ToList();
                    }


                    if (!string.IsNullOrEmpty(TextNombre.Text))
                    {
                        listabusqueda = listabusqueda.Where(n => n.Nombre.Contains(TextNombre.Text.Trim()));
                        dataGridView1.DataSource = listabusqueda.ToList();
                    }
                }

                if (a == 1)//sin credencial entregada
                {
                    listabusqueda = listabusqueda.Where(f => f.Credencial.Contains("False"));
                    dataGridView1.DataSource = listabusqueda.ToList();
                }



                if (dataGridView1.Rows.Count != 0)
                {
                    panel2.Visible = true;
                }
                else
                {
                    panel2.Visible = false;
                }

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextFolio.Text) && string.IsNullOrEmpty(TextNombre.Text))
            {
                MessageBox.Show("Llene alguna opcion");
            }
            else
            {
                LlenarTabla(null);

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LlenarTabla(1);

        }

       

        private void BtnPasar_Click(object sender, EventArgs e)
        {
            bool existente = false;

            if (dataGridView2.Rows.Count >=8)
            {
                MessageBox.Show("No se puede pasar mas elementos a la lista de generar ya que se llego al tamaño maximo permitido(tamaño máximo permitido 8 Credenciales por archivo)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int? id = GetID();
                if (id != null)
                {
                    for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow fila = dataGridView1.Rows[i];
                        if (id.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            if (dataGridView2.Rows.Count == 0)
                            {
                                generadorCredencialesBindingSource.Add((GeneradorCredenciales)fila.DataBoundItem);

                            }
                            else
                            {
                                for (int j = dataGridView2.RowCount - 1; j >= 0; j--)
                                {
                                    var item = dataGridView2.Rows[j].Cells[0].Value.ToString();
                                    if (id.ToString() == item)
                                    {
                                        existente = true;
                                    }

                                }
                                if (existente == false)
                                {
                                    generadorCredencialesBindingSource.Add((GeneradorCredenciales)fila.DataBoundItem);
                                }

                            }



                        }

                    }

                }
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                generadorCredencialesBindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }

        private void BtnPasarTodo_Click(object sender, EventArgs e)
        {

            bool existente = false;
            string id;
            if (dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.Rows.Count > 8)
                {
                    MessageBox.Show("No se puede pasar toda la lista de busqueda ya que excede el tamaño máximo permitido(tamaño máximo permitido 8 Credenciales por archivo)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        DataGridViewRow fila = dataGridView1.Rows[i];
                        if (dataGridView2.Rows.Count == 0)
                        {
                            generadorCredencialesBindingSource.Add((GeneradorCredenciales)fila.DataBoundItem);

                        }
                        else
                        {
                            for (int j = dataGridView2.RowCount - 1; j >= 0; j--)
                            {
                                var item = dataGridView2.Rows[j].Cells[0].Value.ToString();
                                if (id == item)
                                {
                                    existente = true;
                                }

                            }
                            if (existente == false)
                            {
                                generadorCredencialesBindingSource.Add((GeneradorCredenciales)fila.DataBoundItem);
                            }
                        }
                    }
                }



            }



        }
        private void LlenarListaSolicitada()
        {
            ListaSolicitar.Clear();

            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                var item = Int32.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                ListaSolicitar.Add(item);
            }


        }




        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                generadorCredencialesBindingSource.Clear();
            }

        }




        private void Button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                LlenarListaSolicitada();
                using (var a = new Credenciales(cadenaconexion, ListaSolicitar))
                {

                    a.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Debe añadir al menos un estudiante a la lista por generar");
            }
        }
    }
}
