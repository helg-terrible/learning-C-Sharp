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

            //Event testEvent = new Event(new DateTime(2020, 02, 23, 17, 05, 00), 
            //                            new DateTime(2020, 02, 23, 19, 00, 00),
            //                            "go to the cinema");

            //testEvent.EventType = eventType.Personal;
            //testEvent.Print();

            // тестируем класс ScheduleEvent
            ScheduleEvents scheduleEvents = new ScheduleEvents(@"inputData.csv", @"outputData.csv");

            scheduleEvents.AddEvent("2020 02 24 12 30 00", "2020 02 24 13 30 00", "test event", "test event", "Personal");
            scheduleEvents.AddEvent("2020 02 23 07 00 00", "2020 02 23 07 20 00", "road to work", "moving to work", "Personal");
            scheduleEvents.AddEvent("2020 02 23 08 10 00", "2020 02 23 08 30 00", "work task 1", "kill them all!", "Job");

            //Console.ReadKey();

            //scheduleEvents.RemoveEvent(0);
            //scheduleEvents.EditEvent(0);
            scheduleEvents.Load();

            scheduleEvents.Unload();

            Console.ReadKey();


        }
    }
}
