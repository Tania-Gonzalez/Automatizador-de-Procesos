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
    public partial class BusquedaPrincipal : UserControl
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

        #region Metodos de apoyo

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
        #endregion

        public BusquedaPrincipal()
        {
            InitializeComponent();
        }

        public void setCD(string t)
        {
            cadenaconexion = t;


        }

        private void BtnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea realizar una nueva busqueda?", "Busqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                Oprimido.Invoke(sender, e);
                Booleano.Invoke(true);
                Activar();

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
            TextEscuela.Text = null;
            TextFolio.Text = null;
            TextNombre.Text = null;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void LlenarTabla()
        {


            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                     join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                     select new Buscador
                                     {
                                         ID=e.ID_Estudiante,
                                         FolioAcept = av.ID_Aceptacion.ToString(),
                                         Nombre=dp.Nombre1+" "+dp.Nombre2 ,
                                         Apellido_Paterno=dp.Apellido_Paterno,
                                         Apellido_Materno=dp.Apellido_Materno,
                                         Escuela=esc.Nombre_Escuela,
                                         Estado= av.Estado.ToString()
                                         
                                         

                                     }).AsQueryable();

                if (!string.IsNullOrEmpty(TextFolio.Text))
                {
                    listabusqueda = listabusqueda.Where(f=>f.FolioAcept.Contains(TextFolio.Text.Trim()));
                }
                if (!string.IsNullOrEmpty(TextNombre.Text))
                {
                    listabusqueda = listabusqueda.Where(n=>n.Nombre.Contains(TextNombre.Text.Trim()));
                }
                if (!string.IsNullOrEmpty(TextEscuela.Text))
                {
                    listabusqueda = listabusqueda.Where(n => n.Escuela.Contains(TextEscuela.Text.Trim()));
                }

                dataGridView1.DataSource = listabusqueda.ToList();
                if(dataGridView1.Rows.Count != 0)
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
            if (string.IsNullOrEmpty(TextFolio.Text)&& string.IsNullOrEmpty(TextEscuela.Text)&& string.IsNullOrEmpty(TextNombre.Text))
            {
                MessageBox.Show("Llene alguna opcion");
            }
            else
            {
                LlenarTabla();

            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {

                DialogResult resultado = MessageBox.Show("¿Desea eliminar el Estudiante con el id:" + "\n" + idestudiante.ToString() + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    EliminarAlumno(id);
                    LlenarTabla();


                }

            }

            
        }
        private void EliminarAlumno(int? id) 
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var tablaEstudiante = context.Estudiante.Where(n => n.ID_Estudiante == id).FirstOrDefault();
                var tablaDatosEscolares = context.Datos_Escolares.Where(n => n.ID_Datos_Escolares == id).FirstOrDefault();
                var tablaArea = context.Area.Where(n => n.ID_Area == id).FirstOrDefault();
                var tablaExpediente = context.Expediente.Where(n => n.ID_Expediente== id).FirstOrDefault();
                var tablaRequisitos = context.Requisitos.Where(n => n.ID_Requisitos== id).FirstOrDefault();
                var tablaDocumentos = context.Documentos.Where(n => n.ID_Documentos == id).FirstOrDefault();
                var tablaDatosPersonales = context.Datos_Personales.Where(n => n.ID_Datos_Personales== id).FirstOrDefault();
                var tablaTutor = context.Tutor.Where(n => n.ID_Ref == id).FirstOrDefault();
                var tablaDireccion= context.Direccion.Where(n => n.ID_Direccion== id).FirstOrDefault();
                var tablaPrograma = context.Programa.Where(n => n.ID_Programa == id).FirstOrDefault();
                var tablaAvance = context.Avance.Where(n => n.ID_Avance == id).FirstOrDefault();
                IQueryable<Reportes> reportesAlumno = context.Reportes.Where(n => n.ID_Avance == id);

                int? idRenta = null;
                
                foreach (var valor in context.Direccion.Where(n=>n.ID_Direccion==id))
                {
                    idRenta = valor.ID_Direccion_Renta;
                }
                
                if(idRenta!=null)
                {
                    var tablaRenta = context.DireccionRenta.Where(n=>n.ID_Renta==idRenta).FirstOrDefault();
                    context.DireccionRenta.Remove(tablaRenta);
                                    
                }               
                
                context.Estudiante.Remove(tablaEstudiante);
                context.Datos_Escolares.Remove(tablaDatosEscolares);
                context.Area.Remove(tablaArea);
                context.Expediente.Remove(tablaExpediente);
                context.Requisitos.Remove(tablaRequisitos);
                context.Documentos.Remove(tablaDocumentos);
                context.Datos_Personales.Remove(tablaDatosPersonales);
                context.Tutor.Remove(tablaTutor);
                context.Direccion.Remove(tablaDireccion);
                context.Programa.Remove(tablaPrograma); 
                context.Avance.Remove(tablaAvance);
                context.Reportes.RemoveRange(reportesAlumno);
                




                context.SaveChanges();
            }


        }


        private void BtnInfoCompleta_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {
                using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
                {
                    
                    using (var a = new BusquedaAlumno(cadenaconexion,id.GetValueOrDefault()))
                    {

                        a.ShowDialog();

                    }
                }

                }

        }
    }
}
