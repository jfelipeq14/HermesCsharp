using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class RolPrivilegio
    {
        [Display(Name = "Id")]
        public int idRolPrivilegio { get; set; }

        [Display(Name = "Rol")]
        public int idRol { get; set; }

        [Display(Name = "Privilegio")]
        public int idPrivilegio { get; set; }
    }
}