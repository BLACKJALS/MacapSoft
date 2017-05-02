using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacapsoftBO.Models
{
    public class Diagnostico
    {
        [Key]
        [Required(ErrorMessage = "Por favor ingresar el código del diagnóstico")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Por favor ingresar el nombre del diagnóstico")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor indicar si el diagnóstico es destacado o no")]
        public string Destacado { get; set; }
    }
}
