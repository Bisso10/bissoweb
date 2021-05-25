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
        private static IdentityError identityError;
        public CategoriasController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _lcategoria = new LCategoria(context);
        }
        public IActionResult Categorias(int id, String Search, int Registros)
        {
            if (_signInManager.IsSignedIn(User))
            {
                Object[] objects = new Object[3];
                var data = _lcategoria.getTCategoria(Search);
                if (0 < data.Count)
                {
                    var url = Request.Scheme + "://" + Request.Host.Value;
                    objects = new LPaginador<TCategoria>().paginador(_lcategoria.getTCategoria(Search),
                        id, Registros, "Categorias", "Categorias", "Categorias", url);
                }
                else
                {
                    objects[0] = "No hay datos para mostrar";
                    objects[1] = "No hay datos para mostrar";
                    objects[2] = new List<TCategoria>();
                }
    
                    models = new DataPaginador<TCategoria>
                    {
                        List = (List<TCategoria>)objects[2],
                        Pagi_info = (String)objects[0],
                        Pagi_navegacion = (String)objects[1],
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
            if (model.Input.Nombre != null && model.Input.Descripcion != null)
            {
                var data = _lcategoria.RegistrarCategoria(model.Input);
                return JsonConvert.SerializeObject(data);
            }
            else
            {
                return "Llene los datos Requeridos";
            }
        }
        [HttpPost]
        public IActionResult UpdateEstado(int id)
        {
            //  var identityError = new IdentityError();
            identityError = _lcategoria.UpdateCategoria(id);
            return Redirect("/Categorias/Categorias?area=Categorias");
        }
    }
}