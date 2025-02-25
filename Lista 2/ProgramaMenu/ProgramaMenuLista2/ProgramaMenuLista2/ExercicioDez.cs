<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDez
    {
        public static void Executar()
        {
            //Declarando a variável
            int PrimeiroNumero, SegundoNumero;
            bool Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false, MenorOuIgual = false;

            //Um programa que leia dois números inteiros
            Console.WriteLine("Digite o primeiro numero: ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            if (PrimeiroNumero == SegundoNumero) Igual = true;
            if (PrimeiroNumero != SegundoNumero) NaoIgual = true;
            if (PrimeiroNumero > SegundoNumero) Maior = true;
            if (PrimeiroNumero < SegundoNumero) Menor = true;
            if (PrimeiroNumero >= SegundoNumero) MaiorOuIgual = true;
            if (PrimeiroNumero <= SegundoNumero) MenorOuIgual = true;

            //Mostrar o resultado na tela se são iguais, não igual, maior, menor, maior ou igual e menor ou igual
            Console.WriteLine("Igual = " + Igual);
            Console.WriteLine("Não Igual = " + NaoIgual);
            Console.WriteLine("Maior = " + Maior);
            Console.WriteLine("Menor = " + Menor);
            Console.WriteLine("Maior ou Igual = " + MaiorOuIgual);
            Console.WriteLine("Menor Ou Igual = " + MenorOuIgual);
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
    public class ExercicioDez
    {
        public static void Executar()
        {
            //Declarando a variável
            int PrimeiroNumero, SegundoNumero;
            bool Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false, MenorOuIgual = false;

            //Um programa que leia dois números inteiros
            Console.WriteLine("Digite o primeiro numero: ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            if (PrimeiroNumero == SegundoNumero) Igual = true;
            if (PrimeiroNumero != SegundoNumero) NaoIgual = true;
            if (PrimeiroNumero > SegundoNumero) Maior = true;
            if (PrimeiroNumero < SegundoNumero) Menor = true;
            if (PrimeiroNumero >= SegundoNumero) MaiorOuIgual = true;
            if (PrimeiroNumero <= SegundoNumero) MenorOuIgual = true;

            //Mostrar o resultado na tela se são iguais, não igual, maior, menor, maior ou igual e menor ou igual
            Console.WriteLine("Igual = " + Igual);
            Console.WriteLine("Não Igual = " + NaoIgual);
            Console.WriteLine("Maior = " + Maior);
            Console.WriteLine("Menor = " + Menor);
            Console.WriteLine("Maior ou Igual = " + MaiorOuIgual);
            Console.WriteLine("Menor Ou Igual = " + MenorOuIgual);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
