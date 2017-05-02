using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacapSoft.Models
{
    public class DiagnosticoVM
    { 
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Destacado { get; set; }
    }
}