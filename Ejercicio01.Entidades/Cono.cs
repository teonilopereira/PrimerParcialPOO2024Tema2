using System.Dynamic;

namespace Ejercicio1.Datos
{
    public class Cono
    {
        public int Radio { get; }
        public int Altura { get; }
        private double Generatriz { get; }

        public Cono(int radio, int altura)
        {
            Radio = radio;
            Altura = altura;
            Generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        }

        public double CalcularArea()
        {
            double areaBase = Math.PI * Math.Pow(Radio, 2);
            double areaLateral = Math.PI * Radio * Generatriz;
            return areaBase + areaLateral;
        }

        public double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }

        public void InformarDatos()
        {
            Console.WriteLine($"El radio del cono es: {Radio}");
            Console.WriteLine($"El altura del cono es: {Altura}");
            Console.WriteLine($"El Generatriz del cono es: {Generatriz}");
            Console.WriteLine($"El área del cono es: {CalcularArea()}");
            Console.WriteLine($"El volumen del cono es: {CalcularVolumen()}");
        }

    }

}
