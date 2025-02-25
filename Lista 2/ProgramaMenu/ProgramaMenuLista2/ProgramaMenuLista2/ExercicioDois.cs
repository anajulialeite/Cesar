<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{   
    public class ExercicioDois
    {
        public static void Executar()
        {
            //Declarando a Variável
            double cotacao_dolar, valor_dolar, valor_real;

            //Leia a cotação, valor e converter Dólar para Real
            Console.WriteLine("Conversor de moeda");

            Console.WriteLine("Digite a cotação do Dólar: ");
            cotacao_dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em Dólar: ");
            valor_dolar = double.Parse(Console.ReadLine());

            //Fórmula
            valor_real = cotacao_dolar * valor_dolar;

            //Mostrar na tela
            Console.WriteLine("O valor em reais é: " + valor_dolar);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{   
    public class ExercicioDois
    {
        public static void Executar()
        {
            //Declarando a Variável
            double cotacao_dolar, valor_dolar, valor_real;

            //Leia a cotação, valor e converter Dólar para Real
            Console.WriteLine("Conversor de moeda");

            Console.WriteLine("Digite a cotação do Dólar: ");
            cotacao_dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em Dólar: ");
            valor_dolar = double.Parse(Console.ReadLine());

            //Fórmula
            valor_real = cotacao_dolar * valor_dolar;

            //Mostrar na tela
            Console.WriteLine("O valor em reais é: " + valor_dolar);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
