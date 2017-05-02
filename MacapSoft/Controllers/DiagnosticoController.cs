using MacapSoft.LogicaModels;
using MacapsoftBO.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacapSoft.Controllers
{
    [Authorize]
    public class DiagnosticoController : Controller
    {

        DiagnoticosDALC diag = new DiagnoticosDALC();

        // GET: Diagnosticos
        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult ListarDiagnosticos() {
            return View();
        }

        
        public JsonResult ListarDiagnosticosCAP() {
            Maper map = new Maper();
            var lista = map.ListarDiagnosticos();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }


        
        public ActionResult CrearDiagnostico() {
            diagnosticosPrincipales();
            return View();
        }

        
        public ActionResult CrearDiagnosticoCAP(string Codigo, string Nombre, string Destacado)
        {
            Maper map = new Maper();
            try
            {
                map.GuardarDiagnostico(Codigo, Nombre, Destacado);
                return View();
            }
            catch (Exception)
            {
                return View("ErrorCrearDiagnosticoView");
                throw;
            }
            
        }


        public void diagnosticosPrincipales()
        {
            List<SelectListItem> lista = new List<SelectListItem>();

            SelectListItem Cabecera = new SelectListItem()
            {
                Text = "--Seleccione--",
                Value = "Seleccione"
            };

            SelectListItem diagnosticoImportante = new SelectListItem()
            {
                Text = "Si",
                Value = "Si"
            };

            SelectListItem diagnosticoNoImportante = new SelectListItem()
            {
                Text = "No",
                Value = "No"
            };

            lista.Add(Cabecera);
            lista.Add(diagnosticoImportante);
            lista.Add(diagnosticoNoImportante);

            ViewBag.ItemTypes = lista.ToList();
        }
    }
}