using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // somente declaramos, sem atribuir valor
            int num1;

            //declaramos atribuindo um valor
            int num2 = 5;


            //declaramos diversas variaveis de mesmo tipo
            int num3, num4 ,num5;


            //variavel do tipo decimal (real)
            float media;

            
            //variavel do tipo logico( booleana)
            bool resultado = false;


            // variavel do tipo texto (caracteres)
            string nomeAluno;


            //quebra linha
            Console.WriteLine();


            //escreva em uma linha quebrando-a       
            Console.WriteLine("bem vindos a nossa primeira aplicação"); 

            
            //continua escrevendo na mesma linha
            Console.Write("digite");
            Console.Write(" seu nome:");


            //capturo o dado digitado pelo usuario e salvo na variavel
            nomeAluno = Console.ReadLine();


            //concatenação
            Console.WriteLine(nomeAluno + ", agora digite sua primeira nota:");


            //converto o texto capturado para o tipo inteiro 
            num3 = int.Parse(Console.ReadLine() );


            // interpolação
            Console.Write( $"sua primeira nota é {num3} ");

            Console.WriteLine("digite sua segunda nota :");

            num4 = int.Parse( Console.ReadLine() );
             Console.WriteLine("digite sua terceira nota");
             num5 = int.Parse( Console.ReadLine() );


             media = (num3 + num4 + num5) / 3;
             Console.WriteLine("sua media e" + media);
           

        }
    }
}
