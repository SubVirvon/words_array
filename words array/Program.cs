using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");

            string[] words = Console.ReadLine().Split(' ');

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
