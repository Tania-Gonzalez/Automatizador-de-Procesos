using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CASES.Controles_de_Usuario
{
    public partial class BuscarAlumno : UserControl
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        public void OcultarPanelBuscarAlumno() {
            panelPrograma.Visible = false;
            btnPrograma.BackColor = Color.Gainsboro;
            btnPrograma.ForeColor = Color.DarkSlateGray;
            panelDocumentos.Visible = false;
            btnDocumentos.BackColor = Color.Gainsboro;
            btnDocumentos.ForeColor = Color.DarkSlateGray;
            PanelDatosPersonales.Visible = false;
            btnDatosPersonales.BackColor = Color.Gainsboro;
            btnDatosPersonales.ForeColor = Color.DarkSlateGray;
            panelDireccion.Visible = false;
            btnDireccion.BackColor = Color.Gainsboro;
            btnDireccion.ForeColor = Color.DarkSlateGray;
            panelTutor.Visible = false;
            btnTutor.BackColor = Color.Gainsboro;
            btnTutor.ForeColor = Color.DarkSlateGray;
            panelDatosEscolares.Visible = false;
            btnDatosEscolares.BackColor = Color.Gainsboro;
            btnDatosEscolares.ForeColor = Color.DarkSlateGray;
            panelAsesorTecnico.Visible = false;
            btnAsesor.BackColor = Color.Gainsboro;
            btnAsesor.ForeColor = Color.DarkSlateGray;
            panelArea.Visible = false;
            btnArea.BackColor = Color.Gainsboro;
            btnArea.ForeColor = Color.DarkSlateGray;

            panelCartadeAceptacion.Visible = false;
            pictureBoxAceptacion.BackColor = Color.White;
            panelCursodeInduccion.Visible = false;
            pictureBoxCursoInduccion.BackColor = Color.White;
            panelCredencial.Visible = false;
            pictureBoxCredencial.BackColor = Color.White;
            panelReportes.Visible = false;
            pictureBoxReportes.BackColor = Color.White;
            panelTerminaciondelArea.Visible = false;
            pictureBoxTerminacionArea.BackColor = Color.White;
            panelCartadeTerminacion.Visible = false;
            pictureBoxCartaTerminacion.BackColor = Color.White;

        }

        private void BtnPrograma_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelPrograma.Visible = true;
            panelProceso.Location = new Point(4, 3);
            btnPrograma.BackColor = Color.SteelBlue;
            btnPrograma.ForeColor = Color.White;
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelDocumentos.Visible = true;
            panelDocumentos.Location = new Point(4, 3);
            btnDocumentos.BackColor = Color.SteelBlue;
            btnDocumentos.ForeColor = Color.White;
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelArea.Visible = true;
            panelArea.Location = new Point(4, 3);
            btnArea.BackColor = Color.SteelBlue;
            btnArea.ForeColor = Color.White;
        }
            private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            PanelDatosPersonales.Visible = true;
            PanelDatosPersonales.Location = new Point(4, 3);
            btnDatosPersonales.BackColor = Color.SteelBlue;
            btnDatosPersonales.ForeColor = Color.White;
        }

        private void BtnDireccion_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelDireccion.Visible = true;
            panelDireccion.Location = new Point(4, 3);
            btnDireccion.BackColor = Color.SteelBlue;
            btnDireccion.ForeColor = Color.White;
        }

        private void BtnTutor_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelTutor.Visible = true;
            panelTutor.Location = new Point(4, 3);
            btnTutor.BackColor = Color.SteelBlue;
            btnTutor.ForeColor = Color.White;
        }

        private void BtnDatosEscolares_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelDatosEscolares.Visible = true;
            panelDatosEscolares.Location = new Point(4, 3);
            btnDatosEscolares.BackColor = Color.SteelBlue;
            btnDatosEscolares.ForeColor = Color.White;
        }

        private void BtnAsesor_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelAsesorTecnico.Visible = true;
            panelAsesorTecnico.Location = new Point(4, 3);
            btnAsesor.BackColor = Color.SteelBlue;
            btnAsesor.ForeColor = Color.White;

        }
        private void PictureBoxAceptacion_Click_1(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelCartadeAceptacion.Visible = true;
            panelCartadeAceptacion.Location = new Point(4, 3);
            pictureBoxAceptacion.BackColor = Color.SteelBlue;
        }

        private void PictureBoxCursoInduccion_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelCursodeInduccion.Visible = true;
            panelCursodeInduccion.Location = new Point(4, 3);
            pictureBoxCursoInduccion.BackColor = Color.SteelBlue;
        }

        private void PictureBoxReportes_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelReportes.Visible = true;
            panelReportes.Location = new Point(4, 3);
            pictureBoxReportes.BackColor = Color.SteelBlue;
        }

        private void PictureBoxTerminacionArea_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelTerminaciondelArea.Visible = true;
            panelTerminaciondelArea.Location = new Point(4, 3);
            pictureBoxTerminacionArea.BackColor = Color.SteelBlue;
        }

        private void PictureBoxCartaTerminacion_Click(object sender, EventArgs e)
        {
            
            OcultarPanelBuscarAlumno();
            panelCartadeTerminacion.Visible = true;
            panelCartadeTerminacion.Location = new Point(4, 3);
            pictureBoxCartaTerminacion.BackColor = Color.SteelBlue;

        }

       

        private void PictureBoxCredencial_Click(object sender, EventArgs e)
        {
            OcultarPanelBuscarAlumno();
            panelCredencial.Visible = true;
            panelCredencial.Location = new Point(4, 3);
            pictureBoxCredencial.BackColor = Color.SteelBlue;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FlowBuscarEstudiante.Visible = true;
        }


    }
}
