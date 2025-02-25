<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaSeis
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int[] NumInt = new int[50];
            int qtdPares = 0, x = 0;

            //Um programa que leia um vetor de números inteiros, positivos e de 50 posições
            while (x < 50)
            {
                Console.WriteLine($"Digite um {x + 1}° número: ");
                NumInt[x] = Convert.ToInt32(Console.ReadLine());
                if (NumInt[x] >= 0)
                {
                    if (NumInt[x] % 5 == 0 && NumInt[x] % 2 == 0)
                    {
                        qtdPares++;
                    }
                    x++;
                }
            }
            //Mostrar na tela a quantidade de números pares e múltiplos de cinco
            Console.WriteLine($"\nA quantidade de números pares e multiplos de 5 é: {qtdPares}");
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
    public class ExercicioCinquentaSeis
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int[] NumInt = new int[50];
            int qtdPares = 0, x = 0;

            //Um programa que leia um vetor de números inteiros, positivos e de 50 posições
            while (x < 50)
            {
                Console.WriteLine($"Digite um {x + 1}° número: ");
                NumInt[x] = Convert.ToInt32(Console.ReadLine());
                if (NumInt[x] >= 0)
                {
                    if (NumInt[x] % 5 == 0 && NumInt[x] % 2 == 0)
                    {
                        qtdPares++;
                    }
                    x++;
                }
            }
            //Mostrar na tela a quantidade de números pares e múltiplos de cinco
            Console.WriteLine($"\nA quantidade de números pares e multiplos de 5 é: {qtdPares}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
