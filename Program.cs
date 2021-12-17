using System;

namespace Sequencia.Limites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Início: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fim: ");
            int fim = Convert.ToInt32(Console.ReadLine());

            if (fim >= inicio){

                int n = inicio;

                while (n <= fim){
                    Console.Write($"{n} ");
                    n += 1;
                }

            }
            else {
                Console.WriteLine("Final post");

            }
            
            
        }
    }
}
