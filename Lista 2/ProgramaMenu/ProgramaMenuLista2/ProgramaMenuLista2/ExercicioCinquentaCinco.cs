<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaCinco
    {
        public static void Executar()
        {
            //Declarando as variáveis
            string frase;
            string NovaFrase = " ";

            //Um programa que leia uma frase de até 50 caracteres e mostres também a quantidade de espaços em branco na frase
            do
            {
                Console.WriteLine("Digite uma frase (Limite de 50 caracteres: ");
                frase = Console.ReadLine();
            } while (frase.Length > 50);

            char[] ArrayChars = frase.ToCharArray();

            for (int x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != ' ')
                {
                    NovaFrase = NovaFrase + ArrayChars[x];
                }
            }
            //Mostre na tela a frase + espaços em branco
            Console.WriteLine($"Nova frase: {NovaFrase}");
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
    public class ExercicioCinquentaCinco
    {
        public static void Executar()
        {
            //Declarando as variáveis
            string frase;
            string NovaFrase = " ";

            //Um programa que leia uma frase de até 50 caracteres e mostres também a quantidade de espaços em branco na frase
            do
            {
                Console.WriteLine("Digite uma frase (Limite de 50 caracteres: ");
                frase = Console.ReadLine();
            } while (frase.Length > 50);

            char[] ArrayChars = frase.ToCharArray();

            for (int x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != ' ')
                {
                    NovaFrase = NovaFrase + ArrayChars[x];
                }
            }
            //Mostre na tela a frase + espaços em branco
            Console.WriteLine($"Nova frase: {NovaFrase}");
            Console.ReadLine();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
