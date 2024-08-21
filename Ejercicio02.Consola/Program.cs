using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la patente:");
            string patente = Console.ReadLine();

            string resultado = ValidarPatentes.Validar(patente);
            Console.WriteLine($"Patente: {patente} - {resultado}");
        }

    }
}
