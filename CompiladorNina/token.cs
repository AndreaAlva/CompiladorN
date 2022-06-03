using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorNina
{
    public class token
    {
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public int Columna { get; set; }
        public int Fila { get; set; }
    }
}
