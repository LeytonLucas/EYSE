using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;
using Newtonsoft.Json;

namespace EYSE.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamentos
        public ActionResult DepartamentosIndex()
        {
            using (EYSEEntities db = new EYSEEntities()) {
                try
                {
                    
                    List<SP_Obtener_Departamentos_Result> Departamentos = db.SP_Obtener_Departamentos(0).ToList();
                    return View(Departamentos);
                }
                catch (Exception)
                {
                    return View();
                    throw;
                    
                }      
            }
        }

        public ActionResult AgregarDepartamento()
        {
            return View();
        }

        public ActionResult AgregarDivision(int idDpto)
        {
            using (EYSEEntities db = new EYSEEntities()) {
                Departamento dpto = db.Departamento.Find(idDpto);
                return View(dpto);
            }
            
        }

        [HttpPost]
        public JsonResult EnviarAgregarDto(string dpto)
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities()){
                    if(dpto != null)
                    {
                        string[] departamentos = db.SP_Obtener_Departamentos(0).Select(m => m.Departamento).ToArray();
                        if (departamentos.Contains(dpto))
                        {
                            return Json(new { msg = "Ya existe un departamento con el nombre elegido", tipo = "danger" });
                        }
                        else
                        {
                            db.SP_InsertarDepartamento(dpto);
                            return Json(new { msg = "Exito", tipo = "success" });
                        }

                    }
                }
            }
            catch (Exception)
            {
                return Json("Error");
                throw;
            }
            return Json("");
        }

        [HttpPost]
        public JsonResult EnviarAgregarDiv(int idDpto, string div, string obs, string local)
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    
                    string[] divisiones = db.SP_Obtener_Divisiones(idDpto).Select(m => m.Division).ToArray();
                    if (divisiones.Contains(div))
                    {
                        return Json(new { msg = "Ya existe una division con el nombre elegido", tipo="danger"});
                    }
                    else
                    {
                        db.SP_InsertarDivision(div, local, obs, idDpto);
                        return Json(new { msg = "Exito", tipo= "success"});
                    }
  
                }
            }
            catch (Exception)
            {
                return Json(new { msg = "Error", tipo="danger" });
                throw;
            }
            return Json("");
        }


        [HttpPost]
        public JsonResult ObtenerDivisiones(int IdDpto)
        {
            try
            {
                using (EYSEEntities db = new EYSEEntities())
                {
                    if (IdDpto != 0)
                    {
                        List<SP_Obtener_Divisiones_Result> Divisiones = db.SP_Obtener_Divisiones(IdDpto).ToList();
                        string Divs = JsonConvert.SerializeObject(Divisiones);

                        return Json(new { msg = "Exito", divs = Divs});

                    }
                }
            }
            catch (Exception)
            {
                return Json(new { msg = "Error" });
                throw;
            }
            return Json("");
        }
    }
}