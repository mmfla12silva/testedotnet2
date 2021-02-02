using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class LancamentoHora
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        [ForeignKey("Desenvolvedor")]
        public string DesenvolvedorIdLancHora { get; set; }
        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
