using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias

{
    public class ReportesEntregadoscls
    {
        public int ID { get; set; }

        public string FolioAcept { get; set; }
        public string Nombre { get; set; }

        public string MesEntregado { get; set; }
        public DateTime FechaDT
        {
            get { return this.fechadt; }
            set
            {
                fechadt = value;
                string dia = fechadt.Day.ToString();
                string mes = fechadt.ToString("MMMM");
                string anio = fechadt.Year.ToString();
                fecha_ = dia + " de " + mes + " de " + anio;
            }
        }
        private DateTime fechadt;

        public string Fecha { get { return fecha_; } }
        private string fecha_;

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
    public class CredencialesDisponiblescls
    {
        public int ID { get; set; }

        public string FolioCredencial { get; set; }

        public string Nombre { get; set; }

        public string FechaSolicitud { get; set; }

        public string FechaDisponible { get; set; }



    }

    public class CartasAceptacionDispliblescls
    {
        public int ID { get; set; }

        public string FolioCarta { get; set; }

        public string Nombre { get; set; }

        public string FechaSolicitud { get; set; }

        public string FechaDisponible { get; set; }



    }
    public class CartasTerminacionDispliblescls
    {
        public int ID { get; set; }

        public string FolioCarta { get; set; }

        public string Nombre { get; set; }

        public string FechaSolicitud { get; set; }

        public string FechaDisponible { get; set; }



    }

    public class FoliosSolicitadoscls
    {
        public int ID { get; set; }

        public string FolioCarta { get; set; }

        public string Nombre { get; set; }

        public string FechaSolicitud { get; set; }

    }
    public class Cursocls
    {
        public int ID { get; set; }

        public string FolioAceptacion { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }

        public string FechaProgramado { get; set; }
         
    }

    public class Reportescls
    {
        public int ID { get; set; }

        public string FolioAceptacion { get; set; }
        public string Nombre { get; set; }

        public int CantidadReportes { get; set; }
        public string Telefono{ get; set; }
        public string Extension { get; set; }
        public string Correo { get; set; }


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
        public DateTime FechaInicioDT
        {
            get { return this.fechainiciodt; }
            set
            {
                fechainiciodt = value;
                string dia = fechainiciodt.Day.ToString();
                string mes = fechainiciodt.ToString("MMMM");
                string anio = fechainiciodt.Year.ToString();
                fechainicio_ = dia + " de " + mes + " de " + anio;
            }
        }
        private DateTime fechainiciodt;

        public string FechaInicio { get { return fechainicio_; } }
        private string fechainicio_;

        public DateTime FechaTerminoDT
        {
            get { return this.fechaterminodt; }
            set
            {
                fechaterminodt = value;
                string dia = fechaterminodt.Day.ToString();
                string mes = fechaterminodt.ToString("MMMM");
                string anio = fechaterminodt.Year.ToString();
                fechatermino_ = dia + " de " + mes + " de " + anio;
            }
        }
        private DateTime fechaterminodt;
        public string FechaTermino { get { return fechatermino_; } }
        private string fechatermino_;

        

    }
}
