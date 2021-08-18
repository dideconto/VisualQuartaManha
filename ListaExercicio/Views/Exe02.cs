using System;

namespace ListaExercicio.Views
{
    public class Exe02
    {
        public static void Renderizar()
        {
            const double VALOR_DOLAR_ATUAL = 5.17;
            double real, dolar;
            Console.WriteLine("Digite o valor em R$:");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / VALOR_DOLAR_ATUAL;
            Console.WriteLine($"Dolar: { dolar.ToString("F2") }");
        }
    }
}