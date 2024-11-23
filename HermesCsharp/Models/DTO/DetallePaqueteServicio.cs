using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class DetallePaqueteServicio
    {
        public int idDetallePaqueteServicio { get; set; }
        public int idPaquete { get; set; }
        public int idServicio { get; set; }
        public int cantidadServicioPaquete { get; set; }
        public decimal? valorServicioPaquete { get; set; }
    }
}