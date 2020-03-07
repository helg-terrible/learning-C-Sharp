using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // объявление переменных
            string name = "helg";
            int age = 29;
            int height = 182;
            int mathPoint = 50;
            int historyPoint = 70;
            int russianLangPoint = 90;
            // заполнение данных
            //Console.WriteLine("Enter the name: ");
            //name = Console.ReadLine();
            
            //Console.WriteLine("Tap your age: ");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Tap your height: ");
            //height = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("Tap your math, history and russian lang points (one after another): ");
            //mathPoint = Convert.ToInt32(Console.ReadLine());
            //historyPoint = int.Parse(Console.ReadLine());
            //russianLangPont = Convert.ToInt32(Console.ReadLine());

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.
            double averagePoints = (Double)(mathPoint + historyPoint + russianLangPoint) / 3;

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // вывод имени
            string nameString = "Name: " + name;
            Console.WriteLine(nameString);

            // выводим рост и возраст            
            Console.WriteLine("My heihgt is {0:d}, and i am {1:d} years old", height, age);
            string ageString = ($"My heihgt is {height:d}, and i am {age:d} years old");

            // интерпоялция строк
            // выводим баллы по предметам
            string pointsString = ($"My edu points. Math - {mathPoint}, " +
                                   $"history - {historyPoint}, " +
                                   $"rus lang - {russianLangPoint}");
            Console.WriteLine($"My edu points. Math - {mathPoint}, history - {historyPoint}, rus lang - {russianLangPoint}.");

            // вывод через паттерн string
            //string pattern = "Math points: {0}, history points: {1}, rus lang: {2}";
            //Console.WriteLine(pattern, mathPoint, historyPoint, russianLangPont);

            // вывод среднего значения баллов по предметам
            string averagePointsString = ($"Average point is {averagePoints:0.00}");
            Console.WriteLine(averagePointsString);

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            //string f1 = $"{name, 60}\n{age, 60}"; // вывод через определение границы строки

            // вывод через установку курсора
            int consWidht = Console.WindowWidth / 2;
            int consHeight = Console.WindowHeight / 2;
            
            Console.SetCursorPosition(consWidht - (nameString.Length / 2), consHeight - 4); // устанавлваем курсор
            Console.WriteLine(nameString);

            Console.SetCursorPosition(consWidht - (ageString.Length / 2), consHeight - 3); 
            Console.WriteLine(ageString);

            Console.SetCursorPosition(consWidht - (pointsString.Length / 2), consHeight - 2); 
            Console.WriteLine(pointsString);

            Console.SetCursorPosition(consWidht - (averagePointsString.Length / 2), consHeight - 1);
            Console.WriteLine(averagePointsString);

            //
            Console.ReadKey();

        }
    }
}
