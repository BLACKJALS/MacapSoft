using MacapsoftBO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacapsoftBO.Bd_Context
{
    public class Bd_Macapsoft: DbContext
    {
        public DbSet<Diagnostico> Db_DiagnosticoContext { get; set; }
        public DbSet<HistoriaClinica> Db_HistoriaClinicaContext { get; set; }
    }
}
