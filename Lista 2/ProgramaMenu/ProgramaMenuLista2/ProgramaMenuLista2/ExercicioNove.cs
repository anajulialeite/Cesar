<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioNove
    {
        public static void Executar()
        {
            //Declarando a variável
            int IdadeAnos, IdadeMeses, IdadeDias, IdadeTotalDias;

            //Calculando a idade em dias
            Console.WriteLine("Digite os anos: ");
            IdadeAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os meses: ");
            IdadeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dias: ");
            IdadeDias = int.Parse(Console.ReadLine());

            //Fórmula
            IdadeTotalDias = IdadeAnos * 365 * IdadeMeses * 30 + IdadeDias;

            //Mostrar resultado na tela
            Console.WriteLine("Idade total em dias = " + IdadeTotalDias);
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
    public class ExercicioNove
    {
        public static void Executar()
        {
            //Declarando a variável
            int IdadeAnos, IdadeMeses, IdadeDias, IdadeTotalDias;

            //Calculando a idade em dias
            Console.WriteLine("Digite os anos: ");
            IdadeAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os meses: ");
            IdadeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dias: ");
            IdadeDias = int.Parse(Console.ReadLine());

            //Fórmula
            IdadeTotalDias = IdadeAnos * 365 * IdadeMeses * 30 + IdadeDias;

            //Mostrar resultado na tela
            Console.WriteLine("Idade total em dias = " + IdadeTotalDias);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
