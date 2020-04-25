using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kval_ekz
{
    class Program
    {
        private static int arrSize = 0;
        private static Book[] Library;
        static void Main(string[] args)
        {
            ReadArrSize();
            Library = new Book[arrSize];
            Console.ReadKey();
        }
        private static void ReadArrSize()
        {
            Console.WriteLine("Введите целочисленный размер массива");
            string read = Console.ReadLine();
            while(!Int32.TryParse(read, out arrSize))
            {
                Console.WriteLine("Некорректный ввод, повторите");
                read = Console.ReadLine();
            }
        }
    }
}
