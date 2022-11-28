using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;

namespace EYSE.Controllers
{
    public class EquiposController : Controller
    {
        // GET: Equipos
        public ActionResult Index()
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    List < SP_Obtener_TipoEquipo_Result > data = db.SP_Obtener_TipoEquipo().ToList();
                    return View(data);
                }
            }
            catch (Exception)
            {
                return View("Ocurrio un error");
                throw;
            }
            
        }

        public ActionResult AgregarEquipo()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EnviarAgregarEquipo(string equipo, string descripcion)
        {
            if(equipo != "")
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    try
                    {
                        db.SP_InsertarTipoEquipo(equipo, descripcion);
                        return Json(new { data = "Equipo insertado correctamente" });
                    }
                    catch (Exception)
                    {
                        return Json(new { data = "Ha ocurrido un error" });
                        throw;
                    }
                }
            }
            else
            {
                return Json(new { data = "Ha ocurrido un error, datos vacios" });
            }

        }

        [HttpPost]
        public JsonResult EnviarEliminarEquipo(int? IdEquipo)
        {
            if (IdEquipo != null)
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    try
                    {
                        db.SP_Eliminar_TipoEquipo(IdEquipo);
                        return Json(new { data = "Eliminado correctamente" });
                    }
                    catch (Exception)
                    {
                        return Json(new { data = "Ha ocurrido un error" });
                        throw;
                    }
                }
            }
            else
            {
                return Json(new { data = "Ha ocurrido un error, datos vacios" });
            }

        }

    }
}