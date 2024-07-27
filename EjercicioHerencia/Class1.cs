

namespace EjercicioHerencia
{
    internal class Class1 : Operaciones

    {
        public void Imprimir(double radio, double lado)
        {
            double circulo = AreaCirculo(radio);
            double Cubo = VolCubo(lado);
            double circunferencia = LonCircuferencia(radio);

            Console.WriteLine($"Area del circulo: {AreaCirculo}")
        }
    }
}
