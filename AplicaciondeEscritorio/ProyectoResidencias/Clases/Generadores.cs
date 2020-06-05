using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias
{

    public class EtiquetasCls

    {
        public int ID { get; set; }
        public string FolioAceptacion { get; set; }

        public string Programa { get; set; }

        public string Escuela
        {
            set
            {
                this.escuela_ = value; 
                if (!string.IsNullOrEmpty(escuela_))
                {
                    String[] Vector1 = escuela_.Split(' ');
                    String Palabra;
                    var articulos = new List<string> { "De", "Del", "La", "El", "Los", "Las", "Al" };
                    List<string> lista = new List<string>();
                    for (int i = 0; i < Vector1.Length; i++)

                    {
                        if (articulos.Contains(Vector1[i]))
                        {

                        }
                        else
                        {
                            Palabra = Vector1[i];
                            Palabra = Palabra.Substring(0, 1).ToUpper();
                            lista.Add(Palabra);
                        }

                    }
                    string union = string.Join("", lista.ToArray());
                    escuela_ = union;

                }
            }
            get { return escuela_; }
        }
        private string escuela_;

        public string Nombre { get; set; }


    }

    public class EstudianteCarta
    {
        public int ID { get; set; }
        public DateTime FechaActual
        {

            set
            {
                this.fechaactual_ = value;
                int dia = fechaactual_.Day;
                int anio = fechaactual_.Year;
                string mes = fechaactual_.ToString("MMMM");

                fechaactualword_ = dia.ToString() + " de " + mes + " de " + anio.ToString();
                año_ = anio.ToString();
            }
            get
            {
                return this.fechaactual_;
            }
        }
        private DateTime fechaactual_;

        //sale de fechaactualdatetime
        public string FechaActualWord { set { this.fechaactualword_ = value; } get { return this.fechaactualword_; } }
        private string fechaactualword_;

        public string FolioAceptacion { get; set; }
        //sale de fechaactualdatetime
        public string Año { get { return this.año_; } set { this.año_ = value; } }
        private string año_;
        public string NombreEncargadoEscuela { get; set; }

        public string CargoEncargado { get; set; }

        public string Escuela { get; set; }

        public string Programa
        {
            set
            {
                this.programa_ = value;
                this.programa2_ = value;
                if (estado_ == "Aceptacion")
                {
                    if (programa_ == "Servicio Social") { programa2_ = " su Servicio Social"; }
                    else { programa2_ = " las Prácticas Profesionales"; }
                }

            }
            get { return this.programa_; }
        }
        private string programa_;

        public string Programa2 { get { return this.programa2_; } }
        private string programa2_;

        public string NombreEstudiante { get; set; }

        public string MatriculaEstudiante { get; set; }
        //cambiar el la
        public string Sexo
        {
            set
            {
                this.sexo_ = value;
                if (sexo_ == "Masculino")
                {
                    ela_ = "el alumno";
                }
                else { ela_ = "la alumna"; }

            }
            get { return this.sexo_; }
        }
        private string sexo_;

        public string Ela { get { return this.ela_; } }
        private string ela_;


        public string CarreraEstudiante { get; set; }

        public string Estado
        {
            set
            {
                this.estado_ = value;
                if (estado_ == "Aceptacion")
                {
                    if (ela_ == "el alumno") { motivo_ = "aceptado "; }
                    else { motivo_ = "aceptada "; }
                }
                else
                {
                    motivo_ = " concluido";
                }

            }
            get { return this.estado_; }
        }
        private string estado_;

        public string Motivo { get { return this.motivo_; } }
        private string motivo_;

        public string Proyecto { get; set; }

        public string Actividades { get; set; }

        public string Duracion { get; set; }

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
        public string HoraEntrada { get; set; }

        public string HoraSalida { get; set; }

        public string NombreAsesor { get; set; }

        public string CargoAsesor { get; set; }

        public string Area { get; set; }

        public string Ubicacion { get; set; }
        public string Extension { get; set; }

    }

    public class CredencialesCls
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string FolioAceptacion { get; set; }

        public string Programa { get; set; }

        public string Area { get; set; }

        public string HoraEntrada { get; set; }

        public string HoraSalida { get; set; }

        public string Escuela
        {
            set
            {
                this.escuela_ = value; if (!string.IsNullOrEmpty(escuela_))
                {
                    String[] Vector1 = escuela_.Split(' ');
                    String Palabra;
                    var articulos = new List<string> {"De","Del","La","El","Los","Las","Al" };
                    List<string> lista = new List<string>();
                    for (int i = 0; i < Vector1.Length; i++)

                    {
                        if (articulos.Contains(Vector1[i]))
                        {
                          
                        }
                        else
                        {
                            Palabra = Vector1[i];
                            Palabra = Palabra.Substring(0, 1).ToUpper();
                            lista.Add(Palabra);
                        }
                      
                    }
                    string union = string.Join("", lista.ToArray());
                    escuela_ = union;

                }
            }
            get { return escuela_; }
        }
        private string escuela_;

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
