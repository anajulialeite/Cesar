<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaSete
    {
        public static void Executar()
        {
            //Declarando a variável
            int opcao;
            string charOpcao;
            bool finalizar = false;
            int num1 = 0, num2 = 0;

            //Programa menu
            while (finalizar == false)
            {
                Console.WriteLine("Escolha uma das opções a baixo: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Substração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                opcao = Convert.ToInt32 (Console.ReadLine());

                Console.WriteLine("Digite o primeiro valor: ");
                num1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Menu de opções
                switch (opcao)
                {
                    //Soma
                    case 1:
                        Console.WriteLine($"Resultado de {num1} + {num2} = {num1 + num2}");
                        break;

                    //Subtração
                    case 2:
                        Console.WriteLine($"Resultado de {num1} - {num2} = {num1 - num2}");
                        break;

                    //Multiplicação
                    case 3:
                        Console.WriteLine($"Resultado de {num1} x {num2} = {num1 * num2}");
                        break;

                    //Divisão
                    case 4:
                        Console.WriteLine($"Resultado de {num1} / {num2} = {num1 / num2}");
                        break;
                }
                //S para continuar e N para finalizar
                Console.WriteLine("Deseja continuar? (s/n)");
                charOpcao = Console.ReadLine();
                //Mostrar o resultado na tela e finalizar programa
                if (string.ReferenceEquals(charOpcao, "N") || string.ReferenceEquals(charOpcao, "N")) ;
                {
                    finalizar = true;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
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
    public class ExercicioTrintaSete
    {
        public static void Executar()
        {
            //Declarando a variável
            int opcao;
            string charOpcao;
            bool finalizar = false;
            int num1 = 0, num2 = 0;

            //Programa menu
            while (finalizar == false)
            {
                Console.WriteLine("Escolha uma das opções a baixo: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Substração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                opcao = Convert.ToInt32 (Console.ReadLine());

                Console.WriteLine("Digite o primeiro valor: ");
                num1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Menu de opções
                switch (opcao)
                {
                    //Soma
                    case 1:
                        Console.WriteLine($"Resultado de {num1} + {num2} = {num1 + num2}");
                        break;

                    //Subtração
                    case 2:
                        Console.WriteLine($"Resultado de {num1} - {num2} = {num1 - num2}");
                        break;

                    //Multiplicação
                    case 3:
                        Console.WriteLine($"Resultado de {num1} x {num2} = {num1 * num2}");
                        break;

                    //Divisão
                    case 4:
                        Console.WriteLine($"Resultado de {num1} / {num2} = {num1 / num2}");
                        break;
                }
                //S para continuar e N para finalizar
                Console.WriteLine("Deseja continuar? (s/n)");
                charOpcao = Console.ReadLine();
                //Mostrar o resultado na tela e finalizar programa
                if (string.ReferenceEquals(charOpcao, "N") || string.ReferenceEquals(charOpcao, "N")) ;
                {
                    finalizar = true;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
