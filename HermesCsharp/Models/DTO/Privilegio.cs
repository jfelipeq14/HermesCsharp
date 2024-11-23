using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Privilegio
    {
        [Display(Name = "Id")]
        public int idPrivilegio { get; set; }

        [Display(Name = "Nombre privilegio")]
        public string nombrePrivilegio { get; set; }

        [Display(Name = "Permiso")]
        public int idPermiso { get; set; }
    }
}