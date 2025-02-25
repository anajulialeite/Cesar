<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaTres
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int Nvoltas, total = 0, media, Mtempo = 0, Mvolta;

            //Determine a quantidade de voltas
            Console.WriteLine("Digite o número de voltar");
            Nvoltas = Convert.ToInt32(Console.ReadLine());

            //Um programa que leia o tempo das N voltas, calcute e mostre na tela
            int[] tempos = new int[Nvoltas];
            for (int x = 0; x < Nvoltas; x++)
            {
                //Determine quantos segundos durou cada volta
                Console.WriteLine("****************************************");
                Console.WriteLine($"Digite o tempo da {x + 1}° volta (em segundos): ");
                tempos[x] = Convert.ToInt32(Console.ReadLine());
                total += tempos[x];
                if (tempos[x] < Mtempo || x == 0)
                {
                    Mtempo = tempos[x];
                    Mvolta = x + 1;
                }
            }
            media = total / Nvoltas;

            //Mostrar na tela: O melhor tempo, a volta em melhor tempo e o tempo médio de N voltas
            Console.WriteLine("****************************************");
            Console.WriteLine($"i. O melhor tempo foi: {Mtempo} segundos.");
            Console.WriteLine($"ii. Melhor volta foi: {Nvoltas}°");
            Console.WriteLine($"iii. A média do tempo foi: {media}");
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
    public class ExercicioCinquentaTres
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int Nvoltas, total = 0, media, Mtempo = 0, Mvolta;

            //Determine a quantidade de voltas
            Console.WriteLine("Digite o número de voltar");
            Nvoltas = Convert.ToInt32(Console.ReadLine());

            //Um programa que leia o tempo das N voltas, calcute e mostre na tela
            int[] tempos = new int[Nvoltas];
            for (int x = 0; x < Nvoltas; x++)
            {
                //Determine quantos segundos durou cada volta
                Console.WriteLine("****************************************");
                Console.WriteLine($"Digite o tempo da {x + 1}° volta (em segundos): ");
                tempos[x] = Convert.ToInt32(Console.ReadLine());
                total += tempos[x];
                if (tempos[x] < Mtempo || x == 0)
                {
                    Mtempo = tempos[x];
                    Mvolta = x + 1;
                }
            }
            media = total / Nvoltas;

            //Mostrar na tela: O melhor tempo, a volta em melhor tempo e o tempo médio de N voltas
            Console.WriteLine("****************************************");
            Console.WriteLine($"i. O melhor tempo foi: {Mtempo} segundos.");
            Console.WriteLine($"ii. Melhor volta foi: {Nvoltas}°");
            Console.WriteLine($"iii. A média do tempo foi: {media}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
