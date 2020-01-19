using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vacancy_desc
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            #endregion


            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером

            #region demonstrate
            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            // переменная управляет основным игровым циклом
            // если true - игра работает, false - завершение игры
            bool mainGameProcess = true;

            // основной игровой цикл
            while (mainGameProcess)
            {
                // переменная для управления циклом текущей игровой сессии
                // если true - сессия работает, false  - сессия прерывается с выводом результатов
                bool currentSession = default;
                //
                int gameNumber = default; // загаданное число
                // границы для генерации загаданного числа
                int rangeGameNumberLeft = default;
                int rangeGameNumberRight = default;
                // число игрока
                int userTry = default;
                // границы для числа игрока (usertry)
                int rangeUserTryLeft = default;
                int rangeUserTryRight = default;
                // уровень сложности игры (1 - 3)
                int difficultLevel = default;
                // хранение имени победителя
                string winner = default;

                // добавить выбор режима игры (1 на 1 или игра с ИИ)


                // получаем данные игроков
                Console.Write("Введите имя первого игрока: ");
                string user1 = Console.ReadLine();

                Console.Write("Введите имя второго игрока: ");
                string user2 = Console.ReadLine();

                // определяем сложность игры
                string difficultDesc = "Уровень сложности" +
                                "\n - easy (1) - базовая сложность, число 12 - 120, диапазон чисел игрока 1 - 4 " +
                                "\n - normal (2) - средняя сложность, число 20 - 180, диапазон чисел игрока 1 - 8 " +
                                "\n - hard (3) - тяжелая сложность, число 25 - 220, диапазон чисел игрока 1 - 12";

                // получаем сложность игры
                while (true)
                {
                    Console.WriteLine(difficultDesc + "\n Выберете сложность игры (введите уровень сложности от 1 до 3): ");
                    difficultLevel = int.Parse(Console.ReadLine());
                    if (difficultLevel >= 1 && difficultLevel <= 3) break;
                    Console.WriteLine("Неккоректный символ. Введите уровень сложности еще раз");
                }

                // задаем игровые параметры сложности
                switch (difficultLevel)
                {
                    case 1:
                        rangeGameNumberLeft = 12; rangeGameNumberRight = 121;
                        rangeUserTryLeft = 1; rangeUserTryRight = 4;
                        break;
                    case 2:
                        rangeGameNumberLeft = 20; rangeGameNumberRight = 181;
                        rangeUserTryLeft = 1; rangeUserTryRight = 8;
                        break;
                    case 3:
                        rangeGameNumberLeft = 25; rangeGameNumberRight = 220;
                        rangeUserTryLeft = 1; rangeUserTryRight = 12;
                        break;
                }

                // генерируем игровое число и переходим к игре
                Random r = new Random();
                gameNumber = r.Next(rangeGameNumberLeft, rangeGameNumberRight);

                // вывод загаданного числа
                Console.WriteLine($"Число: {gameNumber}");

                // пояснение правил перед стартом
                Console.WriteLine($"Вам нужно будет поочередно вводить число от {rangeUserTryLeft} до {rangeUserTryRight}" +
                                  "\nКто первый доведет загаданное число до 0, тот выйграл. ");

                // запускаем игру
                currentSession = true;

                // цикл текущей игровой сессии
                while (currentSession)
                {
                    #region user1
                    // получаем значения от игрока и проверим их
                    while (true)
                    {
                        Console.WriteLine($"Ход игрока {user1}: ");
                        userTry = int.Parse(Console.ReadLine()); // получаем число от игрока

                        if (userTry >= rangeUserTryLeft && userTry <= rangeUserTryRight)
                            break;
                        Console.WriteLine($"Вы ввели \"{userTry}\". " +
                                        $"Нужно ввести число от {rangeUserTryLeft} до {rangeUserTryRight} " +
                                        $"+ \nПопробуйте еще раз");
                    }
                    // вычитаем число игрока и загаданного и проверяем результат
                    gameNumber -= userTry;
                    Console.WriteLine($"Число: {gameNumber}");
                    if (gameNumber == 0)
                    {
                        winner = user1;
                        Console.WriteLine($"{winner} победил!");
                        currentSession = false; // завершаем сессию
                        break;
                    }
                    else if (gameNumber < 0)
                    {
                        Console.WriteLine("Число стало меньше 0. Победителя нет.");
                        currentSession = false;
                    }
                    #endregion

                    #region user2
                    // получаем значения от игрока и проверим их
                    while (true)
                    {
                        Console.WriteLine($"Ход игрока {user2}: ");
                        userTry = int.Parse(Console.ReadLine()); // получаем число от игрока
                        if (userTry >= rangeUserTryLeft && userTry <= rangeUserTryRight)
                            break;
                        Console.WriteLine($"Вы ввели \"{userTry}\". " +
                                        $"Нужно ввести число от {rangeUserTryLeft} до {rangeUserTryRight} " +
                                        $"+ \nПопробуйте еще раз");
                    }
                    //
                    gameNumber -= userTry;
                    Console.WriteLine($"Число: {gameNumber}");
                    if (gameNumber == 0)
                    {
                        winner = user2;
                        Console.WriteLine($"{winner} победил!");
                        currentSession = false; // завершаем сессию
                        break;
                    }
                    else if (gameNumber < 0)
                    {
                        Console.WriteLine("Число стало меньше 0. Победителя нет.");
                        currentSession = false;
                    }
                    #endregion
                    
                }

                // предложение о повторе игры
                Console.WriteLine("Хотите попробовать еще раз? (y/n)");
                string answer = Console.ReadLine();

                // выход, если не был выбран повтор / реванш
                if (answer == "n")
                    mainGameProcess = false;

                if (answer != "n" && answer != "y")
                {
                    Console.WriteLine($"Вы ввели некорректный символ \"{answer}\". Игра закрывается");
                    mainGameProcess = false;
                }
                
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
