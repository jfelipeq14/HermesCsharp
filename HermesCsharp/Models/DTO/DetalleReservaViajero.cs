using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class DetalleReservaViajero
    {
        public int idDetalleReservaViajero { get; set; }
        public int idReserva { get; set; }
        public int idCliente { get; set; }
    }
}