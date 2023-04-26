using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Створіть два методи, які будуть виконуватися в рамках паралельних завдань. 
    Організуйте виклик цих методів за допомогою Invoke таким чином, щоб основний потік програми (метод Main) не зупинив своє виконання.
     */
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1() запущен.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе Method1(), счетчик равен: " + count);
            }
            Console.WriteLine("Method1() завершен.");
        }

        static void Method2()
        {
            Console.WriteLine("Method2() запущен.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе Method2(), счетчик равен: " + count);
            }
            Console.WriteLine("Method2() завершен.");
        }

        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            Task.Factory.StartNew(() => Parallel.Invoke(Method1, Method2));

            Console.WriteLine("Основной поток завершен.");

            // Delay.
            Console.ReadKey();
        }
    }
}
