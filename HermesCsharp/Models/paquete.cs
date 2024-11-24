//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HermesCsharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paquete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paquete()
        {
            this.detallePaqueteServicio = new HashSet<detallePaqueteServicio>();
            this.programacion = new HashSet<programacion>();
        }
    
        public int idPaquete { get; set; }
        public string nombrePaquete { get; set; }
        public int idMunicipio { get; set; }
        public int idActividad { get; set; }
        public decimal nivelActividad { get; set; }
        public decimal inversionPaquete { get; set; }
        public decimal reservaPaquete { get; set; }
    
        public virtual actividad actividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallePaqueteServicio> detallePaqueteServicio { get; set; }
        public virtual municipio municipio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<programacion> programacion { get; set; }
    }
}
