<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaDois
    {
        public static void Executar()
        {
            //Declarando as variáveis
            //100 posições de vetores
            int numPosicoes = 100, x = 0;
            int[] num = new int[numPosicoes];
            int vnum1 = 0, vnum3 = 0, vnum4 = 0, aux = 1;

            //Encerrando o programa
            Console.WriteLine("Digite -1 para encerrar");
            Console.WriteLine();
            Console.WriteLine();

            //Um programa que leia um vetor de números inteiros e positivos 
            do
            {
                Console.WriteLine($"Digite o {aux++}° número: ");
                num[x] = Convert.ToInt32(Console.ReadLine());
                if (num[x] == 1)
                {
                    vnum1++;
                }
                if (num[x] == 3)
                {
                    vnum3++;
                }
                if (num[x] == 4)
                {
                    vnum4++;
                }
                x++;

              //Sair do programa digitando -1
            } while (num[x - 1] != -1 && x < numPosicoes);

            //Mostre na tela toda vez que aparecer o número 1, 3 e 4
            Console.WriteLine($"Quantidades: \nNúmero 1 = {vnum1} \nNúmero 3 = {vnum3} \nNúmero 4 = {vnum4}");
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
    public class ExercicioCinquentaDois
    {
        public static void Executar()
        {
            //Declarando as variáveis
            //100 posições de vetores
            int numPosicoes = 100, x = 0;
            int[] num = new int[numPosicoes];
            int vnum1 = 0, vnum3 = 0, vnum4 = 0, aux = 1;

            //Encerrando o programa
            Console.WriteLine("Digite -1 para encerrar");
            Console.WriteLine();
            Console.WriteLine();

            //Um programa que leia um vetor de números inteiros e positivos 
            do
            {
                Console.WriteLine($"Digite o {aux++}° número: ");
                num[x] = Convert.ToInt32(Console.ReadLine());
                if (num[x] == 1)
                {
                    vnum1++;
                }
                if (num[x] == 3)
                {
                    vnum3++;
                }
                if (num[x] == 4)
                {
                    vnum4++;
                }
                x++;

              //Sair do programa digitando -1
            } while (num[x - 1] != -1 && x < numPosicoes);

            //Mostre na tela toda vez que aparecer o número 1, 3 e 4
            Console.WriteLine($"Quantidades: \nNúmero 1 = {vnum1} \nNúmero 3 = {vnum3} \nNúmero 4 = {vnum4}");
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
