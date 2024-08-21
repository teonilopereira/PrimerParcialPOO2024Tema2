
using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilometro km1 = new Kilometro(10);
            Milla m1 = new Milla(6.21371f);

            Kilometro kmConverted = (Kilometro)m1;
            Milla millasConverted = (Milla)km1;

            Console.WriteLine($"10 Km en Millas: {millasConverted.GetDistancia()}");
            Console.WriteLine($"6.21371 Millas en Km: {kmConverted.GetDistancia()}");

            Kilometro kmSumados = km1 + (Kilometro)m1;
            Milla millasSumadas = m1 + (Milla)km1;

            Console.WriteLine($"Suma en Km: {kmSumados.GetDistancia()}");
            Console.WriteLine($"Suma en Millas: {millasSumadas.GetDistancia()}");
            Console.WriteLine(
                km1 == kmConverted
                ? "Las distancias en KM son iguales"
                : "Las distancias en KM son diferentes");
            Console.WriteLine(
                m1 == millasConverted
                ? "Las distancias en millas son iguales"
                : "Las distancias en millas son diferentes");



        }
    }
}
