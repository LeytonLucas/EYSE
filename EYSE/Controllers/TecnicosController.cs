using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Ajax.Utilities;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;
using Newtonsoft.Json;

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
            return View();
        }

        [HttpPost]
        public JsonResult EnviarAgregarTecnico(string TecnicoJson)
        {
            try
            {
                Tecnico NT = JsonConvert.DeserializeObject<Tecnico>(TecnicoJson);

                using (EYSEEntities db = new EYSEEntities())
                {
                    db.SP_InsertarTecnico(NT.DNI, NT.Nombre, NT.Apellido);
                }

                return Json("Insertado correctamente");
            }
            catch (Exception e)
            {
                return Json("Error" + e.Message);
                throw;
                
            }
            
          
        }

        [HttpPost]
        public JsonResult EnviarEliminarTecnico(int DNI)
        {
            try
            {
                
                using (EYSEEntities db = new EYSEEntities())
                {
                    db.SP_Eliminar_Tecnico(DNI);
                }

                return Json("Eliminado");
            }
            catch (Exception e)
            {
                return Json("Error" + e.Message);
                throw;

            }


        }

    }
}