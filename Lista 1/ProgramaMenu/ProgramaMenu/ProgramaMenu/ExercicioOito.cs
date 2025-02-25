<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioOito
    {
        public static void Executar()
        {
            //Um algoritmo que leia 3 valores inteiros e diferentes
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            //Mostrar os valores em ordem decrescente
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("A ordem descrescente dos números são: \n\n");
            foreach (int i in numeros) Console.WriteLine(i);

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

namespace ProgramaMenu
{
    public class ExercicioOito
    {
        public static void Executar()
        {
            //Um algoritmo que leia 3 valores inteiros e diferentes
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            //Mostrar os valores em ordem decrescente
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("A ordem descrescente dos números são: \n\n");
            foreach (int i in numeros) Console.WriteLine(i);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
