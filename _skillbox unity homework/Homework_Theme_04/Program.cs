

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            //Random range = new Random(); // генератор для заполнения расходов и доходов

            //// определим массив массивов и определим вложенные массивы
            //int[][] profitArr = new int[12][]; // массив из 12 колонок
            //for (int i = 0; i < profitArr.Length; i++)
            //{
            //    profitArr[i] = new int[4]; // в каждой колонке массив с 4 элементами
            //}

            //// заполняем массив данными
            //for (int i = 0; i < profitArr.GetLength(0); i++)
            //{
            //    profitArr[i][0] = i + 1; // первая позиция - номер месяца
            //    profitArr[i][1] = range.Next(0, 150); // вторая позиция - доход
            //    profitArr[i][2] = range.Next(0, 150); // вторая позиция - расход
            //    profitArr[i][3] = profitArr[i][1] - profitArr[i][2]; // вторая позиция - расход. вычитаем из второго элемента третий

            //}

            //// вывод массива до сортировки и посчитаем количество месяцев с положительным балансом
            //// выводим заголовки колонок с фиксированной длинной колонки
            //int countOfPositiveBalance = default; // количество месяцев с положительным балансом
            //string output = "{0}    {1}    {2}   {3}";
            //Console.WriteLine(output, "Месяц", "Доход", "Расход", "Прибыль");
            ////Console.WriteLine($"Месяц Доход Расход Прибыль");

            //for (int i = 0; i < profitArr.GetLength(0); i++)
            //{
            //    if (profitArr[i][3] > 0)
            //        countOfPositiveBalance++; // если баланс положительный, тогда прибавляем счетчик
            //    Console.WriteLine($"{profitArr[i][0],5}" +
            //                    $"{profitArr[i][1],9}" +
            //                    $"{profitArr[i][2],10}" +
            //                    $"{profitArr[i][3],10}");
            //}

            //// для сортировки будем использовать пузырьковый метод
            ////
            //// переменная отвечает за основной цикл сортировки, если false - значит замен элементов не было и массив отсортирован, 
            //// если true - были замены и нужна сортировка еще раз
            //bool mainSortProcess = default;
            //do
            //{
            //    mainSortProcess = false; // выставляем флаг в false
            //    for (int i = 0; i < profitArr.Length; i++)
            //    {
            //        int[] temp = new int[4]; // массив для выполения перестановки - будем хранить временное значение
            //                                 // если счетчик не равен номеру последней позиции массива, тогда выполним проверку
            //        if (i != (profitArr.Length - 1))
            //        {
            //            // если значение прибыли текущего значения i больше чем i+1, тогда выполним перестановку
            //            if (profitArr[i][3] > profitArr[i + 1][3])
            //            {
            //                temp = profitArr[i];
            //                profitArr[i] = profitArr[i + 1];
            //                profitArr[i + 1] = temp;
            //                mainSortProcess = true; // была перестановка, нужен еще один цикл сортировки
            //            }
            //        }
            //    }
            //}
            //while (mainSortProcess);

            //// выводим первые три месяца
            //int j = 0; // счетчик для вывода первых 3х худших месяцев
            //bool outputCycle = true; // для управленим циклом вывода
            //Console.WriteLine();
            //Console.Write("Месяцы с худшей прибылью: ");
            //do
            //{
            //    if (j < 3)
            //    {
            //        Console.Write($"{profitArr[j][0]}, ");
            //        j++;
            //    }
            //    // если уже вывели 3 месяца и текущая позиция не выходит за границы массива
            //    // тогда проверим, равен ли следующий элемент текущему
            //    // если равен, то выведем следйющий элемент
            //    else if (j < (profitArr.Length - 1) && j > 2)
            //    {
            //        if (profitArr[j][3] == profitArr[j + 1][3])
            //        {
            //            Console.WriteLine(profitArr[j + 1][0]);
            //            j++;
            //        }
            //    }
            //    // инач завершаем цикл
            //    else outputCycle = false;

            //} while (outputCycle);

            //Console.ReadKey();

            #endregion

            #region Задание 2
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            //// определяем переменные
            //int countOfRow = default;

            //// получим количество строк N треугольника от пользователя (N < 25)
            //while (true)
            //{
            //    Console.Write("Введите количество строк треугольника. (Не более 24): ");
            //    countOfRow = int.Parse(Console.ReadLine());
            //    if (countOfRow < 25 && countOfRow > 0)
            //        break;
            //}

            //// определим массив массивов, с количеством строк N
            //int[][] arrTriangle = new int[countOfRow][];
            //for (int i = 0; i < countOfRow; i++)
            //{
            //    // определим внутренние массивы - длинна не более N
            //    arrTriangle[i] = new int[i + 1];
            //}

            //// заполним внутренние массивы
            //// для позиции 0 и последней позиции массива значение 1
            //// для позиции от 2 до длинна - 1 берем сумму значений из верхнего массива (берем значение со смещением -1 + позицию "над текущей"
            //for (int i = 0; i < countOfRow; i++)
            //{
            //    for (int j = 0; j < arrTriangle[i].Length; j++)
            //    {
            //        // текущая позиция начальная или конечная, тогда подставим 0
            //        if (j == 0 || j == (arrTriangle[i].Length - 1))
            //            arrTriangle[i][j] = 1;
            //        // иначе возьмем сумму элементов из верхнего массива (со смещение j на минус 1)
            //        else
            //            arrTriangle[i][j] = arrTriangle[i - 1][j] + arrTriangle[i - 1][j - 1];
            //    }
            //}

            //// после заполнения выводим массив простым способом
            //for (int i = 0; i < countOfRow; i++)
            //{
            //    for (int j = 0; j < arrTriangle[i].Length; j++)
            //    {
            //        Console.Write($"{arrTriangle[i][j], 8}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            //// выводим массив сложным способом

            #endregion

            #region Задание 3.1
            // 
            // * Задание 3.1
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
            //int rowArray = default; // количество строк матрицы
            //int columnArray = default; // количество столбцов матрицы
            //int multiplNumber = default; // число, на которое нужно умножить матрицу

            //Console.Write("Введите число строк матрицы (не отрицательное число): ");
            //rowArray = int.Parse(Console.ReadLine());

            //Console.Write("Введите число столбцов матрицы (не отрицательное число): ");
            //columnArray = int.Parse(Console.ReadLine());

            //// определяем и заполняем матрицу
            //Random randomGen = new Random();

            //int[,] sourceArr = new int[rowArray, columnArray];

            //for(int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        sourceArr[i, j] = randomGen.Next(0, 100);
            //    }
            //}

            //// выводим матрицу 
            //Console.WriteLine($"Сформирована матрица {rowArray} х {columnArray}");
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        Console.Write($"{sourceArr[i, j], 4}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Введите число, на которое нужно умножить матрицу: ");
            //multiplNumber = int.Parse(Console.ReadLine());

            //// выводим результат умножения
            //Console.WriteLine($"Результат умножения матрицы {rowArray} х {columnArray} на число {multiplNumber}");
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        Console.Write($"{sourceArr[i, j] * multiplNumber, 4}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion

            #region Задание 3.2
            //
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


            //// определим переменные
            //int rowArray = default; // количество строк матрицы
            //int columnArray = default; // количество столбцов матрицы
            //int multiplNumber = default; // число, на которое нужно умножить матрицу

            //Console.Write("Введите число строк матрицы (не отрицательное число): ");
            //rowArray = int.Parse(Console.ReadLine());

            //Console.Write("Введите число столбцов матрицы (не отрицательное число): ");
            //columnArray = int.Parse(Console.ReadLine());

            //// определяем и заполняем матрицы
            //Random randomGen = new Random();

            //// первая матрица
            //int[,] sourceArr1 = new int[rowArray, columnArray];
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        sourceArr1[i, j] = randomGen.Next(-99, 100);
            //    }
            //}

            //// вторая матрица
            //int[,] sourceArr2 = new int[rowArray, columnArray];
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        sourceArr2[i, j] = randomGen.Next(-99, 100);
            //    }
            //}

            //// выводим матрицы 
            //Console.WriteLine($"Первая матрица {rowArray} х {columnArray}");
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        Console.Write($"{sourceArr1[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}

            //// выводим матрицы 
            //Console.WriteLine($"Вторая матрица {rowArray} х {columnArray}");
            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        Console.Write($"{sourceArr2[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}

            //// выводим результат сложения
            //Console.WriteLine($"Результат сложения двух матриц размером {rowArray} х {columnArray}");

            //int[,] outpurArr = new int[rowArray, columnArray];

            //for (int i = 0; i < rowArray; i++)
            //{
            //    for (int j = 0; j < columnArray; j++)
            //    {
            //        outpurArr[i, j] = sourceArr1[i, j] + sourceArr2[i, j];
            //        Console.Write($"{outpurArr[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion

            #region Задание 3.3
            // *** Задание 3.3
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

            // определим и заполним матрицы
            Random randomGen = new Random();

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

            int temp = default; // переменная для хранения промежуточного значения произведения

            // делам обход строк первой матрицы
            for (int i = 0; i < rowArr1; i++)
            {
                // перебираем столбцы второй матрицы
                for (int j = 0; j < columArr2; j++)
                {
                    temp = 0; // обнуляем временную переменную

                    for (int k = 0; k < columArr1; k++) // перебираем столбцы первой матрицы
                    {
                        temp += sourceArr1[i, k] * sourceArr2[k, j];
                    }

                    outputArr[i, j] = temp; // помещаем значение в результирующий массив
                }
            }

            // выводим результирующий массив
            Console.WriteLine("Результат умножения двух матриц: ");

            for (int i = 0; i < outputArr.GetLength(0); i++)
            {
                for (int j = 0; j < outputArr.GetLength(1); j++)
                {
                    Console.Write($"{outputArr[i, j], 5}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            #endregion
        }
    }
}
