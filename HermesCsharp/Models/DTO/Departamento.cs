using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Departamento
    {
        public int idDepartamento { get; set; }
        public int codigoDepartamento { get; set; }
        public string nombreDepartamento { get; set; }
        public int idPais { get; set; }
    }
}