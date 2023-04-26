using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Створіть масив чисел розмірністю в 1 000 000 або більше. Використовуючи генератор випадкових чисел, проініціалізуйте цей масив значеннями. 
    Створіть запит PLINQ, який дозволить отримати всі непарні числа з цього масиву.
     */
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            var query = array.AsParallel().Where((i) => i % 2 != 0).Select((i) => i);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
