using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bissoweb.Areas.Categorias.Models;
using bissoweb.Controllers;
using bissoweb.Data;
using bissoweb.Library;
using bissoweb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace bissoweb.Areas.Categorias.Controllers
{
    [Area("Categorias")]
    public class CategoriasController : Controller
    {
        private TCategoria _categoria;
        private LCategoria _lcategoria;
        private SignInManager<IdentityUser> _signInManager;
        private static DataPaginador<TCategoria> models;
        public CategoriasController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _lcategoria = new LCategoria(context);
        }
        public IActionResult Categorias()
        {
            if(_signInManager.IsSignedIn(User))
            {
                models = new DataPaginador<TCategoria>
                {
                    Input = new TCategoria()
                };
                return View(models);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            } 
        }
        [HttpPost]
        public String GetCategorias(DataPaginador<TCategoria> model)
        {
            if(model.Input.Nombre != null && model.Input.Descripcion !=null)
            {
                var data = _lcategoria.RegistrarCategoria(model.Input);
                return JsonConvert.SerializeObject(data);
            }
            else
            {
                return "Llene los datos Requeridos";
            }
        }
    }
}