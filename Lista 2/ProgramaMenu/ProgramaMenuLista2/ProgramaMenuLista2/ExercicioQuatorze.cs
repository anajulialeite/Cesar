<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuatorze
    {
        public static void Executar()
        {
            //Declarando a variável
            int PrimeiroNumero, SegundoNumero, Diferenca;

            //Verificando os números
            Console.WriteLine("Digite o primero número: ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            //Mostrar a diferença do maior para o menor
            if (PrimeiroNumero >= SegundoNumero)
            {
                Diferenca = PrimeiroNumero - SegundoNumero;
            }
            else
            {
                Diferenca = SegundoNumero - PrimeiroNumero;
            }

            //Mostrar o resultado na tela
            Console.WriteLine("A diferença do menor para o maior é: " +  Diferenca);
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

namespace ProgramaMenuLista2
{
    public class ExercicioQuatorze
    {
        public static void Executar()
        {
            //Declarando a variável
            int PrimeiroNumero, SegundoNumero, Diferenca;

            //Verificando os números
            Console.WriteLine("Digite o primero número: ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            //Mostrar a diferença do maior para o menor
            if (PrimeiroNumero >= SegundoNumero)
            {
                Diferenca = PrimeiroNumero - SegundoNumero;
            }
            else
            {
                Diferenca = SegundoNumero - PrimeiroNumero;
            }

            //Mostrar o resultado na tela
            Console.WriteLine("A diferença do menor para o maior é: " +  Diferenca);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
