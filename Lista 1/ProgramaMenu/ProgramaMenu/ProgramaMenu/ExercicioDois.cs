<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioDois
    {
        /// <summary>
        /// Essa parte do código leva que possibilita chamar essa classe Exercicio_02 em outra classe, tem que está public não esqueça
        /// </summary>
        public static void Executar()
        {
            //Mostrar o nome
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            //Mostrar se o sexo é Feminino ou Masculino
            Console.WriteLine("Digite F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());

            //Mostrar o Estado Civil
            Console.WriteLine("Escreva o estado civil: ");
            string estado = Console.ReadLine();

            //Mostrar se é casado ou não e mostrar uma frase de efeito para a escolha
            if (( sexo == 'M') && (estado == "Casado"))
            {
                Console.WriteLine("Quantos anos você tem de casamento? ");
                int casad = int.Parse(Console.ReadLine());
                Console.WriteLine("Seu nome é: {0} seu sexo {1} e você tem {2} anos de casado: ", nome, sexo, casad);
            }
            else
            {
                Console.WriteLine("{0} Acredite, sua hora vai chegar!", nome);
            }
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
    public class ExercicioDois
    {
        /// <summary>
        /// Essa parte do código leva que possibilita chamar essa classe Exercicio_02 em outra classe, tem que está public não esqueça
        /// </summary>
        public static void Executar()
        {
            //Mostrar o nome
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            //Mostrar se o sexo é Feminino ou Masculino
            Console.WriteLine("Digite F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());

            //Mostrar o Estado Civil
            Console.WriteLine("Escreva o estado civil: ");
            string estado = Console.ReadLine();

            //Mostrar se é casado ou não e mostrar uma frase de efeito para a escolha
            if (( sexo == 'M') && (estado == "Casado"))
            {
                Console.WriteLine("Quantos anos você tem de casamento? ");
                int casad = int.Parse(Console.ReadLine());
                Console.WriteLine("Seu nome é: {0} seu sexo {1} e você tem {2} anos de casado: ", nome, sexo, casad);
            }
            else
            {
                Console.WriteLine("{0} Acredite, sua hora vai chegar!", nome);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
