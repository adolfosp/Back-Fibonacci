using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
                Console.WriteLine(CalculoFibonacciRecursivo(i));
        } 

 
 
        public static int CalculoFibonacciRecursivo(int numero)
        {
            if (numero < 2)
                return numero;

            return CalculoFibonacciRecursivo(numero - 1) + CalculoFibonacciRecursivo(numero - 2);
        }

    }
}

  

