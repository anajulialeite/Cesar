<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSessentaTres
    {
        public static void Executar()
        {
            //Um programa que verifique se o número é par ou ímpar 
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("*********************");
            //Método
            Console.WriteLine(Verifica(numero));
        }
        //Método deve receber um número inteiro
        public static String Verifica(int numero)
        {
            //Retorne e mostre na tela se o número é par ou ímpar
            if (numero % 2 == 0) return "Par";
            else return "ÍMPAR";
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
    public class ExercicioSessentaTres
    {
        public static void Executar()
        {
            //Um programa que verifique se o número é par ou ímpar 
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("*********************");
            //Método
            Console.WriteLine(Verifica(numero));
        }
        //Método deve receber um número inteiro
        public static String Verifica(int numero)
        {
            //Retorne e mostre na tela se o número é par ou ímpar
            if (numero % 2 == 0) return "Par";
            else return "ÍMPAR";
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
