using MacapsoftBO.Bd_Context;
using MacapsoftBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacapsoftBO.DALC
{
    public class DiagnoticosDALC
    {
        public List<Diagnostico> ListarDiagnosticos() {
            List<Diagnostico> listaDiagnostico = new List<Diagnostico>();
            var bd = new Bd_Macapsoft();
            listaDiagnostico = bd.Db_DiagnosticoContext.ToList();
            return listaDiagnostico;
        }

        public void CrearDiagnostico(Diagnostico codigo) {
            var bd = new Bd_Macapsoft();
            bd.Db_DiagnosticoContext.Add(codigo);
            bd.SaveChanges();
        }
    }
}
