using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Servicio
    {
        public int idServicio { get; set; }
        public int idCategoriaServicio { get; set; }
        public string nombreServicio { get; set; }
        public decimal valorServicio { get; set; }
        public bool estadoServicio { get; set; } = true;
    }
}