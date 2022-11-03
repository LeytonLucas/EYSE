using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;

namespace EYSE.Controllers
{
    public class TecnicosController : Controller
    {
        // GET: Tecnicos
        public ActionResult TecnicosIndex()
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    List<SP_Obtener_Tecnicos_Result> tecnicos = db.SP_Obtener_Tecnicos(0).ToList();

                    return View(tecnicos);
                }
            }
            catch (Exception)
            {
                return View("Error");
                throw;
            }
           
        }

        public ActionResult AgregarTecnico()
        {
            using (EYSEEntities db = new EYSEEntities())
            {


            }
            return View();
        }

    }
}