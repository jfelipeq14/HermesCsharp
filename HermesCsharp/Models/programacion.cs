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
    
    public partial class programacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public programacion()
        {
            this.reserva = new HashSet<reserva>();
        }
    
        public int idProgramacion { get; set; }
        public System.DateTime fechaInicioInscripcion { get; set; }
        public System.DateTime fechaFinInscripcion { get; set; }
        public System.DateTime fechaEjecucion { get; set; }
        public System.DateTime fechaFinalizacion { get; set; }
        public System.TimeSpan horaInicioRecogida { get; set; }
        public System.TimeSpan horaFinRecogida { get; set; }
        public int idPaquete { get; set; }
    
        public virtual paquete paquete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
    }
}