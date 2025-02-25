<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaSete
    {
        public static void Executar()
        {
            //Declarando a variável
            string frase, vogais = "aeiouAEIOU", StringVogais = "";

            //comando para escrever uma frase
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] ArrayChars = frase.ToCharArray();

            //Um progarma que leia uma frase e mostre somente as vogais
            for (int x = 0; x < ArrayChars.Length; x++)
            {



                if (vogais.Contains("" + ArrayChars[x]))
                {
                    StringVogais += ArrayChars[x];
                }  
            }
            //Mostre as vogais na tela
            Console.WriteLine("Nova frase: " + StringVogais);
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
    public class ExercicioCinquentaSete
    {
        public static void Executar()
        {
            //Declarando a variável
            string frase, vogais = "aeiouAEIOU", StringVogais = "";

            //comando para escrever uma frase
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] ArrayChars = frase.ToCharArray();

            //Um progarma que leia uma frase e mostre somente as vogais
            for (int x = 0; x < ArrayChars.Length; x++)
            {



                if (vogais.Contains("" + ArrayChars[x]))
                {
                    StringVogais += ArrayChars[x];
                }  
            }
            //Mostre as vogais na tela
            Console.WriteLine("Nova frase: " + StringVogais);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
