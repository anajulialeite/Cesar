<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaSete
    {
        public static void Executar()
        {
            
            
            int[] vetor = new int[10];
            //Declarando a variável
            int maiores = 0, menores = 0, iguais = 0, numerox = 0;
            

            //Um programa que leia 10 número inetiros positivos e maior que zero
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° Número do vetor: ");
                vetor[x] = int.Parse(Console.ReadLine());
            }
            //ler o vetor e o númerox
            Console.WriteLine("Números maiores que o número x: \n");
            for (int y = 0; y < 10; y++)
            {
                if (vetor[y] > numerox)
                {
                    Console.WriteLine(vetor[y]);
                    maiores++;
                }
                else if (vetor[y] == numerox)
                {
                    iguais++;
                }
                else
                {
                    menores++;
                }
            }

            //Mostrar na tela o vetor e informar se é maior igual ou menor que o x
            Console.WriteLine("\nmaiores: " + maiores + "\nIguais: " + iguais + "\nmenores: " + menores + "\n");
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
    public class ExercicioQuarentaSete
    {
        public static void Executar()
        {
            
            
            int[] vetor = new int[10];
            //Declarando a variável
            int maiores = 0, menores = 0, iguais = 0, numerox = 0;
            

            //Um programa que leia 10 número inetiros positivos e maior que zero
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° Número do vetor: ");
                vetor[x] = int.Parse(Console.ReadLine());
            }
            //ler o vetor e o númerox
            Console.WriteLine("Números maiores que o número x: \n");
            for (int y = 0; y < 10; y++)
            {
                if (vetor[y] > numerox)
                {
                    Console.WriteLine(vetor[y]);
                    maiores++;
                }
                else if (vetor[y] == numerox)
                {
                    iguais++;
                }
                else
                {
                    menores++;
                }
            }

            //Mostrar na tela o vetor e informar se é maior igual ou menor que o x
            Console.WriteLine("\nmaiores: " + maiores + "\nIguais: " + iguais + "\nmenores: " + menores + "\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
