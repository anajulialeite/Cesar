using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroPrograma = -2;

            do
            {
                Console.WriteLine("Escolha o progrma que deseja rodar");
                NumeroPrograma = int.Parse(Console.ReadLine());

                switch (NumeroPrograma)
                {
                    case 1:
                        ApostilaUm.Executar();
                        break;

                    case 2:
                        ApostilaDois.Executar();
                        break;
                    
                    case 3:
                        ApostilaTres.Executar();
                        break;

                    case 4:
                        ApostilaQuatro.Executar();
                        break;

                    case 5:
                        ApostilaCinco.Executar();
                        break;

                   default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }   while (NumeroPrograma != -1);
        }
    }
}

