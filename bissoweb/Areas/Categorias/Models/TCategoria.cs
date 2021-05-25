using bissoweb.Areas.Cursos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bissoweb.Areas.Categorias.Models
{
    public class TCategoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "El Campo Id Es Obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = " El campo Nombre es Obligatorio.")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; } // = true;
        public ICollection<TCursos> Cursos {get; set;}
    }
}
