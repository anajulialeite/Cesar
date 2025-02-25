using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaNove
    {
        public static void Executar()
        {
            //Declarando a variável
            int numero;
            bool parar = false;
            char letra;

            do
            {
                //Faça um programa que leia um número inteiro
                Console.WriteLine("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    //Mostre uma mensagem indicando se o número é par
                    Console.WriteLine("O número é par.\n");
                }
                else
                {
                    //Impar
                    Console.WriteLine("O número não é par.\n");
                }
                if (numero < 0)
                {
                    //positivo
                    Console.WriteLine("O número é positivo.\n");
                }
                else
                {
                    //negativo
                    Console.WriteLine("O número é positivo.\n");
                }
                //Mostrar o resultado na tela e mostrar se S para sair ou N para continuar rodando o programa
                Console.WriteLine("Deseja sair? (s/N)? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S') ;
                {
                    parar = true;
                }

            } while (parar == false);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
