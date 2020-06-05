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
    public partial class EditPrograma : Form
    {
        #region Variables

        private int ID_programa;
        private string CadenaConexion;
        #endregion

        public EditPrograma(int a, string b)
        {
            InitializeComponent();
            ID_programa = a;
            CadenaConexion = b;
            Cargar();
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                string horainicio = null;string horafin=null;
                var datosprograma = context.Programa.ToList();
                foreach (var valores in datosprograma.Where(n => n.ID_Programa == ID_programa))
                {
                    TextBoxPrograma.Text = valores.Nombre_Programa;
                    HorasDiariasNR.Text = valores.Horas_Diarias.ToString();
                    HorasTotalesNR.Text = valores.Horas_Totales.ToString();
                    FechaInicioNR.Value = valores.Fecha_Inicio;
                    FechaTermNR.Value = valores.Fecha_Final;
                    horainicio = valores.Hora_Inicio;
                    horafin = valores.Hora_Termino;
                    ActividadesNR.Text = valores.Actividades;
                    ProyectoNR.Text = valores.Nombre_Proyecto;
                }
                String[] hi = horainicio.Split(':');
                String[] ht = horafin.Split(':');
                HoraEntradaNR.Text = hi[0];
                HoraEntradaNR2.Text = hi[1];
                HoraSalidaNR.Text = ht[0];
                HoraSalidaNR2.Text = ht[1];
            }

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(TextBoxPrograma.Text) || string.IsNullOrEmpty(HorasDiariasNR.Text) || string.IsNullOrEmpty(HorasTotalesNR.Text) ||
                FechaTermNR.Value == DateTime.Today || string.IsNullOrEmpty(HoraEntradaNR.Text) || string.IsNullOrEmpty(HoraEntradaNR2.Text) ||
                 string.IsNullOrEmpty(HoraSalidaNR.Text) || string.IsNullOrEmpty(HoraSalidaNR2.Text)||
                string.IsNullOrEmpty(ActividadesNR.Text) || string.IsNullOrEmpty(ProyectoNR.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LlenarLista(int a)
        {
            HoraEntradaSV.Items.Clear();

            switch (a)
            {
                case 4:
                    HoraEntradaSV.Items.Add("08");
                    HoraEntradaSV.Items.Add("09");
                    HoraEntradaSV.Items.Add("10");
                    HoraEntradaSV.Items.Add("11");
                    HoraEntradaSV.Items.Add("12");
                    HoraEntradaSV.Items.Add("13");
                    HoraEntradaSV.Items.Add("14");
                    HoraEntradaSV.SelectedIndex = 0;


                    break;
                case 5:
                    HoraEntradaSV.Items.Add("08");
                    HoraEntradaSV.Items.Add("09");
                    HoraEntradaSV.Items.Add("10");
                    HoraEntradaSV.Items.Add("11");
                    HoraEntradaSV.Items.Add("12");
                    HoraEntradaSV.Items.Add("13");
                    HoraEntradaSV.SelectedIndex = 0;


                    break;
                case 6:
                    HoraEntradaSV.Items.Add("08");
                    HoraEntradaSV.Items.Add("09");
                    HoraEntradaSV.Items.Add("10");
                    HoraEntradaSV.Items.Add("11");
                    HoraEntradaSV.Items.Add("12");
                    HoraEntradaSV.SelectedIndex = 0;


                    break;

            }


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
                HoraEntradaSV.Items.Clear();
                HorasDiariasNR.Text = null;
                HoraEntradaNR.Text = null;



            }
            if (HorasDiariasSV.SelectedIndex == 1)
            {
                LlenarLista(4);
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();


            }
            if (HorasDiariasSV.SelectedIndex == 2)
            {
                LlenarLista(5);
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();

            }
            if (HorasDiariasSV.SelectedIndex == 3)
            {
                LlenarLista(6);
                HorasDiariasNR.Text = HorasDiariasSV.SelectedItem.ToString();

            }


            if (HorasDiariasSV.SelectedIndex != 0)
            {

                int a = Int32.Parse(HorasDiariasNR.Text);
                int b = Int32.Parse(HoraEntradaNR.Text);
                int c = a + b;
                HoraSalidaNR.Text = c.ToString();
            }

        }

        private void HoraEntradaSV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoraSalidaNR2.Text = HoraEntradaSV2.SelectedItem.ToString();
            HoraEntradaNR2.Text = HoraEntradaSV2.SelectedItem.ToString();

        }

        private void HoraEntradaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoraEntradaNR.Text = HoraEntradaSV.SelectedItem.ToString();
            if (HorasDiariasNR.Text != "")
            {
                int a = Int32.Parse(HorasDiariasNR.Text);
                int b = Int32.Parse(HoraEntradaNR.Text);
                int c = a + b;
                HoraSalidaNR.Text = c.ToString();
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
                errorProvider.SetError(HoraEntradaSV, "Seleccione una opcion");
            }
            else
            {

                errorProvider.SetError(HorasDiariasSV, null);
                errorProvider.SetError(HoraEntradaSV, null);
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

        private void ActividadesNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ActividadesNR.Text))
            {


                errorProvider.SetError(ActividadesNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(ActividadesNR, null);
            }
        }

        private void ProyectoNR_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ProyectoNR.Text))
            {


                errorProvider.SetError(ProyectoNR, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(ProyectoNR, null);
            }
        }

        private void HoraEntradaSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HoraEntradaNR.Text))
            {


                errorProvider.SetError(HoraEntradaSV, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(HoraEntradaSV, null);
            }
        }

        private void HoraEntradaSV2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HoraEntradaNR2.Text))
            {


                errorProvider.SetError(HoraEntradaSV2, "Campo Obligatorio");

            }
            else
            {

                errorProvider.SetError(HoraEntradaSV2, null);
            }
        }
        private void PanelProgramaNR_Click(object sender, EventArgs e)
        {
            panelProgramaNR.Focus();
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
                            diaslab += 1;
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

        private void BtnGuardarProgramaNR_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Validar() == false)
                {
                    MessageBox.Show("Datos Incompletos");

                }
                else
                {
                    using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                    {
                        var a = context.Programa.SingleOrDefault(n => n.ID_Programa == this.ID_programa);
                        if (a != null)
                        {
                            a.Nombre_Programa = TextBoxPrograma.Text.Trim();
                            a.Horas_Diarias =Int32.Parse(HorasDiariasNR.Text);
                            a.Horas_Totales= Int32.Parse(HorasTotalesNR.Text);
                            a.Fecha_Inicio = FechaInicioNR.Value;
                            a.Fecha_Final = FechaTermNR.Value;
                            a.Hora_Inicio = HoraEntradaNR.Text + ":" + HoraEntradaNR2.Text;
                            a.Hora_Termino = HoraSalidaNR.Text + ":" + HoraSalidaNR2.Text;
                            a.Actividades = ActividadesNR.Text.Trim();
                            a.Nombre_Proyecto = ProyectoNR.Text.Trim();
                            context.SaveChanges();
                        }
                    }
                    Cargar();
                    MessageBox.Show("Datos cambiados con éxito");

                }

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
