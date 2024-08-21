namespace Ejercicio03.Entidades
{
    public class Milla
    {
        private float distancia;

        public Milla(float distancia = 100)
        {
            this.distancia = distancia;
        }

        public float GetDistancia()
        {
            return distancia;
        }

        public static implicit operator Milla(float d)
        {
            return new Milla(d);
        }

        public static explicit operator Kilometro(Milla mi)
        {
            return new Kilometro(mi.distancia * 1.60934f);
        }

        public static Milla operator +(Milla mi1, Milla mi2)
        {
            return new Milla(mi1.distancia + mi2.distancia);
        }

        public static bool operator ==(Milla mi1, Milla mi2)
        {
            return mi1.distancia == mi2.distancia;
        }

        public static bool operator !=(Milla mi1, Milla mi2)
        {
            return !(mi1 == mi2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Milla)
            {
                Milla mi = (Milla)obj;
                return this.distancia == mi.distancia;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return distancia.GetHashCode();
        }
    }

}
