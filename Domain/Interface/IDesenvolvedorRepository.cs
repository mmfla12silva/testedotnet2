using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IDesenvolvedorRepository
    {
        public IEnumerable<Desenvolvedor> GetDesenvolvedores();
    }
}
