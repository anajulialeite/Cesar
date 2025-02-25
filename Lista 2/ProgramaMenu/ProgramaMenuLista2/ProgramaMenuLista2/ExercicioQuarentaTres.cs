using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaTres
    {
        public static void Executar()
        {
            //Declarando as variáveis
            decimal graosCasa = 1;
            decimal soma = 0;

            //Mostrar os alimentos por casa
            for (int x = 1; x <= 64; x++)
            {
                graosCasa = graosCasa * 2;
                soma = soma + graosCasa;
                Console.WriteLine("{0} {1}", x, soma);
            }

            //Mostrar o resultado na tela
            Console.WriteLine("\nA quantidade de grãos é: {0} ", soma);

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
