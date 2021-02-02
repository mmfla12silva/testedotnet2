using Domain.Interface;
using Domain.Models;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repository
{
    public class LancamentoHoraRepository : ILancamentoHoraRepository
    {
        private readonly TesteDbContext _ctx;
        public LancamentoHoraRepository(TesteDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<LancamentoHora> GetLancamentoHoras()
        {
            return _ctx.LancamentoHoras;
        }
    }
}
