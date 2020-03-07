using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework_desc
            /// Разработать ежедневник.
            /// В ежедневнике реализовать возможность 
            /// - создания
            /// - удаления
            /// - реактирования 
            /// записей
            /// 
            /// В отдельной записи должно быть не менее пяти полей
            /// 
            /// Реализовать возможность 
            /// - Загрузки даннах из файла
            /// - Выгрузки даннах в файл
            /// - Добавления данных в текущий ежедневник из выбранного файла
            /// - Импорт записей по выбранному диапазону дат
            /// - Упорядочивания записей ежедневника по выбранному полю 
            /// 

            /* план на задачу:
             разработать класс ежедневник, каждая запись это структура с полями
             
            структура Event, поля:
             - дата / время начала события
             - дата / время окончания события
             - заголовок записи
             - описание
             - тип записи (личное, рабочее, работа над здоровьем) - тип Enum
             - родительская запись (ссылка на другую структуру Event) - опционально

             класс TaskManager
             структура данных с элементами Event (массив, стек, структура, очередь) 

             методы:
            - создание записи
            - удаление (как?) через Pop сруктуры Stack?
            - редактирование записи
            - загрузка данных из файла
            - выгрузка данных в файл
            - добавление данных в текущий ежедневник из выбранного файла
            - импорт записей по выбранному диапазону дат
            - упорядочивания записей ежедневника по выбранному полю (возможно есть стандартные коллекции)
                
            */
            #endregion

            #region todo by 07.03.2020
            /*
            - загружать и выгружать данные нужно в одно хранилище - вопрос к формату дат при выгрузке
            - 
            */
            #endregion

            // главный управляющий цикл
            bool mainControlCycle = true;

            ScheduleEvents scheduleEvents = new ScheduleEvents(@"inputData.csv", @"outputData.csv");

            
            while (mainControlCycle)
            {
                // main greeting msg
                MainGreetingMessage();

                int answer = default;

                try
                {
                   answer = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неизвестная команда, попробуйте еще раз");
                    continue;
                }
                

                switch (answer)
                {
                    // создать и добавить запись
                    case 1:
                        scheduleEvents.CreateItem();
                        break;
                    
                    // редактировать запись
                    case 2:
                        // в качестве демонстрации передаем индекс последнего элемента
                        scheduleEvents.EditEvent(scheduleEvents.eventList.Count - 1);
                        break;

                    // удаляем запись
                    case 3:
                        // в качестве демонстрации передаем индекс последнего элемента
                        scheduleEvents.RemoveEvent(scheduleEvents.eventList.Count - 1);
                        break;

                    // загрузить данные из хранилища из основного хранилища inputData
                    case 4:
                        scheduleEvents.Load();
                        break;

                    // выгрузить данные в хранилище addData (не основное хранилище)
                    case 5:
                        scheduleEvents.Unload();
                        break;
                    
                    // загрузить данные в ежедневник из выбранного файла по диапазону дат
                    case 6:
                        // демонстрация - диапазон дат задан фиксированно
                        LoadDataByRange(scheduleEvents);
                        break;
                    
                    // отсортировать ежедневник по дате окончания
                    case 7:
                        scheduleEvents.SortSchedulebyEndEvent(); break;
                    
                    // отсортировать ежедневник по названию мероприятия
                    case 8:
                        scheduleEvents.SortScheduleByTitle(); break;
                        
                    // вывод ежедневника в консоль
                    case 9:
                        scheduleEvents.PrintEvents();
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда, попробуйте еще раз");
                        continue;

                }
            }
           
            Console.ReadKey();
        }

        // метод выводит приветственное сообщение с описанием ожидаемых к вводу команд       
        static void MainGreetingMessage()
        {
            Console.WriteLine();

            Console.WriteLine("Выберете действие над списком событий: \n" +
                            "1 - создать запись\n" +
                            "2 - редактировать запись\n" +
                            "3 - удалить запись\n" +
                            "4 - загрузить данные из хранилища\n" +
                            "5 - выгрузить данные в хранилище (записи будут замещены)\n" +
                            "6 - загрузить данные в ежедневник из выбранного файла\n" +
                            "7 - отсортировать ежедневник по дате окончания\n" +
                            "8 - отсортировать ежедневник по названию мероприятия\n" +
                            "9 - вывести ежедневник в консоль");
            
        }

        /// <summary>
        /// загружает данные из файла по ссылке по диапазону дат
        /// </summary>
        /// <param name="scheduleEvents"></param>
        static void LoadDataByRange(ScheduleEvents scheduleEvents)
        {
            // 
            scheduleEvents.Load(@"addData.csv", new DateTime(2020, 03, 01, 00, 00, 00), new DateTime(2020, 03, 08, 12, 00, 00));
        }

    }
}
