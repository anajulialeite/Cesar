<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSessenta
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int x, y;

            //Digite o valor da variável x e y
            Console.WriteLine("Digite o valor de x:");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("********************");
                Console.WriteLine("Digite o valor de y:");
                if (int.TryParse(Console.ReadLine(), out y))
                {
                    //Método
                    Console.WriteLine("********************");
                    Console.WriteLine(VerificaQuadrante(x, y));
                }
                else
                {
                    Console.WriteLine("Valor de y não é um número inteiro válido.");
                }
            }
            else
            {
                Console.WriteLine("Valor de x não é um número inteiro válido.");
            }

            Console.ReadLine();
        }

        public static int VerificaQuadrante(int x, int y)
        {
            bool quadx, quady;
            if (x >= 0)
            {
                quadx = true;
            }
            else
            {
                quadx = false;
            }
            if (y >= 0)
            {
                quady = true;
            }
            else
            {
                quady = false;
            }
            //Um programa que retorne e mostre na tela os números dos quadrantes
            //Que deve recer o valor de X e Y
            if (x == 0 || y == 0) return 0;
            else if (quadx && quady) return 1;
            else if (!quadx && quady) return 2;
            else if (!quadx && !quady) return 3;
            else return 4;
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
    public class ExercicioSessenta
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int x, y;

            //Digite o valor da variável x e y
            Console.WriteLine("Digite o valor de x:");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("********************");
                Console.WriteLine("Digite o valor de y:");
                if (int.TryParse(Console.ReadLine(), out y))
                {
                    //Método
                    Console.WriteLine("********************");
                    Console.WriteLine(VerificaQuadrante(x, y));
                }
                else
                {
                    Console.WriteLine("Valor de y não é um número inteiro válido.");
                }
            }
            else
            {
                Console.WriteLine("Valor de x não é um número inteiro válido.");
            }

            Console.ReadLine();
        }

        public static int VerificaQuadrante(int x, int y)
        {
            bool quadx, quady;
            if (x >= 0)
            {
                quadx = true;
            }
            else
            {
                quadx = false;
            }
            if (y >= 0)
            {
                quady = true;
            }
            else
            {
                quady = false;
            }
            //Um programa que retorne e mostre na tela os números dos quadrantes
            //Que deve recer o valor de X e Y
            if (x == 0 || y == 0) return 0;
            else if (quadx && quady) return 1;
            else if (!quadx && quady) return 2;
            else if (!quadx && !quady) return 3;
            else return 4;
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
