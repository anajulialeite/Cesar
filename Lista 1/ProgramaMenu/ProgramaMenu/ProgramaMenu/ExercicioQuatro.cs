<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioQuatro
    {
        public static void Executar()
        {
            //Valores de A e B
            Console.WriteLine("Digite um numero ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int B = int.Parse(Console.ReadLine());

            //Se os valores são iguais deverá se somar os dois
            if (A == B)
            {
                int C = A + B;
                Console.WriteLine("A soma de {0} e {1} é: {2}", A, B, C);
            }
            //Caso contrário multiplique A por B
            else
            {
                //Atribuindo uma variável C
                int C = A * B;
                Console.WriteLine("A multiplicação entre {0} e {1} é: {2}", A, B, C);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioQuatro
    {
        public static void Executar()
        {
            //Valores de A e B
            Console.WriteLine("Digite um numero ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int B = int.Parse(Console.ReadLine());

            //Se os valores são iguais deverá se somar os dois
            if (A == B)
            {
                int C = A + B;
                Console.WriteLine("A soma de {0} e {1} é: {2}", A, B, C);
            }
            //Caso contrário multiplique A por B
            else
            {
                //Atribuindo uma variável C
                int C = A * B;
                Console.WriteLine("A multiplicação entre {0} e {1} é: {2}", A, B, C);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
}