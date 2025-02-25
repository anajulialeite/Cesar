<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioDoze
    {
        public static void Executar()
        {
            //Declarando a variável
            string linha;
            double media_aproveitamento;
            int numero;
            int nota1, nota2, nota3;
            string avaliacao_final;

            //Número do aluno
            Console.Write("Informe o numero do aluno = ");
            linha = Console.ReadLine();
            numero = Int32.Parse(linha);

            //Nota da 1° prova
            Console.Write("Informe a nota1 = ");
            linha = Console.ReadLine();
            nota1 = Int32.Parse(linha);

            //Nota da 2° prova
            Console.Write("Informe a nota2 = ");
            linha = Console.ReadLine();
            nota2 = Int32.Parse(linha);

            //Nota da 3° prova
            Console.Write("Informe a nota3 = ");
            linha = Console.ReadLine();
            nota3 = Int32.Parse(linha);

            //Fórmula
            media_aproveitamento = (nota1 + (2 * nota2) + (3 * nota3)) / 7;

            //Mostrando as opções
            if (media_aproveitamento >= 90)
            {
                avaliacao_final = "A - Parabéns, você está Aprovado";
            }
            else
            {
                if (media_aproveitamento >= 75 && media_aproveitamento < 90)
                {
                    avaliacao_final = "B - Parabéns, você está Aprovado";
                }
                else
                {
                    if (media_aproveitamento >= 60 && media_aproveitamento < 75)
                    {
                        avaliacao_final = "C - Parabéns, você está Aprovado";
                    }
                    else
                    {
                        if (media_aproveitamento >= 40 && media_aproveitamento < 60)
                        {
                            avaliacao_final = "D - Precisa estudar, você está Reprovado";
                        }
                        else
                        {
                            avaliacao_final = "E - Precisa estudar, você está Reprovado";

                        }
                    }
                }
            }

                //Calculo da avaliação
                Console.WriteLine("Dados do auno numero: " + numero);
                Console.WriteLine("Nota1= " + nota1 + " Nota2= " + nota2 + " Nota3= " + nota3 + " = ");
                Console.WriteLine("Média de aproveitamento= " + media_aproveitamento + "Avaliação final= " + avaliacao_final);
                Console.ReadKey();
                Console.Clear();

            
        }        
    }
}








=======
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioDoze
    {
        public static void Executar()
        {
            //Declarando a variável
            string linha;
            double media_aproveitamento;
            int numero;
            int nota1, nota2, nota3;
            string avaliacao_final;

            //Número do aluno
            Console.Write("Informe o numero do aluno = ");
            linha = Console.ReadLine();
            numero = Int32.Parse(linha);

            //Nota da 1° prova
            Console.Write("Informe a nota1 = ");
            linha = Console.ReadLine();
            nota1 = Int32.Parse(linha);

            //Nota da 2° prova
            Console.Write("Informe a nota2 = ");
            linha = Console.ReadLine();
            nota2 = Int32.Parse(linha);

            //Nota da 3° prova
            Console.Write("Informe a nota3 = ");
            linha = Console.ReadLine();
            nota3 = Int32.Parse(linha);

            //Fórmula
            media_aproveitamento = (nota1 + (2 * nota2) + (3 * nota3)) / 7;

            //Mostrando as opções
            if (media_aproveitamento >= 90)
            {
                avaliacao_final = "A - Parabéns, você está Aprovado";
            }
            else
            {
                if (media_aproveitamento >= 75 && media_aproveitamento < 90)
                {
                    avaliacao_final = "B - Parabéns, você está Aprovado";
                }
                else
                {
                    if (media_aproveitamento >= 60 && media_aproveitamento < 75)
                    {
                        avaliacao_final = "C - Parabéns, você está Aprovado";
                    }
                    else
                    {
                        if (media_aproveitamento >= 40 && media_aproveitamento < 60)
                        {
                            avaliacao_final = "D - Precisa estudar, você está Reprovado";
                        }
                        else
                        {
                            avaliacao_final = "E - Precisa estudar, você está Reprovado";

                        }
                    }
                }
            }

                //Calculo da avaliação
                Console.WriteLine("Dados do auno numero: " + numero);
                Console.WriteLine("Nota1= " + nota1 + " Nota2= " + nota2 + " Nota3= " + nota3 + " = ");
                Console.WriteLine("Média de aproveitamento= " + media_aproveitamento + "Avaliação final= " + avaliacao_final);
                Console.ReadKey();
                Console.Clear();

            
        }        
    }
}








>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
