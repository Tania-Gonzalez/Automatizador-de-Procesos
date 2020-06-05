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
    public partial class ReportesUC : UserControl
    {
        private string cadenaconexion;
        public ReportesUC()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == dataGridView1.Columns.Count-1)
            {
                int fila = e.RowIndex;
                int id =Int32.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                string valorrep= dataGridView1.Rows[fila].Cells[3].Value.ToString();
                if (valorrep=="0")
                {
                    MessageBox.Show("El alumno no cuenta con ningun reporte", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    using (var a = new ReportesEntregados(cadenaconexion,id))
                    {
                        a.ShowDialog();

                    }

                }

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
        public void setCD(string t)
        {
            cadenaconexion = t;
            
        }
        public void CargarTodos()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var query = (from e in context.Estudiante
                             join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                             join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                             join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                             join ar in context.Area on e.ID_Area equals ar.ID_Area
                             join ass in context.Asesor_Tecnico on ar.ID_Asesor equals ass.ID_Asesor
                             where (av.Estado == true)
                             select new Reportescls
                             {
                                 ID = e.ID_Estudiante,
                                 Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                 Telefono = dp.Celular,
                                 Correo = dp.Correo,
                                 Extension = ass.Extension,
                                 FolioAceptacion = av.ID_Aceptacion.ToString(),
                                 Estado = av.Estado.ToString(),
                                 CantidadReportes= (from r in context.Reportes where (r.ID_Avance==av.ID_Avance)select r.ID_Reportes).Count(),
                                 FechaInicioDT=pg.Fecha_Inicio,
                                 FechaTerminoDT=pg.Fecha_Final
                                  
                             }).ToList();
                reportesclsBindingSource.DataSource = query;
               
                DataGridViewButtonColumn btnreportes = new DataGridViewButtonColumn();
                btnreportes.HeaderText = "Informacion";
                btnreportes.Name = "boton";
                btnreportes.Text = "Ver";
                btnreportes.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["boton"] == null)
                {
                    dataGridView1.Columns.Insert(dataGridView1.Columns.Count, btnreportes);
                }
               


            }


            }
        public void CargarBusqueda()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                             join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                             join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                             join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                             join ar in context.Area on e.ID_Area equals ar.ID_Area
                             join ass in context.Asesor_Tecnico on ar.ID_Asesor equals ass.ID_Asesor
                             where (av.Estado == true)
                             select new Reportescls
                             {
                                 ID = e.ID_Estudiante,
                                 Nombre = dp.Nombre1 + " " + dp.Nombre2 + " " + dp.Apellido_Paterno + " " + dp.Apellido_Materno,
                                 Telefono = dp.Celular,
                                 Correo = dp.Correo,
                                 Extension = ass.Extension,
                                 FolioAceptacion = av.ID_Aceptacion.ToString(),
                                 Estado = av.Estado.ToString(),
                                 CantidadReportes = (from r in context.Reportes where (r.ID_Avance == av.ID_Avance) select r.ID_Reportes).Count(),
                                 FechaInicioDT = pg.Fecha_Inicio,
                                 FechaTerminoDT = pg.Fecha_Final
                             }).AsQueryable();

                if (!string.IsNullOrEmpty(TextFolio.Text))
                {
                    listabusqueda = listabusqueda.Where(f => f.FolioAceptacion.Contains(TextFolio.Text.Trim()));
                }
                if (!string.IsNullOrEmpty(TextNombre.Text))
                {
                    listabusqueda = listabusqueda.Where(n => n.Nombre.Contains(TextNombre.Text.Trim()));
                }
            
                reportesclsBindingSource.DataSource = listabusqueda.ToList();
                DataGridViewButtonColumn btnreportes = new DataGridViewButtonColumn();
                btnreportes.HeaderText = "Informacion";
                btnreportes.Name = "boton";
                btnreportes.Text = "Ver";
                btnreportes.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["boton"] == null)
                {
                    dataGridView1.Columns.Insert(dataGridView1.Columns.Count, btnreportes);
                }



            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextFolio.Text) && string.IsNullOrEmpty(TextNombre.Text))
            {
                MessageBox.Show("Llene alguna opcion");
            }
            else
            {
                CargarBusqueda();
                panel2.Visible = true;

            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            CargarTodos();
            panel2.Visible = true;
        }
    }
}