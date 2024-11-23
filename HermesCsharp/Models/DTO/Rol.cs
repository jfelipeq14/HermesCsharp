using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Rol
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        public bool estadoRol { get; set; }
    }
}