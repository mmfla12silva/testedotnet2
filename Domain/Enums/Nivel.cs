using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Enums
{
    public enum Nivel : short
    {
        [Description("Programador Júnior"), Display(Name = "Programador Júnior")]
        Junior = 0,
        [Description("Programador Pleno"), Display(Name = "Programador Pleno")]
        Pleno = 1,
        [Description("Programador Sênior"), Display(Name = "Programador Sênior")]
        Senior = 2,
    }
}
