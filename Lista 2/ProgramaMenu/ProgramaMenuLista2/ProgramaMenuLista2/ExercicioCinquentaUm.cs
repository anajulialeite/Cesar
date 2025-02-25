<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaUm
    {
        public static void Executar()
        {
            //Declarando a variável
            int qtdAlunos, notasP = 0;
            bool notasR = true;

            //Um progarama que leia a quantidade de alunos
            Console.WriteLine("Digite a quantidade de alunos: ");
            qtdAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            int[] notas = new int[qtdAlunos];

            //Calcule a média aritmética das notas
            for (int x = 0; x < qtdAlunos; x++)
            {
                Console.WriteLine($"Digite a nota do {x + 1} ° Aluno: ");
                notas[x] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //Contar quantos alunos tem nota acima de 7
                if (notas[x] > 7)
                {
                    notasP++;
                }
                //Contar quantos alunos tem nota acima de 5
                if (notas[x] > 5)
                {
                    notasR = false;
                }
            }
            if (notasR == false)
            {
                Console.WriteLine($"Existem {notasP} notas maiores que 7.");
            }
            else
            {
                //Se nenhum aluno tirar nota acima de 5, mostrar frase de efeito
                Console.WriteLine("Não existe nenhum aluno com nota acima de 5.");
            }
            Console.WriteLine();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaUm
    {
        public static void Executar()
        {
            //Declarando a variável
            int qtdAlunos, notasP = 0;
            bool notasR = true;

            //Um progarama que leia a quantidade de alunos
            Console.WriteLine("Digite a quantidade de alunos: ");
            qtdAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            int[] notas = new int[qtdAlunos];

            //Calcule a média aritmética das notas
            for (int x = 0; x < qtdAlunos; x++)
            {
                Console.WriteLine($"Digite a nota do {x + 1} ° Aluno: ");
                notas[x] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //Contar quantos alunos tem nota acima de 7
                if (notas[x] > 7)
                {
                    notasP++;
                }
                //Contar quantos alunos tem nota acima de 5
                if (notas[x] > 5)
                {
                    notasR = false;
                }
            }
            if (notasR == false)
            {
                Console.WriteLine($"Existem {notasP} notas maiores que 7.");
            }
            else
            {
                //Se nenhum aluno tirar nota acima de 5, mostrar frase de efeito
                Console.WriteLine("Não existe nenhum aluno com nota acima de 5.");
            }
            Console.WriteLine();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
