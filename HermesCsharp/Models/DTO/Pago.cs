using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Pago
    {
        public int idPago { get; set; }
        public int idReserva { get; set; }
        public DateTime? fechaPago { get; set; }
        public decimal valorPago { get; set; }
        public string comprobante { get; set; }
        public char estadoPago { get; set; }
    }
}