using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NumeroPrograma = -2;
  
            do
            {
                Console.WriteLine("Escolha o programa que deseja rodar");
                NumeroPrograma = int.Parse(Console.ReadLine());

                switch (NumeroPrograma)
                {
                    case 1:
                        ExercicioUm.Executar();
                        break;

                    case 2:
                        ExercicioDois.Executar();
                        break;

                    case 3:
                        ExercicioTres.Executar();
                        break;
                    
                    case 4:
                        ExercicioQuatro.Executar();
                        break;

                    case 5:
                        ExercicioCinco.Executar();
                        break;

                    case 6:
                        ExercicioSeis.Executar();
                        break;

                    case 7:
                        ExercicioSete.Executar();
                        break;

                    case 8:
                        ExercicioOito.Executar();
                        break;

                    case 9:
                        ExercicioNove.Executar();
                        break;

                    case 10:
                        ExercicioDez.Executar();
                        break;

                    case 11:
                        ExercicioOnze.Executar();
                        break;

                    case 12:
                        ExercicioDoze.Executar();
                        break;

                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (NumeroPrograma != -1);
        }
    }
}
