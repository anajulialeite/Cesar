using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteUm
    {
        public static void Executar()
        {
            //Declarando a variável
            int numero;

            //Verificando se os números são positivos ou negativos
            do

            {

                Console.WriteLine("Digite um Número, digite 0 para sair: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo");
                }
            //Mostrar resultado na tela
            } while (numero != 0);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
