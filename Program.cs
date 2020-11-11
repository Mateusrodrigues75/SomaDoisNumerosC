using System;

namespace SomaDoisNumerosC
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            Console.WriteLine("Soma de dois Números");
            Console.WriteLine("--------------------");
            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            int soma = valor1 + valor2;
            Console.WriteLine("A soma de " + valor1 + " + " + valor2 + " é " + soma);
            
        }
    }
}
