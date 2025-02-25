using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaOito
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int numCandidatas = 20;
            int aptas = 0;
            string[] nome = new string[numCandidatas];
            int[] idade = new int[numCandidatas];

            //Um programa que encontre dentre 20 candidatas entre 18 a 20 anos 
            for (int x = 0; x < numCandidatas; x++)
            {
                Console.WriteLine($"Digite o nome da {x + 1}ª Candidata: ");
                nome[x] = Console.ReadLine();

                Console.WriteLine($"Digite a idade da {x + 1}ª Candidata: ");
                idade[x] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (idade[x] >= 18 && idade[x] < 21)
                {
                    aptas++;
                }
            }

            //Imprima e mostra na tela o vetor 
            string[] nome_aptas = new string[aptas];
            int[] idade_aptas = new int[aptas];

            int y = 0;
            for (int x = 0; x < numCandidatas; x++)
            {
                if (idade[x] >= 18 && idade[x] < 22)
                {

                    nome_aptas[y] = nome[x];
                    idade_aptas[y] = idade[x];
                    y++;
                }
            }
            //O nome da candata apta
            Console.WriteLine("Candidatas aptas:");
            for (int x = 0; x < aptas; x++)
            {
                //mostra na tela
                Console.WriteLine("Nome: {0,-30} \tIdade: {1:D}", nome_aptas[x], idade_aptas[x]);
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
        
        
        
        
    

