namespace Ejercicio03.Entidades
{
    public class Kilometro
    {
        private float distancia;

        public Kilometro(float distancia = 100)
        {
            this.distancia = distancia;
        }

        public float GetDistancia()
        {
            return distancia;
        }

        public static implicit operator Kilometro(float d)
        {
            return new Kilometro(d);
        }

        public static explicit operator Milla(Kilometro km)
        {
            return new Milla(km.distancia * 0.621371f);
        }

        public static Kilometro operator +(Kilometro km1, Kilometro km2)
        {
            return new Kilometro(km1.distancia + km2.distancia);
        }

        public static bool operator ==(Kilometro km1, Kilometro km2)
        {
            return km1.distancia == km2.distancia;
        }

        public static bool operator !=(Kilometro km1, Kilometro km2)
        {
            return !(km1 == km2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Kilometro)
            {
                Kilometro km = (Kilometro)obj;
                return this.distancia == km.distancia;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return distancia.GetHashCode();
        }
    }

}
