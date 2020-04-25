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
            FillLibrary();
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
        private static void FillLibrary()
        {
            for(int i=0; i < Library.Length; i++)
            {
                Console.WriteLine("Заполните " + (i + 1) + "й элемент массива");
                Library[i] = new Book();
                Console.WriteLine("Введите название книги");
                string name = Console.ReadLine();
                Library[i].Name = name;

                Console.WriteLine("Введите автора книги");
                string author = Console.ReadLine();
                while (HasStrDigits(author))
                {
                    Console.WriteLine("Имя автора не может содержать цифр");
                    author = Console.ReadLine();
                }
                Library[i].Author = author;

                Console.WriteLine("Введите жанр книги");
                string genre = Console.ReadLine();
                while (HasStrDigits(genre))
                {
                    Console.WriteLine("Жанр не может содержать цифр");
                    genre = Console.ReadLine();
                }
                Library[i].Genre = genre;
            }
        }

        private static bool HasStrDigits(string str)
        {
            bool response = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    response = true;
                }
            }
            return response;
        }
    }
}
