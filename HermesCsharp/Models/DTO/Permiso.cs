using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Permiso
    {
        [Display (Name = "Id")]
        public int idPermiso { get; set; }
        [Display (Name = "Nombre permiso")]
        public string nombrePermiso { get; set; }
        [Display(Name = "Estado permiso")]
        public bool estadoPermiso { get; set; }
    }
}