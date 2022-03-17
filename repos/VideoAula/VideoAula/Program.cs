using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esta puxando a funçao soma la em baixo
            /*int conta = Soma(20, 30);
            int resultado = Soma(99, 584);

            Console.WriteLine(conta);
            Console.WriteLine(resultado);
            Console.ReadLine();*/

            //array simples 
            /*
            string[] lista = new string [5] {
                    "robson",//0
                    "ronaldo",//1
                    "clovis",//2
                    "cesar",//3
                    "mari",//4

            };

            Console.WriteLine(lista[3]);

            Console.ReadLine();
            */

            //switch basico usando string
            string cor = "cinza";
            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua cor é vermelha");
                    break;

                case "azul":
                    Console.WriteLine("Sua cor é azul");
                    break ;
                case "roxo":
                    Console.WriteLine("Sua cor é roxa");
                    break;
                default:
                    Console.WriteLine("Sua cor nao se encadra");
                    break;

                    
            }
            Console.ReadLine();
        }

         
        //static int Soma(int a, int b) {

          //  int resultadoSoma = a + b;
            //return resultadoSoma;
              //  }
      
    }
}
