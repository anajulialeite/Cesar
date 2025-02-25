namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1 = 100 + 50;
            int soma2 = soma1 + 250;
            int soma3 = soma1 + soma2;
            Console.WriteLine("Resultado soma1: " + soma1);
            Console.WriteLine("Resultado soma2: " + soma2);
            Console.WriteLine("Resultado soma3: " + soma3);
        }
    }
}
