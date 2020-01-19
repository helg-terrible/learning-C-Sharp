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
            //SimpleArrays();
            //ArrayInitialization();
            //DeclareImplictArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedMultidimensionalArray();
            //PassAndReciveArrays();
            SystemArrayFunctionality();

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

        static void DeclareImplictArrays()
        {
            Console.WriteLine("Implict Array Initialisation => ");
            // переменная а имеет тип int[]
            var a = new[] { 1, 10, 100 };
            Console.WriteLine($"a is a: {a.ToString()}");

            // переменная b имеет тип double[]
            var b = new[] { 1, 2.5, 2, 2.5 };
            Console.WriteLine($"b is a: {b.ToString()}");

        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("Массив объектов =>");
            // массив объектов может содержать разные типы объектов
            object[] myObjets = new object[4];
            myObjets[0] = 10;
            myObjets[1] = false;
            myObjets[2] = new DateTime(1969, 3, 24);
            myObjets[3] = "Form an Void";
            foreach (object obj in myObjets)
            {
                Console.WriteLine($"Type: {obj.GetType()}, Value: {obj}");
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("Многомерные массивы =>");
            // прямоугольный многомерный массив
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // заполнение массива 3 * 4
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;
            // вывод содержимого массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.WriteLine(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("Jagged Multidimensional Array = >");
            // зубчатый многомерный массив (массив массивов)
            // получаем массив из 5 разных массивов
            int[][] myJagArray = new int[5][];
            // заполняем внутренние массивы
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            // выводим значения
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
        }
        // выводит массив в консоль
        static void PrintArray( int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine($"Item {i} is {myInts[i]}");
        }
        
        // возвращает строковый массив
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }
        // 
        static void PassAndReciveArrays()
        {
            Console.WriteLine("Arrays ass params and returns values");
            // передаем массив в качестве параметра
            int[] ages = { 20, 32, 23, 1 };
            PrintArray(ages);
            // получить массив как возвращаемое значение
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }
        //
        static void PrintStringArray(string[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine(myInts[i] + " ");
        }
        // функциональность базового класса Array
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("Working with System.Array =>");
            string[] gothicBands = { "Tinews on Tail", "Bauhaus", "sisters of Mercy"};

            Console.WriteLine("Here is the array");
            for (int i = 0; i < gothicBands.Length; i++ )
                Console.WriteLine(gothicBands[i] + " ");

            // обратим порядок следования
            Array.Reverse(gothicBands);
            PrintStringArray(gothicBands);

            // удалим все элементы кросе 
            Array.Clear(gothicBands, 1, 2);
            PrintStringArray(gothicBands);
        }
    }
}
