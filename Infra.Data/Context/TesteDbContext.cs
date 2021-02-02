using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Context
{
    public class TesteDbContext : IdentityDbContext<Desenvolvedor>
    {
        public TesteDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<LancamentoHora> LancamentoHoras { get; set; }
    }
}
