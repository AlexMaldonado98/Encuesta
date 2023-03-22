using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace RegistroDeEncuesta.Controllers
{
    public class EncuestasController : Controller
    {
        ENCUESTAS.Class1 a = new ENCUESTAS.Class1();
        public ActionResult Index()
        {
            ViewBag.areas = a.ListarAreas();
            ViewBag.encuestas = a.Listar();
            return View(new ENCUESTAS.encuestas());
        }

        /*public ActionResult Create()
        {
            return View(new ENCUESTAS.encuestas());
        }*/

        // GET: Encuestas/Create
        [HttpPost]
        public JsonResult Create(int areaList, string dispositivo)
        {
            ENCUESTAS.encuestas b = new ENCUESTAS.encuestas();
            b.idArea = areaList;
            b.dispositivo = dispositivo;
            var encuestaGuardada = a.Agregar(b);
            ViewBag.areas = a.ListarAreas();
            return Json(new {encuestaGuardada.idArea,encuestaGuardada.dispositivo,area = a.ListarAreas()[encuestaGuardada.idArea - 1].area});
        }
    }
}
