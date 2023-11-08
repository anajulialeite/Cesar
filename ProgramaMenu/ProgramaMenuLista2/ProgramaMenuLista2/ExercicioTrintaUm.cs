using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaUm
    {
        public static void Executar()
        {
            //Declarando a variável
            int numero = 0, QuantPar = 0, QuantImpar = 0;

            //Exiba quantos números pares e ímpares foram lidos
            while (numero >= 0)
            {
                Console.WriteLine("Digite um número (Números negativos finalizam): ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        QuantPar++;
                    }
                    else
                    {
                        QuantImpar++;
                    }

                }
            
            }
            //Mostrar o resultado na tela
            Console.WriteLine("Quantidade de números pares: " + QuantPar + " Quantidade de números ímpares: " + QuantImpar);
            Console.ReadKey();
            Console.Clear();

        }
    }
}
