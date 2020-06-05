using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{

    public partial class Principal : Form
    {



        #region Variables
        public bool activo = false;
        private string conexion;
      




        private bool Opcion1Colapsada;
        private bool Opcion2Colapsada;
        private bool Opcion3Colapsada;
        private bool Opcion4Colapsada;
       //private bool Opcion5Colapsada;
        #endregion


        #region BarraTitulo
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Constructores
        public Principal()
        {
            InitializeComponent();
            Inicio inicio = new Inicio();
        

            nuevoRegistro1.Booleano += NuevoRegistro1_Booleano;
            nuevoRegistro1.Oprimido += NuevoRegistro1_Oprimido;
            busquedaPrincipal1.Booleano += BusquedaPrincipal1_Booleano;
            busquedaPrincipal1.Oprimido += BusquedaPrincipal1_Oprimido;
            registroProcesoPrincipal1.Booleano += RegistroProcesoPrincipal1_Booleano;
            registroProcesoPrincipal1.Oprimido += RegistroProcesoPrincipal1_Oprimido;
            registroFolio1.Booleano += RegistroFolio1_Booleano;
            registroFolio1.Oprimido += RegistroFolio1_Oprimido;
            bajaPrincipal1.Booleano += BajaPrincipal1_Booleano;
            bajaPrincipal1.Oprimido += BajaPrincipal1_Oprimido;
            registroEstadoDocumento1.Booleano += RegistroEstadoDocumento1_Booleano;
            registroEstadoDocumento1.Oprimido += RegistroEstadoDocumento1_Oprimido;
            solicitarFolio1.Oprimido += SolicitarFolio1_Oprimido;
            solicitarFolio1.Booleano += SolicitarFolio1_Booleano;
            programarCurso1.Oprimido += ProgramarCurso1_Oprimido;
            programarCurso1.Booleano += ProgramarCurso1_Booleano;
            registrarAsistencia1.Oprimido += RegistrarAsistencia1_Oprimido;
            registrarAsistencia1.Booleano += RegistrarAsistencia1_Booleano;
            ucCartaAceptacion1.Oprimido += CartaAceptacion1_Oprimido;
            ucCartaAceptacion1.Booleano += CartaAceptacion1_Booleano;
            ucCartaTerminacion1.Oprimido += UcCartaTerminacion1_Oprimido;
            ucCartaTerminacion1.Booleano += UcCartaTerminacion1_Booleano;
            ucGeneradorEtiquetas1.Oprimido += UcGeneradorEtiquetas1_Oprimido;
            ucGeneradorEtiquetas1.Booleano += UcGeneradorEtiquetas1_Booleano;
            ucGeneradorCredenciales1.Oprimido += UcGeneradorCredenciales1_Oprimido;
            ucGeneradorCredenciales1.Booleano += UcGeneradorCredenciales1_Booleano;


            inicio.Cadena += Inicio_Cadena;
            
          
            inicio.ShowDialog();
                
        }
        

        private void UcGeneradorCredenciales1_Booleano(bool t)
        {
            Activar(t);
        }

        private void UcGeneradorCredenciales1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion3.Size != PanelOpcion3.MinimumSize)
            {
                BotonOpc3_Click(sender, e);

            }
        }

        private void UcGeneradorEtiquetas1_Booleano(bool t)
        {
            Activar(t);
        }

        private void UcGeneradorEtiquetas1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion3.Size != PanelOpcion3.MinimumSize)
            {
                BotonOpc3_Click(sender, e);

            }
        }

        private void UcCartaTerminacion1_Booleano(bool t)
        {
            Activar(t);
        }

        private void UcCartaTerminacion1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion3.Size != PanelOpcion3.MinimumSize)
            {
                BotonOpc3_Click(sender, e);

            }
        }

        private void CartaAceptacion1_Booleano(bool t)
        {
            Activar(t);
        }

        private void CartaAceptacion1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion3.Size != PanelOpcion3.MinimumSize)
            {
                BotonOpc3_Click(sender, e);

            }
        }

        private void RegistrarAsistencia1_Booleano(bool t)
        {
            Activar(t);
        }

        private void RegistrarAsistencia1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion4.Size != PanelOpcion4.MinimumSize)
            {
                BotonOpc4_Click(sender, e);

            }
        }

        private void ProgramarCurso1_Booleano(bool t)
        {
            Activar(t);
        }

        private void ProgramarCurso1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion4.Size != PanelOpcion4.MinimumSize)
            {
                BotonOpc4_Click(sender, e);

            }
        }

        private void SolicitarFolio1_Booleano(bool t)
        {
            Activar(t);
        }

        private void SolicitarFolio1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion3.Size != PanelOpcion3.MinimumSize)
            {
                BotonOpc3_Click(sender, e);

            }
        }

        private void RegistroEstadoDocumento1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion1.Size != PanelOpcion1.MinimumSize)
            {
                BotonOpc1_Click(sender, e);

            }
        }

        private void RegistroEstadoDocumento1_Booleano(bool t)
        {
            Activar(t);
        }

        private void BajaPrincipal1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion1.Size != PanelOpcion1.MinimumSize)
            {
                BotonOpc1_Click(sender, e);

            }
        }

        private void BajaPrincipal1_Booleano(bool t)
        {
            Activar(t);
        }

        private void RegistroFolio1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion1.Size != PanelOpcion1.MinimumSize)
            {
                BotonOpc1_Click(sender, e);

            }
        }

        private void RegistroFolio1_Booleano(bool t)
        {
            Activar(t);
        }

        private void RegistroProcesoPrincipal1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion1.Size != PanelOpcion1.MinimumSize)
            {
                BotonOpc1_Click(sender, e);

            }
        }

        private void RegistroProcesoPrincipal1_Booleano(bool t)
        {
            Activar(t);
        }

        private void BusquedaPrincipal1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion2.Size != PanelOpcion2.MinimumSize)
            {
                BotonOpc2_Click(sender, e);

            }
        }

        private void BusquedaPrincipal1_Booleano(bool t)
        {
            Activar(t);
        }

        private void Inicio_Cadena(string t)
        {
            conexion = t;
            bienvenida1.Carga(t);
           
        }

        private void NuevoRegistro1_Oprimido(object sender, EventArgs e)
        {
            if (PanelOpcion1.Size!=PanelOpcion1.MinimumSize)
            {
                BotonOpc1_Click(sender,e);

            }
            
        }

        private void NuevoRegistro1_Booleano(bool t)
        {
            Activar(t);
        }

        /*
        public Principal(bool valor)
        {
            this.activo = valor;

        }
        */
        #endregion
       
        
     

        #region Botones BarraTitulo
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotonCerrar_MouseHover(object sender, EventArgs e)
        {
            BotonCerrar.Image = ProyectoResidencias.Properties.Resources.IconoCerrarVentanaLleno;
        }

        private void BotonCerrar_MouseLeave(object sender, EventArgs e)
        {
           BotonCerrar.Image = ProyectoResidencias.Properties.Resources.IconoCerrarVentana1;
        }

        private void BotonMinimizar_MouseHover(object sender, EventArgs e)
        {
            BotonMinimizar.Image = ProyectoResidencias.Properties.Resources.IconoMinimizarVentanaLlena;
        }

        private void BotonMinimizar_MouseLeave(object sender, EventArgs e)
        {
            BotonMinimizar.Image = ProyectoResidencias.Properties.Resources.IconoMinimizarVentana3;
        }
              
        private void BarraControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public void Activar(bool b)
        {
            activo = b;
            if (b == true)
            {
                Btn1_1.Enabled = false;
                Btn1_2.Enabled = false;
                Btn1_3.Enabled = false;
                Btn2_1.Enabled = false;
                Btn2_3.Enabled = false;
                Btn3_1.Enabled = false;
                Btn3_2.Enabled = false;
                Btn3_3.Enabled = false;
                Btn3_4.Enabled = false;
                Btn4_1.Enabled = false;
                Btn4_2.Enabled = false;
            }
            else
            {
                Btn1_1.Enabled = true;
                Btn1_2.Enabled = true;
                Btn1_3.Enabled = true;
                Btn2_1.Enabled = true;

                Btn2_3.Enabled = true;
                Btn3_1.Enabled = true;
                Btn3_2.Enabled = true;
                Btn3_3.Enabled = true;
                Btn3_4.Enabled = true;
                Btn4_1.Enabled = true;
                Btn4_2.Enabled = true;
            }
            
        }

        #region BloqueBotonesDesplegables
        #region MetodoComparativoBotonesDesplegables
        public void BotonClickeado(int num)
        {
          
            if (num!=0) {
                switch (num)
                {
                    case 1:
                        //Opcion5Colapsada = false;
                        Opcion4Colapsada = false;
                        Opcion3Colapsada = false;
                        Opcion1Colapsada = false;
                        Opcion2Colapsada = false;
                        TimerOpcion1.Start();
                        TimerOpcion3.Start();
                        TimerOpcion2.Start();
                        TimerOpcion4.Start();
                        TimerOpcion5.Start();
                        bienvenida1.BringToFront();
                        break;
                    case 2:
                        //Opcion5Colapsada = false;
                        Opcion4Colapsada = false;
                        Opcion3Colapsada = false;
                        Opcion2Colapsada = false;
                        TimerOpcion5.Start();
                        TimerOpcion4.Start();
                        TimerOpcion3.Start();
                        TimerOpcion2.Start();
                        TimerOpcion1.Start();
                        break;
                    case 3:
                        Opcion1Colapsada = false;
                        Opcion3Colapsada = false;
                        Opcion4Colapsada = false;
                        //Opcion5Colapsada = false;
                        TimerOpcion5.Start();
                        TimerOpcion4.Start();
                        TimerOpcion3.Start();
                        TimerOpcion1.Start();
                        TimerOpcion2.Start();
                        break;
                    case 4:
                        //Opcion5Colapsada = false;
                        Opcion4Colapsada = false;
                        Opcion1Colapsada = false;
                        Opcion2Colapsada = false;
                        TimerOpcion1.Start();
                        TimerOpcion2.Start();
                        TimerOpcion4.Start();
                        TimerOpcion5.Start();
                        TimerOpcion3.Start();
                        break;
                    case 5:
                        //Opcion5Colapsada = false;
                        Opcion3Colapsada = false;
                        Opcion1Colapsada = false;
                        Opcion2Colapsada = false;
                        TimerOpcion1.Start();
                        TimerOpcion2.Start();
                        TimerOpcion3.Start();
                        TimerOpcion5.Start();
                        TimerOpcion4.Start();
                        break;
                    case 6:
                        Opcion4Colapsada = false;
                        Opcion3Colapsada = false;
                        Opcion1Colapsada = false;
                        Opcion2Colapsada = false;
                        TimerOpcion1.Start();
                        TimerOpcion2.Start();
                        TimerOpcion3.Start();                       
                        TimerOpcion4.Start();
                        TimerOpcion5.Start();
                        break;


                }

            }

        }
        #endregion
        #region Timers
        private void TimerOpcion1_Tick(object sender, EventArgs e)
        {
            if (Opcion1Colapsada == true)
            {
                BotonOpc1.Image = ProyectoResidencias.Properties.Resources.IconoArriba;
                PanelOpcion1.Height += 10;
                if (PanelOpcion1.Size == PanelOpcion1.MaximumSize)
                {
                    TimerOpcion1.Stop();
                    Opcion1Colapsada = false;
                }
            }

            else
            {
                BotonOpc1.Image = ProyectoResidencias.Properties.Resources.IconoAbajo;
                PanelOpcion1.Height -= 10;
                if (PanelOpcion1.Size == PanelOpcion1.MinimumSize)
                {
                    TimerOpcion1.Stop();
                    Opcion1Colapsada = true;

                }
            }
        }        

        private void TimerOpcion2_Tick(object sender, EventArgs e)
        {
            if (Opcion2Colapsada == true)
            {
                BotonOpc2.Image = ProyectoResidencias.Properties.Resources.IconoArriba;
                PanelOpcion2.Height += 10;
                if (PanelOpcion2.Size == PanelOpcion2.MaximumSize)
                {
                    TimerOpcion2.Stop();
                    Opcion2Colapsada = false;
                }
            }

            else
            {
                BotonOpc2.Image = ProyectoResidencias.Properties.Resources.IconoAbajo;
                PanelOpcion2.Height -= 10;
                if (PanelOpcion2.Size == PanelOpcion2.MinimumSize)
                {
                    TimerOpcion2.Stop();
                    Opcion2Colapsada = true;

                }
            }
        }

        private void TimerOpcion3_Tick(object sender, EventArgs e)
        {
            if (Opcion3Colapsada == true)
            {
                BotonOpc3.Image = ProyectoResidencias.Properties.Resources.IconoArriba;
                PanelOpcion3.Height += 10;
                if (PanelOpcion3.Size == PanelOpcion3.MaximumSize)
                {
                    TimerOpcion3.Stop();
                    Opcion3Colapsada = false;
                }
            }

            else
            {
                BotonOpc3.Image = ProyectoResidencias.Properties.Resources.IconoAbajo;
                PanelOpcion3.Height -= 10;
                if (PanelOpcion3.Size == PanelOpcion3.MinimumSize)
                {
                    TimerOpcion3.Stop();
                    Opcion3Colapsada = true;

                }
            }
        }

        private void TimerOpcion4_Tick(object sender, EventArgs e)
        {
            if (Opcion4Colapsada == true)
            {
                BotonOpc4.Image = ProyectoResidencias.Properties.Resources.IconoArriba;
                PanelOpcion4.Height += 10;
                if (PanelOpcion4.Size == PanelOpcion4.MaximumSize)
                {
                    TimerOpcion4.Stop();
                    Opcion4Colapsada = false;
                }
            }

            else
            {
                BotonOpc4.Image = ProyectoResidencias.Properties.Resources.IconoAbajo;
                PanelOpcion4.Height -= 10;
                if (PanelOpcion4.Size == PanelOpcion4.MinimumSize)
                {
                    TimerOpcion4.Stop();
                    Opcion4Colapsada = true;

                }
            }
        }
        /*
        private void TimerOpcion5_Tick(object sender, EventArgs e)
        {
            if (Opcion5Colapsada == true)
            {
                BotonOpc5.Image = ProyectoResidencias.Properties.Resources.IconoArriba;
                PanelOpcion5.Height += 10;
                if (PanelOpcion5.Size == PanelOpcion5.MaximumSize)
                {
                    TimerOpcion5.Stop();
                    Opcion5Colapsada = false;
                }
            }

            else
            {
                BotonOpc5.Image = ProyectoResidencias.Properties.Resources.IconoAbajo;
                PanelOpcion5.Height -= 10;
                if (PanelOpcion5.Size == PanelOpcion5.MinimumSize)
                {
                    TimerOpcion5.Stop();
                    Opcion5Colapsada = true;

                }
            }
        }*/

        #endregion
        #region BotonesDesplegables
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            bienvenida1.SetCD(conexion);
            bienvenida1.Carga(conexion);


            if (activo==false) {     BotonClickeado(1);



            }
           
           
        }

        public void BotonOpc1_Click(object sender, EventArgs e)
        {
            if (activo == false) { BotonClickeado(2); }
         

        }
        private void BotonOpc2_Click(object sender, EventArgs e)
        {
            if (activo == false)
            {
                BotonClickeado(3);
            }
      

        }

     

        private void BotonOpc3_Click(object sender, EventArgs e)
        {
            if (activo == false)
            {
                BotonClickeado(4);
            }
            
        }
     
        private void BotonOpc4_Click(object sender, EventArgs e)
        {
            if (activo == false)
            {
                BotonClickeado(5);
            }
         
        }
               

        private void BotonOpc5_Click(object sender, EventArgs e)
        {
            if (activo == false)
            {
                BotonClickeado(6);
            }
        }

        #endregion
        #endregion


        #region BotonesOpciones
        private void Btn1_1_Click(object sender, EventArgs e)
        {         
                nuevoRegistro1.BringToFront();
                nuevoRegistro1.setCD(conexion);
            
         
        }

        private void Btn1_2_Click(object sender, EventArgs e)
        {
            registroProcesoPrincipal1.BringToFront();
            registroProcesoPrincipal1.setCD(conexion);
        }

        private void Btn1_3_Click(object sender, EventArgs e)
        {
            registroFolio1.BringToFront();
            registroFolio1.setCD(conexion);
        }
        private void Btn1_4_Click(object sender, EventArgs e)
        {
            registroEstadoDocumento1.BringToFront();
            registroEstadoDocumento1.setCD(conexion);

        }
        private void Btn1_5_Click(object sender, EventArgs e)
        {
            bajaPrincipal1.BringToFront();
            bajaPrincipal1.setCD(conexion);
        }

        private void Btn2_1_Click(object sender, EventArgs e)
        {
            busquedaPrincipal1.BringToFront();
            busquedaPrincipal1.setCD(conexion);
            
        }

        private void Btn2_2_Click(object sender, EventArgs e)
        {

        }

        private void Btn2_3_Click(object sender, EventArgs e)
        {
            consultasEstablecidas1.BringToFront();
            consultasEstablecidas1.setCD(conexion);
        }

        private void Btn3_1_Click(object sender, EventArgs e)
        {
            ucCartaAceptacion1.BringToFront();
            ucCartaAceptacion1.setCD(conexion);
        }
        private void Btn3_1_2_Click(object sender, EventArgs e)
        {
            ucCartaTerminacion1.BringToFront();
            ucCartaTerminacion1.setCD(conexion);
        }
        private void Btn3_2_Click(object sender, EventArgs e)
        {
            calculadoraPeriodos1.BringToFront();
            calculadoraPeriodos1.setCD(conexion);
        }

        private void Btn3_3_Click(object sender, EventArgs e)
        {
            ucGeneradorCredenciales1.BringToFront();
            ucGeneradorCredenciales1.setCD(conexion);
        }

        private void Btn3_4_Click(object sender, EventArgs e)
        {
            ucGeneradorEtiquetas1.BringToFront();
            ucGeneradorEtiquetas1.setCD(conexion);
        }
        private void Btn3_5_Click(object sender, EventArgs e)
        {
            solicitarFolio1.BringToFront();
            solicitarFolio1.setCD(conexion);
        }

        private void Btn4_1_Click(object sender, EventArgs e)
        {
            programarCurso1.BringToFront();
            programarCurso1.setCD(conexion);

        }

        private void Btn4_2_Click(object sender, EventArgs e)
        {
            registrarAsistencia1.BringToFront();
            registrarAsistencia1.setCD(conexion);

        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            using (var Llamar = new Forms.GenerarReporte.GenerarReporteBD(conexion))
            {
                Llamar.ShowDialog();
            }
        }
    }
}
