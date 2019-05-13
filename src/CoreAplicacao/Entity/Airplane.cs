using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAplicacao.Entity
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int QtdePassageiros { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
