<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaOito
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int qtd = 0;
            double media = 0;

            //Comando para definir a quantidade de números que serão lidos e calculados
            Console.WriteLine("Digite a quantidade de números: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            //Um programa para armazenar em um vetor vários número inteiros e positivos
            Console.WriteLine("********************************");
            int[] numeros = new int[qtd];
            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite o valor {x + 1}: ");
                numeros[x] = Convert.ToInt32(Console.ReadLine());
                media += numeros[x];
            }
            //Calcule a média
            media = media / qtd;
            Array.Sort(numeros);

            //Mostrar na tela a média e o número maior
            Console.WriteLine("**********************************");
            Console.WriteLine($"A média dos valores é: {media} \nO maior valor é: {numeros[qtd - 1]}");
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
    public class ExercicioCinquentaOito
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int qtd = 0;
            double media = 0;

            //Comando para definir a quantidade de números que serão lidos e calculados
            Console.WriteLine("Digite a quantidade de números: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            //Um programa para armazenar em um vetor vários número inteiros e positivos
            Console.WriteLine("********************************");
            int[] numeros = new int[qtd];
            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite o valor {x + 1}: ");
                numeros[x] = Convert.ToInt32(Console.ReadLine());
                media += numeros[x];
            }
            //Calcule a média
            media = media / qtd;
            Array.Sort(numeros);

            //Mostrar na tela a média e o número maior
            Console.WriteLine("**********************************");
            Console.WriteLine($"A média dos valores é: {media} \nO maior valor é: {numeros[qtd - 1]}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
