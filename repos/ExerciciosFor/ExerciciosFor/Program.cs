using System;
using System.Globalization;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercicio 01
            /* int x = int.Parse(Console.ReadLine());

             for (int i = 1; i <= x; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine(i);
                 }*/
            //--------------exercicio 02 ---------------------------------------------------------------------
            /*int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out"); */
            //--------------exercicio 03 -----------------------------------------------------------------------
            /* int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            } */
            //--------------exercicio 04 -----------------------------------------------------------------------
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}