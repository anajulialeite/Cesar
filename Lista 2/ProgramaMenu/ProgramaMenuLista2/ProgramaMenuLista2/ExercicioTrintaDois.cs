using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaDois
    {
        public static void Executar()
        {
            //Declarando a varíável
            int Numero, Resultado = 0;

            do
            {
                //Um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
                //Impares a partir do número informado pelo usuário menor que 10 e maior que 0
                Console.WriteLine("Digite um número maior que 0 e menor que 10: ");
                Numero = int.Parse(Console.ReadLine());
            } while (Numero <= 0 || Numero >= 10);

            for (int x = Numero; x < 40 + Numero; x++)
            {
                if (x % 2 == 1)
                {
                    Resultado += x * x;
                }
            }
            //Mostrar o resultado na tela
            Console.WriteLine("O resultado da soma dos quadrados dos 20 primeiros números inteiros positivos, impares a partir do número informado é: " + Resultado);
            Console.ReadKey();
            Console.Clear();
        }  
    }
}
