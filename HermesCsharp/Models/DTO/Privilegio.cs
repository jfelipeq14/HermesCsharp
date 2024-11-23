using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Privilegio
    {
        public int idPrivilegio { get; set; }
        public string nombrePrivilegio { get; set; }
        public int idPermiso { get; set; }
    }
}