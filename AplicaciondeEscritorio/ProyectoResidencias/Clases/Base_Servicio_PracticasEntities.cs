using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResidencias
{
    public partial class Base_Servicio_PracticasEntities : DbContext
        
    {
        public Base_Servicio_PracticasEntities(string CadenaConexion) : base(CadenaConexion)
        {

        }
    }
}
