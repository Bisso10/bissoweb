using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bissoweb.Models;
using bissoweb.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace bissoweb.Areas.Calculadora.Controllers
{
    [Area("Calculadora")]
    public class CalculadoraController : Controller
    {
        
        private SignInManager<IdentityUser> _usuario;
        public CalculadoraController(SignInManager<IdentityUser> usuarioLogueado)
        {
            _usuario = usuarioLogueado;
        }
        public IActionResult Calculadora(float nro1, float nro2, int operacion)
        {

             var model = new DatosCalculadora();
            if (_usuario.IsSignedIn(User))
            {
                if (operacion == 1)
                {
                    
                    model.nro1 = nro1;
                    model.nro2 = nro2;
                    model.operacion = operacion;
                    var oper = new Operaciones();
                    model.resultado = oper.Sumar(model.nro1, model.nro2);
                }
                return View(model);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            
        }
    }      
}