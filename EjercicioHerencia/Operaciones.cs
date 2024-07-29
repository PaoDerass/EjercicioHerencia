
namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double AreaCirculo (double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public double VolCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
        public double LonCircuferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }
    }
}
