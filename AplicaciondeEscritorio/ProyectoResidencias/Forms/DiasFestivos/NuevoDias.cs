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
    public partial class NuevoDias : Form
    {
        #region Variables
        private string CadenaConexion;
        DateTime Dia=DateTime.Today;
        #endregion
        public NuevoDias()
        {
            InitializeComponent();
        }
        public NuevoDias(string t)
        {
            InitializeComponent();
            CadenaConexion = t;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Dia = dateTimePicker1.Value;

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Dias_Festivos.ToList();
                bool existente = false; 
                foreach (var valores in item)
                {
                    if (Dia.Date == valores.dia)
                    {
                        existente = true;
                    }
                }
                if (existente == true)
                {
                    MessageBox.Show("El día que intenta registrar ya se encuentra en los dias festivos");
                }
                else
                {
                    int num = ((int)Dia.DayOfWeek);
                    string nom="";
                    switch (num)
                    {
                        case 0:
                            nom = "Domingo";
                            break;
                        case 1:
                            nom = "Lunes";
                            break;
                        case 2:
                            nom = "Martes";
                            break;
                        case 3:
                            nom = "Miércoles";
                            break;
                        case 4:
                            nom = "Jueves";
                            break;
                        case 5:
                            nom = "Viernes";
                            break;
                        case 6:
                            nom = "Sábado";
                            break;

                    }
                                                        
                    var a = new Dias_Festivos()
                    {
                        nombre = nom,
                        dia = Dia

                    };
                    context.Dias_Festivos.Add(a);
                    context.SaveChanges();
                    MessageBox.Show("Insercion Correcta");
                }


            }

        }

    }

}

