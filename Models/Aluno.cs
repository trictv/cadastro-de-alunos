using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace p2.Models
{
    [Table(name: "Alunos")]
    public class Aluno
    {
        public int Id { set; get; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo EMAIL é obrigatório")]
        public string Email { get; set; }

        [MaxLength(17)]
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string Cpf { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo RG é obrigatório")]
        public string Rg { get; set; }

        public virtual ICollection<Nota> Notas { set; get; }
    }
}
