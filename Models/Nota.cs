using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace p2.Models
{
    [Table(name: "Notas")]
    public class Nota
    {
        
        public int Id { set; get; }

        
        [Required(ErrorMessage = "Campo Notas é obrigatório")]
        public float Notas { set; get; }


        public virtual Aluno Aluno { set; get; }
        public int AlunoId { set; get; }


        public virtual Disciplina Disciplina { set; get; }
        public int DisciplinaId { set; get; }
       
    }
}
