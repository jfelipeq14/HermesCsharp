using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Paquete
    {
        public int idPaquete { get; set; }
        public string nombrePaquete { get; set; }
        public int idMunicipio { get; set; }
        public int idActividad { get; set; }
        public decimal nivelActividad { get; set; }
        public decimal inversionPaquete { get; set; }
        public decimal reservaPaquete { get; set; }
    }
}