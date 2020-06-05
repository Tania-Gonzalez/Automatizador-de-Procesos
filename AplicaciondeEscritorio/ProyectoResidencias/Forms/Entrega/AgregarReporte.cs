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
    public partial class AgregarReporte : Form
    {
        #region Variables
        private int ID_Est, ID_Prog, ID_Dp;
        private int? ID_Av;
        private string CadenaConexion;
        private DateTime dia;
        private string mes;
        #endregion

        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                dia = dateTimePicker1.Value;
                mes = comboBox1.SelectedItem.ToString();
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var item = context.Reportes.ToList();
                    bool existente = false;
                    foreach (var valores in item)
                    {
                        if (mes == valores.Mes_Entrega && ID_Av == valores.ID_Avance)
                        {
                            existente = true;
                        }
                    }
                    if (existente == true)
                    {
                        MessageBox.Show("El reporte que intenta registrar ya se encuentra registrado");
                    }
                    else
                    {
                        var a = new Reportes()
                        {
                            ID_Avance = this.ID_Av.GetValueOrDefault(),
                            Mes_Entrega = this.mes,
                            Fecha_Entrega = dia

                        };
                        context.Reportes.Add(a);
                        context.SaveChanges();
                        MessageBox.Show("Reporte Registrado Correctamente!");
                    }


                }




            }
            else
            {
                MessageBox.Show("Seleccione un mes");
            }


        }



        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        public AgregarReporte(string a, int b)
        {
            InitializeComponent();
            CadenaConexion = a;
            ID_Est = b;
            Cargar();
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
