using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;

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
    }
}