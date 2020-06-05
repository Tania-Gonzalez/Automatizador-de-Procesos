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
    public partial class CalculadoraPeriodos : UserControl
    {
        #region Variables
        private string CadenaConexion;
       

        #endregion
        public CalculadoraPeriodos()
        {
            InitializeComponent();
        }

        public void setCD(string t)
        {
            CadenaConexion = t;


        }

        private void ProgramaNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProgramaNR.SelectedIndex > 0)
            {
                TextBoxPrograma.Text = ProgramaNR.SelectedItem.ToString();

            }
            else
            {
                TextBoxPrograma.Text = null;
            }

        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HorasDiariasSV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (HorasDiariasSV.SelectedIndex == 0)
            {
                
                HorasDiariasNR.Text = null;
                


            }
            if (HorasDiariasSV.SelectedIndex == 1)
            {
                
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();


            }
            if (HorasDiariasSV.SelectedIndex == 2)
            {
                
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();

            }
            if (HorasDiariasSV.SelectedIndex == 3)
            {
                
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();

            }


            if (HorasDiariasSV.SelectedIndex != 0)
            {

           

            }

        }
        private void ProgramaNR_Validating(object sender, CancelEventArgs e)
        {
            if (ProgramaNR.SelectedIndex == 0)
            {


                errorProvider.SetError(ProgramaNR, "Seleccione una opcion");

            }
            else
            {

                errorProvider.SetError(ProgramaNR, null);
            }
        }

        private void HorasDiariasSV_Validating(object sender, CancelEventArgs e)
        {
            if (HorasDiariasSV.SelectedIndex == 0)
            {


                errorProvider.SetError(HorasDiariasSV, "Seleccione una opcion");
                
            }
            else
            {

                errorProvider.SetError(HorasDiariasSV, null);
                
            }
        }

        private void HorasTotalesNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HorasTotalesNR.Text))
            {


                errorProvider.SetError(HorasTotalesNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(HorasTotalesNR, null);
            }
        }
       

        private void FechaTermNR_Validating(object sender, CancelEventArgs e)
        {
            if (FechaTermNR.Value == DateTime.Today)
            {
                errorProvider.SetError(FechaTermNR, "Fecha Erronea");

            }
            else
            {
                errorProvider.SetError(FechaTermNR, null);
            }
        }

        private void DiasFestivos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea revisar los dias festivos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new DiasFestivos(CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (ProgramaNR.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Programa");

            }
            if (ProgramaNR.SelectedIndex == 1)
            {
                var fecha = FechaInicioNR.Value.AddMonths(6);

                FechaTermNR.Value = fecha.Date;

            }
            if (ProgramaNR.SelectedIndex == 2)
            {
                
                if (string.IsNullOrEmpty(HorasDiariasNR.Text) || string.IsNullOrEmpty(HorasTotalesNR.Text))
                {
                    MessageBox.Show("Falta llenar horas totales u horas diarias");
                }
                else
                {
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var fecha = FechaInicioNR.Value;
                        int diaslab = Int32.Parse(HorasTotalesNR.Text) / Int32.Parse(HorasDiariasNR.Text);
                        int residuo = Int32.Parse(HorasTotalesNR.Text) % Int32.Parse(HorasDiariasNR.Text);

                        if (residuo != 0)
                        {
                            diaslab = diaslab + 1;
                        }
                        var item = context.Dias_Festivos.ToList();

                        do
                        {
                            fecha = fecha.AddDays(1);
                            diaslab--;
                            foreach (var valores in item.Where(n => n.dia == fecha.Date))
                            {
                                diaslab++;

                            }
                            if ((int)fecha.DayOfWeek == 0 || (int)fecha.DayOfWeek == 6)
                            {
                                diaslab++;
                            }

                        } while (diaslab > 1);
                        FechaTermNR.Value = fecha.Date;
                    }
                }

            }
        }

    
    }
}
