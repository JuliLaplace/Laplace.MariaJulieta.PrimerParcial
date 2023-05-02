using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validador
    {
        public static bool ValidarQueEsTexto(string texto)
        {
            return !string.IsNullOrEmpty(texto);
        }
    }
}
