using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacapsoftBO.Models
{
    public class HistoriaClinica
    {

        public string contraseña { get; set; }
        [Key]
        public string usuario { get; set; }
    }
}
