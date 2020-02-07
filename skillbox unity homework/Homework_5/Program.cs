using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1 Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            //MultipleNumberToMatrix();

            // 1.2 Создать метод, принимающий две матрицы, возвращающий их сумму
            //int[,] someArr = AdditionMatrixWithMatrix();

            // 1.3 Создать метод, принимающий две матрицы и возвращающий их произведение
            // MultipleMatrixToMatrix();

            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.1. 
            /* план на задачу:
             1. разбить строку на массив строк по заданным разделителям (пробел, точка, запятая)
             2. выполнить сортировку массива по возврастанию
             3. вывести самые короткие слова
            */
            GetMinMaxlWords();

            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД



            Console.WriteLine();
             
        }

        // 1.1
        static void MultipleNumberToMatrix()
        {
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //

            // определим переменные
            int rowArray = default; // количество строк матрицы
            int columnArray = default; // количество столбцов матрицы
            int multiplNumber = default; // число, на которое нужно умножить матрицу
            Random randomGen = new Random(); // генератор псевдослучайных чисел

            Console.WriteLine("Умножение матрицы на число");

            Console.Write("Введите число строк матрицы (не отрицательное число): ");
            rowArray = int.Parse(Console.ReadLine());

            Console.Write("Введите число столбцов матрицы (не отрицательное число): ");
            columnArray = int.Parse(Console.ReadLine());

            // определим и заполним матрицы
            int[,] sourceArr = new int[rowArray, columnArray]; // исходная матрица

            for (int i = 0; i < rowArray; i++)
            {
                for (int j = 0; j < columnArray; j++)
                {
                    sourceArr[i, j] = randomGen.Next(0, 100);
                }
            }

            Console.WriteLine("Введите число, на которое нужно умножить матрицу: ");
            multiplNumber = int.Parse(Console.ReadLine());

            int[,] outpurArray = new int[rowArray, columnArray]; // результат умножения

            // передаем output массив по ссылке для заполнения
            GetMultipleNumberToMatrix(sourceArr, multiplNumber, ref outpurArray);

            Console.Write("");
            //
        }
        static void GetMultipleNumberToMatrix(int[,] sourceArr, int multiplNumber, ref int[,] outputArr)
        {

            for (int i = 0; i < sourceArr.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArr.GetLength(1); j++)
                {
                    outputArr[i, j] = sourceArr[i, j] * multiplNumber;
                }
                Console.WriteLine();
            }

        }
        //

        // 1.2
        static int[,] AdditionMatrixWithMatrix()
        {
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //

            Console.WriteLine("Сложение матриц");

            Random randomGen = new Random();

            Console.Write("Введите число строк матрицы (не отрицательное число): ");
            int rowArray = int.Parse(Console.ReadLine()); // получаем число строк

            Console.Write("Введите число столбцов матрицы (не отрицательное число): ");
            int columnArray = int.Parse(Console.ReadLine()); // получаем число колонок

            // определяем и заполняем матрицы
            // первая матрица
            int[,] sourceArr1 = new int[rowArray, columnArray];
            for (int i = 0; i < rowArray; i++)
            {
                for (int j = 0; j < columnArray; j++)
                {
                    sourceArr1[i, j] = randomGen.Next(-99, 100);
                }
            }

            // вторая матрица
            int[,] sourceArr2 = new int[rowArray, columnArray];
            for (int i = 0; i < rowArray; i++)
            {
                for (int j = 0; j < columnArray; j++)
                {
                    sourceArr2[i, j] = randomGen.Next(-99, 100);
                }
            }

            // возвращаем результат сложения
            return GetAddMatrixWithMatrix(sourceArr1, sourceArr2, rowArray, columnArray);

        }

        /// <summary>
        /// метод возвращает результат сложения двух массивов
        /// </summary>
        /// <param name="sourceArr1"></param>
        /// <param name="sourceArr2"></param>
        /// <param name="rowArray"></param>
        /// <param name="columnArray"></param>
        /// <returns></returns>
        static int[,] GetAddMatrixWithMatrix(int[,] sourceArr1, int[,] sourceArr2, int rowArray, int columnArray)
        {

            int[,] outputArr = new int[rowArray, columnArray]; // определяем массив с результатом вычисления

            for (int i = 0; i < sourceArr1.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArr1.GetLength(1); j++)
                {
                    outputArr[i, j] = sourceArr1[i, j] + sourceArr2[i, j];
                }
                Console.WriteLine();
            }
            return outputArr;
        }
        // 

        // 1.3
        static int[,] MultipleMatrixToMatrix()
        {
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            Console.WriteLine("Умножение двух матриц");

            // определяем переменные
            // строки и столбцы первой матрицы
            int rowArr1 = default;
            int columArr1 = default;
            // строки и столбцы второй матрицы
            int rowArr2 = default;
            int columArr2 = default;

            // чтобы перемножить матрицы, нужно чтобы количество столбцов первой матрицы были равны количеству строк второй матрицы
            Console.WriteLine("Для умножения матриц, нужно чтобы количество столбцов первой матрицы был равен количеству строк второй матрицы. " +
                "\nНапример: 2х3 и 3х2");
            
            // получаем значения от пользователя
            while (true)
            {
                Console.WriteLine("Введите размерность первой матрицы (строки, столбцы): ");
                rowArr1 = int.Parse(Console.ReadLine());
                columArr1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите размерность второй матрицы (строки, столбцы): ");
                rowArr2 = int.Parse(Console.ReadLine());
                columArr2 = int.Parse(Console.ReadLine());

                if (columArr1 == rowArr2)
                    break;

                Console.WriteLine($"Не верно указана размерность матриц: " +
                    $"количество столбцов {columArr1} не равно количеству строк {rowArr2}");
            }

            // определим и заполним первую матрицу
            Random randomGen = new Random(); // определим гсч

            Console.WriteLine($"Первая матрица {rowArr1} х {columArr1}");
            int[,] sourceArr1 = new int[rowArr1, columArr1];
            for (int i = 0; i < rowArr1; i++)
            {
                for (int j = 0; j < columArr1; j++)
                {
                    sourceArr1[i, j] = randomGen.Next(1, 6);
                    Console.Write($"{sourceArr1[i, j],5}");
                }
                Console.WriteLine();
            }

            // определим и заполним вторую матрицу
            Console.WriteLine();
            Console.WriteLine($"Вторая матрица {rowArr2} х {columArr2}");
            int[,] sourceArr2 = new int[rowArr2, columArr2];
            for (int i = 0; i < rowArr2; i++)
            {
                for (int j = 0; j < columArr2; j++)
                {
                    sourceArr2[i, j] = randomGen.Next(1, 6);
                    Console.Write($"{ sourceArr2[i, j],5}");
                }
                Console.WriteLine();
            }

            // определим результирующий массив
            int[,] outputArr = new int[rowArr1, columArr2];  // строки - столбцы первого массива, столбцы - количество строк второго массива

            // умножаем матрицы и возвращаем результат
            GetMultipleMatrixToMatrix(sourceArr1, sourceArr2, ref outputArr);

            return outputArr;
           
        }
        static void GetMultipleMatrixToMatrix(int[,] sourceArr1, int[,] sourceArr2, ref int[,] outputArr)
        {
            
            int temp = default; // переменная для хранения промежуточного значения произведения

            // делам обход строк первой матрицы
            for (int i = 0; i < sourceArr1.GetLength(0); i++)
            {
                // перебираем столбцы второй матрицы
                for (int j = 0; j < sourceArr2.GetLength(1); j++)
                {
                    temp = 0; // обнуляем временную переменную

                    for (int k = 0; k < sourceArr1.GetLength(1); k++) // перебираем столбцы первой матрицы
                    {
                        temp += sourceArr1[i, k] * sourceArr2[k, j];
                    }

                    outputArr[i, j] = temp; // помещаем значение в результирующий массив
                }
            }
        }
        //

        // Задача 2
        static void GetMinMaxlWords()
        {

            Console.WriteLine("-> Задача 2. Ищем самое короткое и самые длинные слова");
            Console.WriteLine("Введите текст: ");
            string inpuString = Console.ReadLine();

            // получаем массив строк
            string[] words = GetWordsArray(inpuString);
            
            // создаем список для хранения коротких слов
            List<string> minWords = new List<string>();
            
            // вернем минимальное слово и добавим в список
            minWords.Add(FindMinimalWord());
            

            // методы внутри метода
            // метод возвращает массив строк из входной строки
            string[] GetWordsArray(string inputString)
            {
                // получаем массив строк
                // используем стандартные методы для получения массива слов
                return inputString.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                
            }

            // внутренний метод сортировки массива (возр, пузырьком)
            string FindMinimalWord()
            {
                string minWord = words[0];
                for (int i = 0; i < words.Length; i++)
                {
                    if (minWord.Length > words[i].Length)
                        minWord = words[i];
                }

                return minWord;
            }
        }
    }
}
