﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EYSE.Models;

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

        public ActionResult AgregarDivision()
        {

            return View();
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
                        if (departamentos.Contains(dpto)) {
                            return Json("Ya existe un departamento con el nombre elegido");
                        }
                        else
                        {
                            db.SP_InsertarDepartamento(dpto);
                            return Json("Exito");
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

        
    }
}