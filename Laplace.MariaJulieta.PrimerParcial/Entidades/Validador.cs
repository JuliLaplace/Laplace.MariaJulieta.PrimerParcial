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
        public static bool ValidarSiCadenaEsSoloLetras(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool StringEsNumerico(string dato)
        {
            int numero;
            return (int.TryParse(dato, out numero));
        }
        public static int CadenaStringAInt(string cadena)
        {
            int numero;
            if (int.TryParse(cadena, out numero))
            {
                return numero;
            }
            return 0;
        }
    }
}
