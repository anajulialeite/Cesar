using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteOito
    {
        public static void Executar()
        {
            //Ler os números ímpares de 100 a 200
            for  (int x = 100; x <= 200; x++)
            {
                if (x % 2 == 1)
                {
                    //Mostrar o resultado na tela
                    Console.WriteLine(x);
                }
            }
        }
    }
}
