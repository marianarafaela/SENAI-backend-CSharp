using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            float num3;
            float media;
            Console.Write("digite o preço do produto:");
            num1= int.Parse(Console.ReadLine() );
            Console.Write("digite a porcentagem:");
            num2 = int.Parse(Console.ReadLine());
            media = (num1*num2) /100;
            num3 = media + num1;
            Console.Write("o valor da sua venda é:" + num3);

        }
    }
}
