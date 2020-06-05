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
    public partial class DiasFestivos : Form
    {
        #region Variables
        private string CadenaConexion;
        
        private DateTime diaborrar;
        private int idborrar;
        #endregion

        #region Constructores
        public DiasFestivos()
        {
            InitializeComponent();
        }

        public DiasFestivos(string c)
        {
            InitializeComponent();
            CadenaConexion = c;
           
        }
        #endregion

        #region MetodosApoyo
        public void CargarDias()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                IQueryable<FestivosDias> listadias =
                    from d in context.Dias_Festivos orderby d.dia ascending
                    select new FestivosDias 
                    {
                       Nombre = d.nombre,
                       Dia = d.dia, 

                    };
                DiasLista.DataSource = listadias.ToList();
            }

        }
        private int? GetID()
        {
            try
            {
                var a = DiasLista.Rows[DiasLista.CurrentRow.Index].Cells[1].Value.ToString();
                diaborrar = Convert.ToDateTime(a);

                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var item = context.Dias_Festivos.ToList();

                    foreach (var valores in item.Where(n => n.dia == diaborrar.Date))
                    {
                        idborrar = valores.ID_dia;

                    }

                }
                return idborrar;
             }
            catch
            {
                return null;
            }
        }

        #endregion

        private void DiasFestivos_Load(object sender, EventArgs e)
        {
            CargarDias();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea ingresar un nuevo día?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new NuevoDias(CadenaConexion))
                {
                    
                    a.ShowDialog();

                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            CargarDias();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? id=GetID();
            if (id!=null)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el día:"+"\n"+diaborrar.Date.ToShortDateString()+" ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Dias_Festivos.Where(n => n.ID_dia == id).FirstOrDefault();
                        context.Dias_Festivos.Remove(a);
                        context.SaveChanges();
                    }
                    CargarDias();
                }
            }

            
                
            
            
        }

        private void DiasLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
