<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSessentaDois
    {
        public static void Executar()
        {
            //Mostre na tela o valor da base
            Console.WriteLine("Digite o tamanho da base: ");
            double BaseHipotenusa = double.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            //Mostre na tela o valor da altura
            Console.WriteLine("Digite o tamanho da altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            //Um programa que calcule o valor da hipotenusa 
            Console.WriteLine("A hipotenusa é: " + Hipotenusa(BaseHipotenusa, altura));
        }
        public static double Hipotenusa(double Base, double Altura)
        {
            //Fórmula
            double Hipotenusa = (Base * Base) + (Altura * Altura);
            //Método
            Hipotenusa = Math.Sqrt(Hipotenusa);
            return Hipotenusa;
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
    public class ExercicioSessentaDois
    {
        public static void Executar()
        {
            //Mostre na tela o valor da base
            Console.WriteLine("Digite o tamanho da base: ");
            double BaseHipotenusa = double.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            //Mostre na tela o valor da altura
            Console.WriteLine("Digite o tamanho da altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            //Um programa que calcule o valor da hipotenusa 
            Console.WriteLine("A hipotenusa é: " + Hipotenusa(BaseHipotenusa, altura));
        }
        public static double Hipotenusa(double Base, double Altura)
        {
            //Fórmula
            double Hipotenusa = (Base * Base) + (Altura * Altura);
            //Método
            Hipotenusa = Math.Sqrt(Hipotenusa);
            return Hipotenusa;
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
