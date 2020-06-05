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
    public partial class RegistrarAsistencia : UserControl
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
        #endregion
        public RegistrarAsistencia()
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
            DialogResult resultado = MessageBox.Show("¿Desea programar un nuevo curso?", "Busqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                     join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                     join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                     select new BusquedaCurso
                                     {
                                         ID = e.ID_Estudiante,
                                         FolioAcept = av.ID_Aceptacion.ToString(),
                                         Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                         Curso = av.Curso_De_Induccion.ToString(),
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

                if (a == 1)//curso
                {
                    listabusqueda = listabusqueda.Where(f => f.Curso.Contains("0")|| f.Curso.Contains("1"));
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

        private void Button5_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {
                using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
                {

                    using (var a = new AsistenciaRegistro(cadenaconexion, id.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }

            }
        }
    }
}
