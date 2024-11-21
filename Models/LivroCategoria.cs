using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]
        public int LivroCategoriaId { get; set;}
        [ForeignKey("Livro")]
        public int LivroID { get; set;}
        public Livro Livro { get; set;}

        [ForeignKey("Categoria")] 
        public int CategoriaID { get;}
        public Categoria Categoria { get; set;}
        
    }
}