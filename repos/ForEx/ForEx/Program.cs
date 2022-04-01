using System;

namespace ForEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você quer digitar para somar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1;  i <= n ;  i++) {
                Console.WriteLine("Valor #{0}",i );
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("A soma total dos valores é: " + soma );
        }
    }
}
