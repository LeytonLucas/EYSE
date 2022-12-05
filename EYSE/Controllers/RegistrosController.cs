using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EYSE.Controllers
{
    public class RegistrosController : Controller
    {
        // GET: Registros
        public ActionResult RegistrosIndex()
        {
            return View();
        }
    }
}