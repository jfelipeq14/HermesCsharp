using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HermesCsharp.Models.DTO
{
    public class Municipio
    {
        public int idMunicipio { get; set; }
        public int codigoMunicipio { get; set; }
        public string nombreMunicipio { get; set; }
        public int idDepartamento { get; set; }
    }
}