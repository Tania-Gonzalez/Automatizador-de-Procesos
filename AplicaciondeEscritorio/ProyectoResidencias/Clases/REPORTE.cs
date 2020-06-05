using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias.Clases
{

    public class Base
    {

        public int ID { get; set; }
        public string FolioAcept { get; set; }
        public string FolioCred { get; set; }
        public string FolioTerm { get; set; }
        public string Nombre { get; set; }
        public string Programa { get; set; }
        public string Carrera { get; set; }
        public string Escuela { get; set; }
        public string Area { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaEntrada
        {
            get { return this.fechadt; }
            set
            {
                fechadt = value;
                _MesEntradaString = fechadt.ToString("MMMM");

            }
        }
        private DateTime fechadt;


        public string MesEntradaString
        {
            get { return this._MesEntradaString.ToUpper(); }

        }
        private string _MesEntradaString;



        public DateTime FechaTermino
        {
            get { return this.fechatermino; }
            set
            {
                fechatermino = value;
                _MesTerminoString = fechatermino.ToString("MMMM");

            }
        }
        private DateTime fechatermino;

        public string MesTerminoString
        {
            get { return this._MesTerminoString; }

        }
        private string _MesTerminoString;


        public string Asesor { get; set; }
        public string Extension { get; set; }
        public string Correo { get; set; }
        public string DuracionServicio { get; set; }
        public string Celular { get; set; }

        public string Edad { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }

        public string Genero { get; set; }

        public int Duracion { get; set; }


        public string Estado_Del_Curso
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


        public string Estado
        {

            set
            {
                this.estado = value;
                if (this.estado == "False") { this.estado = "Baja"; }
                if (this.estado == "True") { this.estado = "Activo"; }
            }
            get { return this.estado; }


        }

        private string estado;

    }

    public class ReportesEnt
    {
            public int ID { get; set; }
            public string FolioAcept { get; set; }
            public string Nombre { get; set; }

            public DateTime FechaInicio { get; set; }
            public DateTime FechaTermino { get; set; }
            public string MesEntregado { get; set; }


    }



    public class LstReportes
    {
            public int ID { get; set; }
            public int ID_Avance { get; set; }
            public DateTime FechaEntrega { get; set; }
            public string Mes_Entrega { get; set; }
    }
    public class IDS
    {
            public int ID { get; set; }
    }


    
}


