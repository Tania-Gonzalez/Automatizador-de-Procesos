//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoResidencias
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documentos()
        {
            this.Expediente = new HashSet<Expediente>();
        }
    
        public int ID_Documentos { get; set; }
        public bool Entrevista { get; set; }
        public bool Carta_Compromiso { get; set; }
        public bool Anexo { get; set; }
        public bool Reglamento { get; set; }
        public bool Hoja_Renta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente> Expediente { get; set; }
    }
}
