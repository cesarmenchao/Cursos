using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAula
{
    internal class Program
    {
        enum Opcao { Incluir = 1, Excluir, Alterar, Listar, Atualizar }
        //enum enumeraçao de valores
        //  enum carro {palio, gol, fusca, variant }

        static void Main(string[] args)
        {
            //       carro carroJulio = carro.palio; //puxei o enum e o valor dele com o ponto
            //       Console.WriteLine((int)carroJulio); // com o parenteses informei parar puxar o valor inteiro da variavel carroJulio, convertendo de string para o valor da enumeraçao do enum.

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
            /*  string cor = "cinza";
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


              }*/

            Console.WriteLine("Selecione um das opções abaixo");
            Console.WriteLine("1-Incluir\n2-Excluir\n3-Alterar\n4-Listar\n5-Atualizar");
                int index = int.Parse(Console.ReadLine());
                 Opcao opcaoSelecionada = (Opcao)index;
             switch (opcaoSelecionada)
            {
                case Opcao.Incluir:
                    Console.WriteLine("Você quer incluir algo!!");
                    break;
                case Opcao.Excluir:
                    Console.WriteLine("Oque deseja excluir?");
                    break;
                case Opcao.Alterar:
                    Console.WriteLine("Oque deseja incluir?");
                    break;

                default:
                    Console.WriteLine("Opçao nao encontrada!!");
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
