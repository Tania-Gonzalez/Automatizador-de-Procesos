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
    public partial class EliminarReporte : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av,ID_RepEliminar;
        private string CadenaConexion;

        #endregion
        public EliminarReporte(string a,int b)
        {
            InitializeComponent();
            CadenaConexion = a;
            ID_Est = b;
            Cargar();
            LlenarLista();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>0)
            {
                var a = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
                int id = Int32.Parse(a);
                this.ID_RepEliminar= id;

            }
            else
            {
                ID_RepEliminar = null;
            }
        }



        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                if (ID_RepEliminar != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el Reporte correspondiente al mes de: " + "\n" + comboBox1.SelectedItem.ToString() + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                        {
                            var a = context.Reportes.Where(n => n.ID_Reportes== ID_RepEliminar).FirstOrDefault();
                            context.Reportes.Remove(a);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Reporte Eliminado");
                        LlenarLista();

                    }

                }

            }
            else
            {
                MessageBox.Show("Seleccione un mes");
            }


        }

        private void LlenarLista()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                Dictionary<string, string> diccionario = new Dictionary<string, string>();

                var item = context.Reportes;
                diccionario.Add("0", "Seleccione");
                foreach (var valores in item.Where(n=>n.ID_Avance==this.ID_Av))
                {
                    var nombre = valores.Mes_Entrega;
                    var id = valores.ID_Reportes;
                    diccionario.Add(id.ToString(), nombre);
                }

                comboBox1.DataSource = new BindingSource(diccionario, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                comboBox1.SelectedIndex = 0; 

            }

        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Estudiante.ToList();
                foreach (var valores in item.Where(n => n.ID_Estudiante == ID_Est))
                {
                    this.ID_Prog = valores.ID_Programa;
                    this.ID_Dp = valores.ID_Datos_Personales;
                }
                var item2 = context.Programa.ToList();
                foreach (var valores in item2.Where(n => n.ID_Programa == this.ID_Prog))
                {
                    this.ID_Av = valores.ID_Avance;
                }
                var item3 = context.Datos_Personales.ToList();
                foreach (var valores in item3.Where(n => n.ID_Datos_Personales == this.ID_Dp))
                {
                    Nombre.Text = valores.Nombre1 + " " + valores.Nombre2 + " " + valores.Apellido_Paterno + " " + valores.Apellido_Materno;
                }
            }
        }
    }
}
