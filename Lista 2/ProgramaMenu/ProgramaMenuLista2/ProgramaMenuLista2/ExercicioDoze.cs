<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDoze
    {
        public static void Executar()
        {
            //Declarando a variável
            int Numero, ModuloNumero;

            //Programa que leia um número inteiro
            Console.WriteLine("Digite um número inteiro: ");
            Numero = int.Parse(Console.ReadLine());

            //Fórnula
            ModuloNumero = (Numero < 0) ? ModuloNumero = Numero * (-1) : Numero;

            //Mostrar o módulo na tela
            Console.WriteLine("O módulo do número é: " + ModuloNumero + "");
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
    public class ExercicioDoze
    {
        public static void Executar()
        {
            //Declarando a variável
            int Numero, ModuloNumero;

            //Programa que leia um número inteiro
            Console.WriteLine("Digite um número inteiro: ");
            Numero = int.Parse(Console.ReadLine());

            //Fórnula
            ModuloNumero = (Numero < 0) ? ModuloNumero = Numero * (-1) : Numero;

            //Mostrar o módulo na tela
            Console.WriteLine("O módulo do número é: " + ModuloNumero + "");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
