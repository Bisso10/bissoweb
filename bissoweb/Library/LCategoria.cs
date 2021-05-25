using bissoweb.Areas.Categorias.Models;
using bissoweb.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bissoweb.Library
{
    public class LCategoria
    {
        private ApplicationDbContext _context;

        public LCategoria(ApplicationDbContext context)
        {
            _context = context;
        }
        public IdentityError RegistrarCategoria(TCategoria categoria)
        {
            IdentityError identityError;
            try
            {
                _context.Add(categoria);
                _context.SaveChanges();
                identityError = new IdentityError { Code = "Done" };
            }
            catch (Exception e)
            {
                identityError = new IdentityError
                {
                    Code = "Error",
                    Description = e.Message
                };
            }
            return identityError;
        }
        public List<TCategoria> getTCategoria (String valor)
        {
            List<TCategoria> listCategoria;
            if(valor == null)
            {
                listCategoria = _context._TCategorias.ToList();
            }
            else
            {
                listCategoria = _context._TCategorias.Where(c => c.Nombre.StartsWith(valor)).ToList();
            }
            return listCategoria;
        }
        internal IdentityError UpdateCategoria(int id)
        {
            IdentityError identityError;
            try
            {
                var categoria = _context._TCategorias.Where(c => c.CategoriaID.Equals(id)).ToList().ElementAt(0);
                categoria.Estado = categoria.Estado ? false : true;
                _context.Update(categoria);
                _context.SaveChanges();
                identityError = new IdentityError { Description = "Done" };
            }
            catch (Exception e)
            {
                identityError = new IdentityError
                {
                    Code = "Error",
                    Description = e.Message
                };
            }
            return identityError;
        }
    }
}
