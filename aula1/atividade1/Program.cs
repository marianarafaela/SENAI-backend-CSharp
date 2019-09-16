using System;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            float media;
             
            Console.WriteLine();    //quebra linha

            Console.Write(" Digite um número: ");
            num1= int.Parse(Console.ReadLine() );
            media = num1 *3;
            Console.Write("sua media é" + media);




        }
    }
}
