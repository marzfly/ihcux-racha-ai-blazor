using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RachaAi.Models
{
    public class Perfil
    {
        public string NomeUsuario {get; set; } = string.Empty;
        public decimal SaldoUsuario {get; set; }
        public decimal AReceber {get; set; }
        public decimal APagar {get; set; }
    }
}