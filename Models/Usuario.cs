using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateOnly DtNascimento { get; set; }
        public string? Contato { get; set; }
        public bool Admin { get; set; }
        public bool Status { get; set; }

        [ForeignKey("Curso")] 
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                     