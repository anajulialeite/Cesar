<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuinze
    {
        public static void Executar()
        {
            //Declarando a variavel
            double PrimeiraNota, SegundaNota, TerceiraNota, QuartaNota, RecuperacaoNota, Media;
            bool Aprovacao = false;

            //Verificando as notas do aluno
            Console.WriteLine("Digite a primeira nota: ");
            PrimeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            SegundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            TerceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            QuartaNota = double.Parse(Console.ReadLine());

            //Fórmula
            Media = (PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota / 4);

            //Ler as notas e apresentar se o aluno está aprovado, reprovado ou aprovado na recuperação
            //Mostrar o resultado na tela
            if (Media >= 7) Aprovacao = true;
            else
            {
                Console.WriteLine("O aluno ficou de recuperação, digite a nota: ");
                RecuperacaoNota = double.Parse(Console.ReadLine());
                Media = (Media + RecuperacaoNota) / 2;
                if (Media >= 7) Aprovacao = true;
            }

            if (Aprovacao == true)
            {
                Console.WriteLine("O aluno foi aprovado com a média: " + Media);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado com a média: " + Media);
            }
            
                Console.ReadKey();
                Console.Clear();
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
    public class ExercicioQuinze
    {
        public static void Executar()
        {
            //Declarando a variavel
            double PrimeiraNota, SegundaNota, TerceiraNota, QuartaNota, RecuperacaoNota, Media;
            bool Aprovacao = false;

            //Verificando as notas do aluno
            Console.WriteLine("Digite a primeira nota: ");
            PrimeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            SegundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            TerceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            QuartaNota = double.Parse(Console.ReadLine());

            //Fórmula
            Media = (PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota / 4);

            //Ler as notas e apresentar se o aluno está aprovado, reprovado ou aprovado na recuperação
            //Mostrar o resultado na tela
            if (Media >= 7) Aprovacao = true;
            else
            {
                Console.WriteLine("O aluno ficou de recuperação, digite a nota: ");
                RecuperacaoNota = double.Parse(Console.ReadLine());
                Media = (Media + RecuperacaoNota) / 2;
                if (Media >= 7) Aprovacao = true;
            }

            if (Aprovacao == true)
            {
                Console.WriteLine("O aluno foi aprovado com a média: " + Media);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado com a média: " + Media);
            }
            
                Console.ReadKey();
                Console.Clear();
        }
            
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
