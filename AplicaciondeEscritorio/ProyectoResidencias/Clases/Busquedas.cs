using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias
{
    public class Buscador
    {
        public int ID { get; set; }
        [DisplayName("Folio")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido Paterno")]
        public string Apellido_Paterno { get; set; }
        [DisplayName("Apellido Materno")]
        public string Apellido_Materno { get; set; }
        [DisplayName("Escuela")]
        public string Escuela { get; set; }
        [DisplayName("Estado")]

        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;



    }

    public class CargarBusqueda
    {
        public int? ID { get; set; }

        public int? Folio { get; set; }
        public string TipoPrograma { get; set; }

        public string NombreCompleto { get; set; }

        public string Escuela { get; set; }

        public string NombreCarrera { get; set; }

        public string Matricula { get; set; }

        public string Curso
        {
            set
            {
                this.curso = value;
                if (this.curso == "2") { this.curso = "Tomado"; }
                if (this.curso == "1") { this.curso = "Programado"; }
                if (this.curso == "0") { this.curso = "Sin Programar"; }


            }
            get { return this.curso; }
        }
        private string curso;

        public int? ID_DatosPersonales { get; set; }
        public int? ID_DatosEscolares { get; set; }
        public int? ID_Area { get; set; }
        public int? ID_Expediente { get; set; }
        public int? ID_Programa { get; set; }



    }
    public class SolicitudFolio
    {
        public int ID { get; set; }
        [DisplayName("Folio")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Solicitud Folio Aceptacion")]
        public string SolAcept
        {
            set
            {
                this.solacept = value;
                if (this.solacept == "False") { this.solacept = "Sin Solicitar"; }
                if (this.solacept == "True") { this.solacept = "Solicitado"; }
            }
            get { return this.solacept; }
        }

        [DisplayName("Solicitud Folio Terminacion")]
        public string SolTermn
        {
            set
            {
                this.soltermn = value;
                if (this.soltermn == "False") { this.soltermn = "Sin Solicitar"; }
                if (this.soltermn == "True") { this.soltermn = "Solicitado"; }
            }
            get { return this.soltermn; }
        }
        [DisplayName("Estado")]
        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;
        private string solacept;
        private string soltermn;

    }

    public class BusquedaCurso
    {
        public int ID { get; set; }
        [DisplayName("Folio")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Curso")]
        public string Curso
        {
            set
            {
                this.curso = value;
                if (this.curso == "2") { this.curso= "Tomado"; }
                if (this.curso == "0") { this.curso= "Sin Programar"; }
                if (this.curso == "1") { this.curso = "Programado"; }

            }
            get { return this.curso; }
        }

        
        [DisplayName("Estado")]
        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;
        private string curso;
    }
    public class SolicitudFolioAceptacionList
    {
        
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Numero")]
        public string Numero { get; set; }
        [DisplayName("Asunto")]
        public string Asunto { get; set; }
        [DisplayName("Dirigido A:")]
        public string Destinatario { get; set; }
        
    }

    public class Curso_Prog_Induccion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Asesor { get; set; }
        public string Correo { get; set; }
    }


    public class CartaAceptaciondtg
    {
        public int ID { get; set; }
        [DisplayName("Folio Aceptacion")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Escuela")]
        public string Escuela { get; set; }
        [DisplayName("Estado")]

        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;



    }
    public class CartaTerminaciondtg
    {
        public int ID { get; set; }
        [DisplayName("Folio Terminacion")]
        public string FolioTer { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Escuela")]
        public string Escuela { get; set; }
        [DisplayName("Estado")]

        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;



    }
    public class SolicitudEtiqueta
    {
        public int ID { get; set; }
        [DisplayName("Folio Aceptacion")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Etiqueta")]
        public string Etiqueta
        {
            set
            {
                this.etiqueta_ = value;
                if (this.etiqueta_ == "False") { this.etiqueta_ = "Sin Generar"; }
                if (this.etiqueta_== "True") { this.etiqueta_= "Generada"; }
            }
            get { return this.etiqueta_; }
        }

      
        [DisplayName("Estado")]
        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;
        private string etiqueta_;
 

    }
    public class GeneradorCredenciales
    {
        public int ID { get; set; }
        [DisplayName("Folio Aceptacion")]
        public string FolioAcept { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Credencial")]
        public string Credencial
        {
            set
            {
                this.credencial_ = value;
                if (this.credencial_ == "False") { this.credencial_ = "Sin Recibir"; }
                if (this.credencial_ == "True") { this.credencial_ = "Recibida"; }
            }
            get { return this.credencial_; }
        }


        [DisplayName("Estado")]
        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Inactivo"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }
        private string estado;
        private string credencial_;
    }
    public class CargarDatosProceso
    {
        public string Curso
        {
            set
            {
                this.curso = value;
                if (this.curso == "2") { this.curso = "Tomado"; }
                if (this.curso == "1") { this.curso = "Programado"; }
                if (this.curso == "0") { this.curso = "Sin Programar"; }


            }
            get { return this.curso; }
        }
        public string Credencial
        {
            set
            {
                this.credencial_ = value;
                if (this.credencial_ == "False") { this.credencial_ = "Sin Recibir"; }
                if (this.credencial_ == "True") { this.credencial_ = "Recibida"; }
            }
            get { return this.credencial_; }
        }
        public string SolAcept
        {
            set
            {
                this.solacept = value;
                if (this.solacept == "False") { this.solacept = "Sin Entregar"; ; }
                if (this.solacept == "True") { this.solacept = "Entregada"; }
            }
            get { return this.solacept; }
        }


        public string SolTermn
        {
            set
            {
                this.soltermn = value;
                if (this.soltermn == "False") { this.soltermn = "Sin Entregar"; }
                if (this.soltermn == "True") { this.soltermn = "Entregada"; }
            }
            get { return this.soltermn; }
        }
        public string TerminacionArea
        {

            set
            {
                this.terma_ = value;
                if (this.terma_ == "False") { this.terma_ = "Sin Entregar"; }
                if (this.terma_ == "True") { this.terma_ = "Entregada"; }
            }
            get { return this.terma_; }


        }
        public string Reportes
        {
            set
            {
                this.reportes_ = value;
                if (this.reportes_ == "0") { this.reportes_ = "Sin Entregar"; }

            }
            get { return this.reportes_; }
        }

        private string reportes_;
        private string terma_;
        private string solacept;
        private string soltermn;

        private string curso;
        private string credencial_;


    }


}
