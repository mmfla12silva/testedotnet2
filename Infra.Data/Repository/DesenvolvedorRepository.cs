using Domain.Interface;
using Domain.Models;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repository
{
    public class DesenvolvedorRepository : IDesenvolvedorRepository
    {
        private readonly TesteDbContext _ctx;
        public DesenvolvedorRepository(TesteDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Desenvolvedor> GetDesenvolvedores()
        {
            return _ctx.Desenvolvedores;
        }
    }
}
