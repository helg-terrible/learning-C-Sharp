using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FFun with Arrays");
            SimpleArrays();
            ArrayInitialization();
            Console.ReadLine();

        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation");
            // создаем массив с 3 элементами Int, индексы 0,1,2
            int[] myInts = new int[3];
            // и заполним массив
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            // вывод элементов массива
            foreach (int i in myInts)
                Console.WriteLine(i);
            // создаем массив с 100 элементами string, индексы 0 - 99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("Array initialization => ");
            // инициализация с помощью слова new
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine($"string array has {stringArray.Length} elements");
            
            // инициализация без слова new
            bool[] boolArray = { false, true, false };
            Console.WriteLine($"bool array has {boolArray.Length} elements");

            // инициализация с приминением ключевого слова new и указанием размера
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine($"int array has {intArray.Length} elements");

        }
    }
}
