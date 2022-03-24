using System;

public class Class1
{
    public Class1()
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine(produto1 + ", cujo o preço é " preco1);
        Console.WriteLine(produto2 + ", cujo p preço é " preco2);


        Console.WriteLine("Medida com oito casas decimais: " medida);
        Console.WriteLine("Arredondado (três casas decimais )"{ medida:f3});


    }
}
