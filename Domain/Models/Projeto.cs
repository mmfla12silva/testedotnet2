using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Desenvolvedor")]
        public string DesenvolvedorId { get; set; }
        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
