using System;

namespace ListaExercicio.Views
{
    public class Exe01
    {
        public static void Renderizar()
        {
            int largura, altura, area;
            Console.WriteLine("Digite a largura:");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            area = largura * altura;
            Console.WriteLine($"Área: { area }");
        }
    }
}