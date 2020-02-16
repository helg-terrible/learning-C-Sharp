using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Welcome.In this kata, you are asked to square every digit of a number.
            For example, if we run 9119 through the function, 811181 will come out, 
            because 92 is 81 and 12 is 1.
            Note: The function accepts an integer and returns an integer
            */

            int inputNumb = 9119;

            // посчитаем количество разрядов
            int countOfRanks = GetRanksOfNumber(inputNumb);
            // получим массив цифр из числа
            int[] digitArr = GetDigitFromNumber(inputNumb, countOfRanks);

            // получим итоговое число
            int resultNumb = GetResultNumber(digitArr);

            Console.ReadLine();

        }

        static int GetRanksOfNumber(int number)
        {
            int countOfRanks = default;

            while (number != 0)
            {
                number /= 10;
                countOfRanks++;
            }

            return countOfRanks;

        }

        static int[] GetDigitFromNumber(int number, int countOfRanks)
        {
            int[] digitArr = new int[countOfRanks];
            for (int i = 0; i < countOfRanks; i++)
            {
                digitArr[i] = number % 10;
                number /= 10;
            }

            return digitArr;
        }
        /// <summary>
        /// метод возвращает число из массива целых числе возведенных в квадрат
        /// </summary>
        /// <param name="digitArr">массив целых чисел</param>
        /// <returns>целое число</returns>
        static int GetResultNumber(int[] digitArr)
        {
            string resultStr = default;

            for (int i = digitArr.Length; i > 0; i--)
            {
                // очень плохой код
                // берем число из массива, получаем квадрат и записываем его в строку с результатом
                resultStr += Convert.ToString(Math.Pow(digitArr[i - 1], 2));
            }

            return int.Parse(resultStr);
        }
    }
}
