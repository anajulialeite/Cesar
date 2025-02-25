using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaDois
    {
        public static void Executar()
        {
            //Declarando a variável
            int numero, maior, menor;
            
            //Digite 0 para encerrar o programa
            Console.WriteLine("Digite 0 para sair!");
            Console.WriteLine();
            Console.WriteLine();

            //Mostrar o número digitado na tela
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            menor = numero;
            maior = numero;

            //Um programa que leia uma sequência de números
            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }


            } while (numero != 0);

            //Mostrar na tela o menor e o maior número
            Console.WriteLine($"\nO maior numero digitado é {menor} O menor numero digitado é {maior}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
