using System;
using System.Globalization;

namespace udemy
{
    class Program
    {
        static void Main(string[] args)
        {/*
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo o preço é " + preco1);
            Console.WriteLine(produto2 + ", cujo p preço é " + preco2);


            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondado (três casas decimais )" + medida.ToString("f3"));
            Console.WriteLine("Separador decimal invariant " + medida.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
