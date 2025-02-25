<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaQuatro
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int[] A = new int[5], B = new int[8];
            IList<int> C = new List<int>();
            int W = 0, aux = 1;

            //Um programa que leia os vetores em comuns com A e B e mostrar na tela no vetor C
            for (int x = 0; x < 5; x++)
            {
                //Declare 5 vetores em A
                Console.WriteLine($"Digite um número para o vetor A: ");
                A[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int x = 0; x < 8; x++)
            {
                //Declare 8 vetores em B
                Console.Write($"Digite um {aux++}° Número para o vetor B: ");
                B[x] = Convert.ToInt32(Console.ReadLine());
                for (int y = 0; y < 5; y++)
                {
                    if (B[x] == A[y])
                    {
                        C.Insert(W, B[x]);
                        W++;
                    }
                }
            }
            //Mostrar na tela os vetor em comuns na variável C
            Console.Write("Números comuns: ");
            for (int x = 0; x < C.Count; x++)
            {
                Console.WriteLine(C[x] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
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
    public class ExercicioCinquentaQuatro
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int[] A = new int[5], B = new int[8];
            IList<int> C = new List<int>();
            int W = 0, aux = 1;

            //Um programa que leia os vetores em comuns com A e B e mostrar na tela no vetor C
            for (int x = 0; x < 5; x++)
            {
                //Declare 5 vetores em A
                Console.WriteLine($"Digite um número para o vetor A: ");
                A[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int x = 0; x < 8; x++)
            {
                //Declare 8 vetores em B
                Console.Write($"Digite um {aux++}° Número para o vetor B: ");
                B[x] = Convert.ToInt32(Console.ReadLine());
                for (int y = 0; y < 5; y++)
                {
                    if (B[x] == A[y])
                    {
                        C.Insert(W, B[x]);
                        W++;
                    }
                }
            }
            //Mostrar na tela os vetor em comuns na variável C
            Console.Write("Números comuns: ");
            for (int x = 0; x < C.Count; x++)
            {
                Console.WriteLine(C[x] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
