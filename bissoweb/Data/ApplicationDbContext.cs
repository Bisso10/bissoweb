using System;
using System.Collections.Generic;
using System.Text;
using bissoweb.Areas.Categorias.Models;
using bissoweb.Areas.Cursos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bissoweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TCategoria> _TCategorias { get; set; }
        public DbSet<TCursos> _TCursos { get; set; }
    }
}
