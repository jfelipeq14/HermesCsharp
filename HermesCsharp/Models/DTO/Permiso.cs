using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Permiso
    {
        public int idPermiso { get; set; }
        public string nombrePermiso { get; set; }
        public bool estadoPermiso { get; set; }
    }
}