using System.Text.RegularExpressions;

namespace Ejercicio02.Entidades
{
    public static class ValidarPatentes
    {
        public static string Validar(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
            {
                return "Patente inválida.";
            }

            string formato = ObtenerFormato(patente);
            return formato ?? "Formato de patente no válido.";
        }

        private static string ObtenerFormato(string patente)
        {
            if (EsFormatoViejo(patente))
            {
                return "Formato viejo (AAA NNN)";
            }
            else if (EsFormatoNuevo(patente))
            {
                return "Formato nuevo (AA NNN AA)";
            }
            else
            {
                return null;
            }
        }

        private static bool EsFormatoViejo(string patente)
        {
            // Formato AAA NNN
            string patronViejo = @"^[A-Z]{3}\s\d{3}$";
            return Regex.IsMatch(patente, patronViejo);
        }

        private static bool EsFormatoNuevo(string patente)
        {
            // Formato AA NNN AA
            string patronNuevo = @"^[A-Z]{2}\s\d{3}\s[A-Z]{2}$";
            return Regex.IsMatch(patente, patronNuevo);
        }
    }
}

