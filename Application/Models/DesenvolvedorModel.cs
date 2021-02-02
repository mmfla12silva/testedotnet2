using Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class DesenvolvedorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nivel Nivel { get; set; }
    }
}
