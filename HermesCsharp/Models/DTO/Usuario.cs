using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string tipoDocumento { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string contrasenha { get; set; }
        public bool estadoUsuario { get; set; }
    }
}