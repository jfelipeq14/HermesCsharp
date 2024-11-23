using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Programacion
    {
        public int idProgramacion { get; set; }
        public DateTime fechaInicioInscripcion { get; set; }
        public DateTime fechaFinInscripcion { get; set; }
        public DateTime fechaEjecucion { get; set; }
        public DateTime fechaFinalizacion { get; set; }
        public TimeSpan horaInicioRecogida { get; set; }
        public TimeSpan horaFinRecogida { get; set; }
        public int idPaquete { get; set; }
    }
}