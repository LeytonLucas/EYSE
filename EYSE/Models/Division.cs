//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EYSE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Division()
        {
            this.Equipo = new HashSet<Equipo>();
        }
    
        public int IdDivision { get; set; }
        public string Division1 { get; set; }
        public string IdLocal { get; set; }
        public string Observacion { get; set; }
        public int IdDepartamento { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipo> Equipo { get; set; }
    }
}
