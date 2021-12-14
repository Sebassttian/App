using System;
using Microsoft.AspNetCore.Mvc;

namespace GestionUsarios.Controllers
{
    public class AppController : Controller
    {
        // GET : Usuarios
        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Register()
        { 
            return View();
        }

        public IActionResult Forgot()
        { 
            return View();
        }

        public IActionResult Profesor()
        { 
            return View();
        }

        public IActionResult Alumno()
        { 
            return View();
        }

        public IActionResult Coordinador()
        { 
            return View();
        }

    }

}