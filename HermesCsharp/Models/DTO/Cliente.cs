using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public string numeroContacto { get; set; }
        public string direccion { get; set; }
        public int idMunicipio { get; set; }
        public char sexo { get; set; }
        public string tipoDeSangre { get; set; }
        public string eps { get; set; }
        public bool estadoCliente { get; set; } = true;
    }
}