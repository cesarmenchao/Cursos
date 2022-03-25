using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Calculadora de Salario                  ");
            Console.WriteLine("Entre com o numnero do funcionario:");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe as horas trabalhadas:");
            int hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor por hora trabalhada:");
            double hrTrabalho = double.Parse(Console.ReadLine());

            double salario = hrTrabalho * hrs ;

            Console.WriteLine("O salario do funcionario este mês é de :" + salario.ToString("f2"));
        }
    }
}
