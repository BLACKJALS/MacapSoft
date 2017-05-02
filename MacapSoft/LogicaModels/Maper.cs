using MacapSoft.Models;
using MacapsoftBO.DALC;
using MacapsoftBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacapSoft.LogicaModels
{
    public class Maper
    {
        public List<DiagnosticoVM> ListarDiagnosticos() {
            DiagnoticosDALC diagnosticoDALC = new DiagnoticosDALC();
            DiagnosticoVM diagnostico;
            List<DiagnosticoVM> lstDiagnostico = new List<DiagnosticoVM>();
            var listaDiagnostico = diagnosticoDALC.ListarDiagnosticos().ToList();
            foreach (var item in listaDiagnostico) {
                diagnostico = new DiagnosticoVM();
                diagnostico.Codigo = item.Codigo;
                diagnostico.Nombre = item.Nombre;
                diagnostico.Destacado = item.Destacado;
                lstDiagnostico.Add(diagnostico);
            }

            return lstDiagnostico.ToList();  
        }


        public void GuardarDiagnostico(string codigo, string nombre, string destacado) {
            DiagnoticosDALC diagnosticoDALC = new DiagnoticosDALC();
            Diagnostico diag = new Diagnostico();
            diag.Codigo = codigo;
            diag.Nombre = nombre;
            diag.Destacado = destacado;
            diagnosticoDALC.CrearDiagnostico(diag);
        }
    }
}