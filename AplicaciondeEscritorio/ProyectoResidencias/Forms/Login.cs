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
using System.Data.Sql;
using System.Data.Entity.Core.EntityClient;

namespace ProyectoResidencias
{
    public partial class Inicio : Form
    {
        #region ControlBarra
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Variables
        private int validador;
        private string servidor = "";
        private string cd;
        private Base_Servicio_PracticasEntities conexion;
        #endregion

        #region Delegados
        public delegate void CD(string t);
        public event CD Cadena;
        #endregion

        #region Constructor
        public Inicio()
        {
            InitializeComponent();
                       
        }
        #endregion

        #region MetodosApoyo
        private void CadenaConexion()
        {
            EntityConnectionStringBuilder ConexionEntity = new EntityConnectionStringBuilder();
            ConexionEntity.Provider = "System.Data.SqlClient";
            ConexionEntity.ProviderConnectionString = "data source=" + servidor + ";initial catalog=Base_Servicio_Practicas;" +
            "persist security info=True;user id=sa; password = Pemex2020;MultipleActiveResultSets=True;App=EntityFramework";
            ConexionEntity.Metadata = "res://*/EntityModel.csdl|res://*/EntityModel.ssdl|res://*/EntityModel.msl";
            cd = ConexionEntity.ToString();
            Base_Servicio_PracticasEntities conexion1 = new Base_Servicio_PracticasEntities(ConexionEntity.ToString());

            conexion = conexion1;

        }
        

        private void ObtenerNombreServidor()
        {
           
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
            {
                Servidor1.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            }
        }
        private void Validar()
        {
           validador= conexion.LoginUsuario(UsuarioText.Text, ContraseniaText.Text).Count();
        }

        private void BarraControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            ObtenerNombreServidor();

        }
        private void Servidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            servidor = Servidor1.SelectedItem.ToString(); 
        }


        #endregion

        #region Botones
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {

            if (Servidor1.Text == "" || UsuarioText.Text == "" || ContraseniaText.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                CadenaConexion();
                Validar();
                if (validador == 0)
                {
                    MessageBox.Show("Nombre de Servidor,Usuario o Contraseña Incorrectos");
                }
                else
                {
                    Cadena(cd);                   
                   
                    this.Close();
                  
                }
            
                   
                  
                   
                

            }


         }


        #endregion

        private void Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conectar.PerformClick();
            }
              
        }

    }
}
