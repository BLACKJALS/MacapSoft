using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacapSoft.Controllers
{
    public class DiagnosticoController : Controller
    {
        // GET: Diagnosticos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarDiagnosticos() {
            return View();
        }

        public ActionResult CrearDiagnostico() {
            return View();
        }
    }
}