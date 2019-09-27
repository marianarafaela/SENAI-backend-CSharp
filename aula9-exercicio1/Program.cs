using System;

namespace aula9_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        { try{
            Console.WriteLine("Digite o valor do produto:");           
            double valor =double.Parse (Console.ReadLine());           
            Console.WriteLine("digite a porcentagem:");          
            double porcentagem =double.Parse(Console.ReadLine());
            Console.WriteLine(calcularDesconto(valor,porcentagem));
        }catch
        {
            System.Console.WriteLine("ops... deu erro!!");
            

        }
        try{
        static double calcularDesconto(double calculeValor, double calculoPorcentagem){
          

            calculeValor =  calculeValor * (1 - (calculoPorcentagem / 100));

        
            return calculeValor;
        }
        }catch{
            System.Console.WriteLine("ops... deu erro!!");
        }
        

        

        
            


        }
    }
}
