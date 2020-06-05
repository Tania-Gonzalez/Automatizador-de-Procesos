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
    public partial class ConsultasEstablecidas : UserControl
    {
        private string cadenaconexion;
        public ConsultasEstablecidas()
        {
            InitializeComponent();
        }

        public void setCD(string t)
        {
            cadenaconexion = t;
            CargarReportes();


        }

        private void CargarReportes()
        {
            reportesUC1.setCD(cadenaconexion);
        }

        private void btnCredencialesDisponibles_Click(object sender, EventArgs e)
        {
            credencialesDisponibles1.BringToFront();
            credencialesDisponibles1.setCD(cadenaconexion);
        }

        private void btnCartasDisponibles_Click(object sender, EventArgs e)
        {
            cartasDisponiblesUC1.BringToFront();
            cartasDisponiblesUC1.setCD(cadenaconexion);
        }

        private void btnCredencialesSolicitadas_Click(object sender, EventArgs e)
        {
            credencialesSolicitadasUC1.BringToFront();
            credencialesSolicitadasUC1.setCD(cadenaconexion);
        }

        private void btnCartasSolicitadas_Click(object sender, EventArgs e)
        {
            cartasSolicitadasUC1.BringToFront();
            cartasSolicitadasUC1.setCD(cadenaconexion);
        }

        private void btnFoliosSolicitados_Click(object sender, EventArgs e)
        {
            foliosSolicitadosUC1.BringToFront();
            foliosSolicitadosUC1.setCD(cadenaconexion);
        }

        private void btnCursoInduccion_Click(object sender, EventArgs e)
        {
            cursoInduccionUC1.BringToFront();
            cursoInduccionUC1.setCD(cadenaconexion);
        }

        private void btnReportesPendientes_Click(object sender, EventArgs e)
        {
            reportesUC1.BringToFront();
            reportesUC1.setCD(cadenaconexion);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
          
        }
    }
}

