using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class RolPrivilegio
    {
        public int idRolPrivilegio { get; set; }
        public int idRol { get; set; }
        public int idPrivilegio { get; set; }
    }
}