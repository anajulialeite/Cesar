using System;

namespace ConvertendoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int meuInteiro = 10;
            double meuDouble = 5.25;
            bool meuBoolean = true;

            Console.WriteLine(Convert.ToString(meuInteiro)); //Conversão de int para string
            Console.WriteLine(Convert.ToDouble(meuInteiro)); //Conversão de int para double
            Console.WriteLine(Convert.ToInt32(meuDouble)); //Conversão de double para int

            //Próxima aula: Entrada de Dados.
        }
    }
}