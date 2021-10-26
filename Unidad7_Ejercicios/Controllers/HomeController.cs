﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unidad7_Ejercicios.Models.Entity;

namespace Unidad7_Ejercicios.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //aqui los ViewData
            ViewData["Hora"] = Models.Utilidades.Utilidades.getSaludoHora();
            ViewBag.HoraLarga= DateTime.Now.ToString();
            //Crear objeto persona
            clsPersona persona = new clsPersona("Mar");
            //el view enviara el objeto persona
            return View(persona);
        }
        //listado de personas en DAL
        
        
    }
}
