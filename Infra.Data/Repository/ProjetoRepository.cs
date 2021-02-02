using Domain.Interface;
using Domain.Models;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly TesteDbContext _ctx;
        public ProjetoRepository(TesteDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Projeto> GetProjetos()
        {
            return _ctx.Projetos;
        }
    }
}
