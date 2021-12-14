using System;
using Microsoft.AspNetCore.Mvc;

namespace GestionUsarios.Controllers
{
    public class UserController : Controller
    {
        // GET : Usuarios
        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Calculadora(string operacion, int valora, int valorb)
        {
            int respuesta = 0;
            switch (operacion)
            {
                case "suma":
                    respuesta = valora + valorb;
                    break;
                case "resta":
                    respuesta = valora - valorb;
                    break;
                case "multiplicacion":
                    respuesta = valora * valorb;
                    break;
                case "division":
                    respuesta = valora / valorb;
                    break;
            }

            ViewData["resp"] = respuesta;

            return View();
        }

    }

}