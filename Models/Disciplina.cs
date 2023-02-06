using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace p2.Models
{
    [Table(name: "Disciplinas")]
    public class Disciplina
    {
        public int Id { set; get; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Descricao é obrigatório")]
        public string Descricao { set; get; }

        public virtual ICollection<Nota> Notas { set; get; }
    }
}
