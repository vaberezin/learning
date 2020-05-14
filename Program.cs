using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Factorial()//определение обычного метода
        {
            int result = 1;
            for(int i = 1; i <= 6; i++)
            {
                result *= i;
                Thread.Sleep(5000);
                System.Console.WriteLine($"Проход {i} завершен. ");
            }
            
            System.Console.WriteLine($"Факториал равен {result}");
        }
        //определение асинхронного метода
        static async void FactorialAsync()
        {
            System.Console.WriteLine("Async method has started.");
            await Task.Run(()=> Factorial());
            System.Console.WriteLine("Async method has ended.");
        }

        
        static void Main(string[] args)
        {
            FactorialAsync();
            System.Console.WriteLine("Enter a number:");
            int n = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($"Квадрат чисал {n} равен {n * n}");
            Console.ReadKey();
        }
    }
}
