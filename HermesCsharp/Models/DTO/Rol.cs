using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Rol
    {
        [Display (Name = "Id")]
        public int idRol { get; set; }

        [Display(Name = "Nombre rol")]
        public string nombreRol { get; set; }

        [Display(Name = "Estado rol")]
        public bool estadoRol { get; set; }
    }
}