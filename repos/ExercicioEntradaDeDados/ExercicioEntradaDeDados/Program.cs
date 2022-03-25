using System;
using System.Globalization;
namespace ExercicioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string meuNome = Console.ReadLine();
            Console.WriteLine(meuNome);


            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);


            Console.WriteLine("Entre com o preço dos produtos");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));


            Console.WriteLine("Entre com seu ultimo nome, idade, altura.(na mesma linha)");
            string[] linha = Console.ReadLine().Split(' ');
            string nome = (linha[0]);
            int idade = int.Parse(linha[1]);
            double altura = double.Parse(linha[2],CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));






        }
    }
}
