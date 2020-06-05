using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias
{
   public class Accesoscls
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
    public class ProgramasCls
    {
        public string SS { get; set; }
        public int CantidadSS { get; set; }
        public string PP { get; set; }
        public int CantidadPP { get; set; }
    }
    public class CarrerasCls
    {
        public string NombreCarrera { get; set; }
        public int Total { get; set; }
    }

   
    
    public class EscuelasCls
    {
        public string Escuela
        {
            set
            {
                this.escuela_ = value; if (!string.IsNullOrEmpty(escuela_))
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
        public int Cantidad { get; set; }
    }

    public class Turnocls
    {
        public string Turno { get; set; }
        public int Cantidad { get; set; }

    }
    public class Origencls
    {
        public string Lugar { get; set; }
        public int Cantidad { get; set; }

    }
}
