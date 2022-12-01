using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;
using System.Text;

namespace EYSE.Controllers
{
    public class MotivosIngresoController : Controller
    {
        // GET: MotivosIngreso
        public ActionResult IndexMotivoIngreso()
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities()) { 
                    List<SP_Obtener_Causas_Result> data = db.SP_Obtener_Causas().ToList();
                    return View(data);
                }
            }
            catch (Exception)
            {
                return View("Error");
                throw;
            }
 
        }

        [HttpPost]
        public JsonResult EnviarNuevoMotivo(string Motivo)
        {
            try
            {             

                using (EYSEEntities db = new EYSEEntities())
                {
                    db.SP_InsertarMotivoIngreso(Motivo);
                }

                return Json(new { msg = "Ingresado" });
            }
            catch (Exception e)
            {
                return Json( new { msg = "Error" } );
                throw;

            }


        }
    }
}