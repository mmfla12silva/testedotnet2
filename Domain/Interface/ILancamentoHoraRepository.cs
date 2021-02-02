using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface ILancamentoHoraRepository
    {
        IEnumerable<LancamentoHora> GetLancamentoHoras();
    }
}
