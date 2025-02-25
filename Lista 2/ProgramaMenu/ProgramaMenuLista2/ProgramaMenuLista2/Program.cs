<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NumeroPrograma = -2;

            //Um programa Menu para ajudar o tio César a corrigir nossos exercícios <3
            do
            {
                //Digite o número correspondente ao exercício
                Console.WriteLine("Escolha o programa que deseja rodar");
                NumeroPrograma = int.Parse(Console.ReadLine());

                //Menu de opções
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

                    case 13:
                        ExercicioTreze.Executar();
                        break;

                    case 14:
                        ExercicioQuatorze.Executar();
                        break;

                    case 15:
                        ExercicioQuinze.Executar();
                        break;

                    case 16:
                        ExercicioDezesseis.Executar();
                        break;

                    case 17:
                        ExercicioDezessete.Executar();
                        break;

                    case 18:
                        ExercicioDezoito.Executar();
                        break;

                    case 19:
                        ExercicioDezenove.Executar();
                        break;

                    case 20:
                        ExercicioVinte.Executar();
                        break;

                    case 21:
                        ExercicioVinteUm.Executar();
                        break;

                    case 22:
                        ExercicioVinteDois.Executar();
                        break;

                    case 23:
                        ExercicioVinteTres.Executar();
                        break;

                    case 24:
                        ExercicioVinteQuatro.Executar();
                        break;

                    case 25:
                        ExercicioVinteCinco.Executar();
                        break;

                    case 26:
                        ExercicioVinteSeis.Executar();
                        break;

                    case 27:
                        ExercicioVinteSete.Executar();
                        break;

                    case 28:
                        ExercicioVinteOito.Executar();
                        break;

                    case 29:
                        ExercicioVinteNove.Executar();
                        break;

                    case 30:
                        ExercicioTrinta.Executar();
                        break;

                    case 31:
                        ExercicioTrintaUm.Executar();
                        break;

                    case 32:
                        ExercicioTrintaDois.Executar();
                        break;

                    case 33:
                        ExercicioTrintaTres.Executar();
                        break;

                    case 34:
                        ExercicioTrintaQuatro.Executar();
                        break;

                    case 35:
                        ExercicioTrintaCinco.Executar();
                        break;

                    case 36:
                        ExercicioTrintaSeis.Executar();
                        break;

                    case 37:
                        ExercicioTrintaSete.Executar();
                        break;

                    case 38:
                        ExercicioTrintaOito.Executar();
                        break;

                    case 39:
                        ExercicioTrintaNove.Executar();
                        break;

                    case 40:
                        ExercicioQuarenta.Executar();
                        break;

                    case 41:
                        ExercicioQuarentaUm.Executar();
                        break;

                    case 42:
                        ExercicioQuarentaDois.Executar();
                        break;

                    case 43:
                        ExercicioQuarentaTres.Executar();
                        break;

                    case 44:
                        ExercicioQuarentaQuatro.Executar();
                        break;

                    case 45:
                        ExercicioQuarentaCinco.Executar();
                        break;

                    case 46:
                        ExercicioQuarentaSeis.Executar();
                        break;

                    case 47:
                        ExercicioQuarentaSete.Executar();
                        break;

                    case 48:
                        ExercicioQuarentaOito.Executar();
                        break;

                    case 49:
                        ExercicioQuarentaNove.Executar();
                        break;

                    case 50:
                        ExercicioCinquenta.Executar();
                        break;

                    case 51:
                        ExercicioCinquentaUm.Executar();
                        break;

                    case 52:
                        ExercicioCinquentaDois.Executar();
                        break;

                    case 53:
                        ExercicioCinquentaTres.Executar();
                        break;

                    case 54:
                        ExercicioCinquentaQuatro.Executar();
                        break;

                    case 55:
                        ExercicioCinquentaCinco.Executar();
                        break;

                    case 56:
                        ExercicioCinquentaSeis.Executar();
                        break;

                    case 57:
                        ExercicioCinquentaSete.Executar();
                        break;

                    case 58:
                        ExercicioCinquentaOito.Executar();
                        break;

                    case 59:
                        ExercicioCinquentaNove.Executar();
                        break;

                    case 60:
                        ExercicioSessenta.Executar();
                        break;

                    case 61:
                        ExercicioSessentaUm.Executar();
                        break;

                    case 62:
                        ExercicioSessentaDois.Executar();
                        break;

                    case 63:
                        ExercicioSessentaTres.Executar();
                        break;

                    case 64:
                        ExercicioSessentaQuatro.Executar();
                        break;

                    //Finalizar o menu de opções
                    default:
                        break;
                }

                //Mostrar o resultado na tela
                Console.ReadLine();
            } while (NumeroPrograma != -1);
        }       
    }           
}//Obrigada por ter me ensinado na faculdade e fora dela, ter tirado seu tempo de descanço para tirar minhas dúvidas e as dos meus colegas, um grande abraço! <3
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NumeroPrograma = -2;

            //Um programa Menu para ajudar o tio César a corrigir nossos exercícios <3
            do
            {
                //Digite o número correspondente ao exercício
                Console.WriteLine("Escolha o programa que deseja rodar");
                NumeroPrograma = int.Parse(Console.ReadLine());

                //Menu de opções
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

                    case 13:
                        ExercicioTreze.Executar();
                        break;

                    case 14:
                        ExercicioQuatorze.Executar();
                        break;

                    case 15:
                        ExercicioQuinze.Executar();
                        break;

                    case 16:
                        ExercicioDezesseis.Executar();
                        break;

                    case 17:
                        ExercicioDezessete.Executar();
                        break;

                    case 18:
                        ExercicioDezoito.Executar();
                        break;

                    case 19:
                        ExercicioDezenove.Executar();
                        break;

                    case 20:
                        ExercicioVinte.Executar();
                        break;

                    case 21:
                        ExercicioVinteUm.Executar();
                        break;

                    case 22:
                        ExercicioVinteDois.Executar();
                        break;

                    case 23:
                        ExercicioVinteTres.Executar();
                        break;

                    case 24:
                        ExercicioVinteQuatro.Executar();
                        break;

                    case 25:
                        ExercicioVinteCinco.Executar();
                        break;

                    case 26:
                        ExercicioVinteSeis.Executar();
                        break;

                    case 27:
                        ExercicioVinteSete.Executar();
                        break;

                    case 28:
                        ExercicioVinteOito.Executar();
                        break;

                    case 29:
                        ExercicioVinteNove.Executar();
                        break;

                    case 30:
                        ExercicioTrinta.Executar();
                        break;

                    case 31:
                        ExercicioTrintaUm.Executar();
                        break;

                    case 32:
                        ExercicioTrintaDois.Executar();
                        break;

                    case 33:
                        ExercicioTrintaTres.Executar();
                        break;

                    case 34:
                        ExercicioTrintaQuatro.Executar();
                        break;

                    case 35:
                        ExercicioTrintaCinco.Executar();
                        break;

                    case 36:
                        ExercicioTrintaSeis.Executar();
                        break;

                    case 37:
                        ExercicioTrintaSete.Executar();
                        break;

                    case 38:
                        ExercicioTrintaOito.Executar();
                        break;

                    case 39:
                        ExercicioTrintaNove.Executar();
                        break;

                    case 40:
                        ExercicioQuarenta.Executar();
                        break;

                    case 41:
                        ExercicioQuarentaUm.Executar();
                        break;

                    case 42:
                        ExercicioQuarentaDois.Executar();
                        break;

                    case 43:
                        ExercicioQuarentaTres.Executar();
                        break;

                    case 44:
                        ExercicioQuarentaQuatro.Executar();
                        break;

                    case 45:
                        ExercicioQuarentaCinco.Executar();
                        break;

                    case 46:
                        ExercicioQuarentaSeis.Executar();
                        break;

                    case 47:
                        ExercicioQuarentaSete.Executar();
                        break;

                    case 48:
                        ExercicioQuarentaOito.Executar();
                        break;

                    case 49:
                        ExercicioQuarentaNove.Executar();
                        break;

                    case 50:
                        ExercicioCinquenta.Executar();
                        break;

                    case 51:
                        ExercicioCinquentaUm.Executar();
                        break;

                    case 52:
                        ExercicioCinquentaDois.Executar();
                        break;

                    case 53:
                        ExercicioCinquentaTres.Executar();
                        break;

                    case 54:
                        ExercicioCinquentaQuatro.Executar();
                        break;

                    case 55:
                        ExercicioCinquentaCinco.Executar();
                        break;

                    case 56:
                        ExercicioCinquentaSeis.Executar();
                        break;

                    case 57:
                        ExercicioCinquentaSete.Executar();
                        break;

                    case 58:
                        ExercicioCinquentaOito.Executar();
                        break;

                    case 59:
                        ExercicioCinquentaNove.Executar();
                        break;

                    case 60:
                        ExercicioSessenta.Executar();
                        break;

                    case 61:
                        ExercicioSessentaUm.Executar();
                        break;

                    case 62:
                        ExercicioSessentaDois.Executar();
                        break;

                    case 63:
                        ExercicioSessentaTres.Executar();
                        break;

                    case 64:
                        ExercicioSessentaQuatro.Executar();
                        break;

                    //Finalizar o menu de opções
                    default:
                        break;
                }

                //Mostrar o resultado na tela
                Console.ReadLine();
            } while (NumeroPrograma != -1);
        }       
    }           
}//Obrigada por ter me ensinado na faculdade e fora dela, ter tirado seu tempo de descanço para tirar minhas dúvidas e as dos meus colegas, um grande abraço! <3
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
