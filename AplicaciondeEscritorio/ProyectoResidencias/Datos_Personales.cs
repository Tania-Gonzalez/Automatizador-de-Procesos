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
    
    public partial class Datos_Personales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Datos_Personales()
        {
            this.Estudiante = new HashSet<Estudiante>();
        }
    
        public int ID_Datos_Personales { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Sexo { get; set; }
        public byte Edad { get; set; }
        public string Estado_Civil { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Telefono_Fijo { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Curp { get; set; }
        public int ID_Referencia { get; set; }
        public int ID_Direccion { get; set; }
    
        public virtual Direccion Direccion { get; set; }
        public virtual Tutor Tutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}