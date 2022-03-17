using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            int anoNascimento = 1997;
            string meuNome = "Cesar";
            float altura = 1.85f;

                

                    
                    Console.WriteLine(meuNome);
                    Console.WriteLine(anoNascimento);
                    Console.WriteLine(altura);

            altura = 1.95f;

                    Console.WriteLine(altura);
            */

            //variaveis declaradas como var identificam automaticamente o tipo da variavel
            /*var testeVar = 123;  
            var testeVar2 = "cesar";

            Console.WriteLine(testeVar);

            testeVar = 221;

            Console.WriteLine(testeVar);
            */

            Console.WriteLine("informe o nome do  Usuario");
            string usuario = Console.ReadLine();
            Console.Write("O nome do usuario é: ");
            Console.WriteLine(usuario);




            Console.ReadLine();
            

        }
    }
}
