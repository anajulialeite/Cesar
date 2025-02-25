using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaTres
    {
        public static void Executar()
        {
            //Declarando a variável
            int QuantAlunos;
            string matricula;
            double media = 0;

            //Escolha quantos alunos
            Console.WriteLine("Digite a quantidade de alunos: ");
            QuantAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] aluno = new int[QuantAlunos];

            //Escolha a matrícula do aluno e a nota
            for (int x = 0; x < QuantAlunos; x++)
            {
                Console.WriteLine("Digite o número da matrícula do aluno: ");
                matricula = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                media += nota;
            }
            //Mostrar na tela a média desses alunos
            Console.WriteLine($"A média da turma foi de {string.Format("{0:C1}", (media / QuantAlunos))}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
