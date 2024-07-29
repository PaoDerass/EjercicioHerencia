namespace EjercicioHerencia
{
    public class Class1 : Operaciones
    {
        public void Imprimir(double radio, double lado)
        {
            double circulo = AreaCirculo(radio);
            double Cubo = VolCubo(lado);
            double circunferencia = LonCircuferencia(radio);

            Console.WriteLine($"Area del circulo: {circulo}");
            Console.WriteLine($"Volumen Cubo: {Cubo}");
            Console.WriteLine($"Longitud Circunferencia: {circunferencia}");
        }
    }
}