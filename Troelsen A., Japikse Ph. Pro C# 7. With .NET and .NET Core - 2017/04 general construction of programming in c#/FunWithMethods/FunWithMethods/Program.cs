using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            // out - передаем значене по ссылке, но значения должны быть обязательно измененыы
            int a; string b; bool c;
            FillTheseValues(out a, out b, out c);
            Console.WriteLine($"int is {a}, string is {b}, bool is {c}");

            // ref - передаем значение по ссылке и меняем значения внутри метода
            string s1 = "Flip"; string s2 = "Flop";
            Console.WriteLine($"Before: string 1 - {s1}, string 2 - {s2}");
            SwapStrings(ref s1, ref s2);
            Console.WriteLine($"After: string 1 - {s1}, string 2 - {s2}");

            // вызов метода с ключевым словом ref
            string[] stringArray = { "one", "two", "three" };
            int pos = 0;
            Console.WriteLine($"Before: {stringArray[pos]}");
            ref var refOotput = ref SampleRefReturn(stringArray, pos);
            refOotput = "new";
            Console.WriteLine($"After: {stringArray[pos]}");

            // вызов метода с модификатором params
            double average = CalculateAverage(4.9, 3.2, 5.7, 64.22, 87.2); // список значений double
            Console.WriteLine($"Average of data is: {average}");

            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data); // массив значений double
            Console.WriteLine($"Average of data is {average}");

            Console.WriteLine($"Average of data is {CalculateAverage()}"); // передаем 0

            Console.ReadLine();
        }

        // короткая запись метода
        static int Add(int x, int y) => x + y;

        // возвращение множества выходных параметров
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        // возвращение ссылки на позицию элемента в массиве - модификатор ref
        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        // получение набора параметров - модификатор params
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length}");

            double sum = 0;
            if(values.Length == 0) 
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return sum / values.Length;
        }

    }
}
