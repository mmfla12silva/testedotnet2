using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Desenvolvedor : IdentityUser
    {
        public string Nome { get; set; }
        public Nivel Nivel { get; set; }

        [ForeignKey("DesenvolvedorId")]
        public virtual ICollection<Projeto> Projetos { get; set; }
        [ForeignKey("DesenvolvedorIdLancHora")]
        public virtual ICollection<LancamentoHora> LancamentoHoras { get; set; }

    }
}
