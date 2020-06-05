using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias
{
   public class FestivosDias
    {
          
        [DisplayName("Dia")]
        public string Nombre { get; set; }
        [DisplayName("Fecha")]
        public DateTime Dia { get; set; }
    }
}

