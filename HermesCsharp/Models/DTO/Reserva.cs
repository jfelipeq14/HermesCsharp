using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public int idProgramacion { get; set; }
        public int idCliente { get; set; }
        public DateTime? fechaReserva { get; set; }
        public decimal valorReserva { get; set; }
        public char estadoReserva { get; set; }
    }
}