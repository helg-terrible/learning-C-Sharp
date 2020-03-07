using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_6
{
    public class ScheduleEvents
    {
        #region fields
        // список объектов Event
        public List<Event> eventList;

        // путь к файлу для загрузки
        public string inputPath;

        // путь к файлу для выгрузки
        public string outputPath;

        // заголовки
        private static string[] titles = { "Start of event", "End of event", "Title", "Description", "Event's type" };

        #endregion

        #region ctors
        public ScheduleEvents(string inputPath, string outputPath)
        {
            this.inputPath = inputPath;
            this.outputPath = outputPath;

            this.eventList = new List<Event>();
        }

        #endregion

        #region properties
        public string InputPath 
        { 
            get { return inputPath; } 
        }

        public string OutputPath 
        { 
            get { return outputPath; } 
        }

        #endregion

        #region methods

        /// <summary>
        /// создание записи в ежедневнике
        /// </summary>
        public void CreateItem()
        {
            Console.WriteLine("Введите дату начала события (yyyy mm dd hh mm ss): ");
            string strStartOfEvenet = Console.ReadLine();

            Console.WriteLine("Введите дату окончания события (yyyy mm dd hh mm ss): ");
            string strEndtOfEvenet = Console.ReadLine();

            Console.WriteLine("Введите название события: ");
            string strEventTitle = Console.ReadLine();

            Console.WriteLine("Введите описание события: ");
            string strEventDescription = Console.ReadLine();

            Console.WriteLine("Введите тип события: ");
            string strEventType = Console.ReadLine();

            AddEvent(strStartOfEvenet, strEndtOfEvenet, strEventTitle, strEventDescription, strEventType);

            Console.WriteLine("Запись создана и добавлена");

        }

        /// <summary>
        /// метод сортирует список
        /// </summary>
        public void SortSchedule()
        {
            bool cycleControl = true;
            while (cycleControl)
            {
                Console.WriteLine("1 - сортировка по дате окончания \n" +
                                "2 - сортировка по дате начала \n" +
                                "3 - сортировка по названию\n" +
                                "4 - выйти без сортировки");

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
                    case 1:
                        eventList.Sort();
                        cycleControl = false;
                        break;

                    case 2:
                        eventList.Sort(new SortEventsByStartDate());
                        cycleControl = false;
                        break;

                    case 3:
                        eventList.Sort(new SortEventsByTitle());
                        cycleControl = false;
                        break;

                    case 4:
                        cycleControl = false;
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда, попробуйте еще раз");
                        break;
                }

            }
        }

        /// <summary>
        /// добавляет новый объект типа Event в список
        /// </summary>
        /// <param name="startOfEvent">формат yyyy mm dd hh mm ss</param>
        /// <param name="endOfEvent">формат yyyy mm dd hh mm ss</param>
        /// <param name="eventTitle">заголовок события, не более 15 символов</param>
        /// <param name="eventDescription">описание события, не более 300 символов</param>
        /// <param name="eventType">тип события</param>
        private void AddEvent(string strStartOfEvent, string strEndOfEvent, string strEventTitle, string strEventDescription, string strEventType)
        {
            eventList.Add(new Event()
            {
                StartOfEvent = GetDateTime(strStartOfEvent),
                EndOfEvent = GetDateTime(strEndOfEvent),
                EventTitile = strEventTitle,
                EventDescription = strEventDescription,
                EventType = GetEventType(strEventType)
            });
        }

        /// <summary>
        /// возвращает объект DateTime из строки
        /// </summary>
        /// <param name="dateTime">строка с датой в формате yyyy mm dd hh mm ss </param>
        /// <returns></returns>
        private DateTime GetDateTime(string strdDateTime)
        {
            // получим из строки с датой массив: год, месяц, день, часы, минуты, секунды
            string[] partsOfDateTime = strdDateTime.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                return new DateTime(int.Parse(partsOfDateTime[0]),
                                        int.Parse(partsOfDateTime[1]),
                                        int.Parse(partsOfDateTime[2]),
                                        int.Parse(partsOfDateTime[3]),
                                        int.Parse(partsOfDateTime[4]),
                                        int.Parse(partsOfDateTime[5]));
            }

            catch { return new DateTime(); }


        }

        /// <summary>
        /// возвращает тип события eventType по входной строке
        /// </summary>
        /// <param name="strEventType">Personal, Job, Health, Other</param>
        /// <returns>возвращает объект типа eventType</returns>
        private eventType GetEventType(string strEventType)
        {
            switch (strEventType)
            {
                case "Personal":
                    return eventType.Personal;
                    break;
                case "Job":
                    return eventType.Job;
                    break;
                case "Health":
                    return eventType.Health;
                    break;
                default:
                    return eventType.Other;
                    break;
            }
        }

        /// <summary>
        /// Удаляет элемент по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveEvent(int index)
        {
            eventList.RemoveAt(index);
        }

        /// <summary>
        /// метод позволяет изменить значения полей события
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        public void EditEvent(int index)
        {
            bool cycleControl = default;
            do
            {
                Event curentEvent = eventList[index];

                // вывести поля текущего события перед изменением
                curentEvent.PrintEvent();

                PrintEditDescription(); // вывод меню режима редактирования

                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 0: // выход из режима редактирования
                        Console.WriteLine("Exiting from edit mode...");
                        cycleControl = false;
                        break;

                    case 1: // изменить даты мероприятия
                        Console.WriteLine("Enter new start and end datetime (yyyy mm dd hh mm ss): ");
                        string newStartDateTimeStr = Console.ReadLine();
                        string newEndDateTimeStr = Console.ReadLine();
                        curentEvent.StartOfEvent = GetDateTime(newStartDateTimeStr);
                        curentEvent.EndOfEvent = GetDateTime(newEndDateTimeStr);
                        break;

                    case 2: // изменить название
                        Console.WriteLine("Enter new title of event: ");
                        curentEvent.EventTitile = Console.ReadLine();
                        break;

                    case 3: // изменить описание
                        Console.WriteLine("Enter new description of event: ");
                        curentEvent.EventDescription = Console.ReadLine();
                        break;

                    case 4: // изменить тип мероприятия
                        Console.WriteLine("Enter type of event (Personal, Job, Health, Other): ");
                        curentEvent.EventType = GetEventType(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("unknow answer");
                        break;
                }

                // вывести поля текущего события после изменением
                curentEvent.PrintEvent();

            }
            while (cycleControl);

            // внутренний метод - выводи описание режима редактирования
            void PrintEditDescription()
            {
                Console.WriteLine($"Editing mode");
                Console.WriteLine("0 - exit from edit mode" +
                                    "\n1 - change event date" +
                                    "\n2 - change title" +
                                    "\n3 - change description" +
                                    "\n4 - change event type");
            }

        }

        /// <summary>
        /// выполняет загрузку данных из файла
        /// </summary>
        /// <param name="inputPathStr">полный путь к файлу для загрузки</param>
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.InputPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');
                    AddEvent(args[0], args[1], args[2], args[3], args[4]);
                }
            }
        }

        /// <summary>
        /// выполняет загрузку данных из файла по диапазону дат
        /// </summary>
        /// <param name="startData">начальная дата</param>
        /// <param name="endData">конечная дата</param>
        /// <param name="inputPathStr">полный путь к файлу</param>
        public void Load(string inputPathStr, DateTime startData, DateTime endData)
        {
            using (StreamReader sr = new StreamReader(inputPathStr))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');
                    // если даты из файла входят в указанный диапазон, тогда добавим их в список
                    if (GetDateTime(args[0]) >= startData && GetDateTime(args[1]) <= endData)
                        AddEvent(args[0], args[1], args[2], args[3], args[4]);

                }
            }
        }

        /// <summary>
        /// выполняет выгрузку списка событий во внешний файл (замещение записей)
        /// </summary>
        public void Unload()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.outputPath, false))
                {
                    // обойти список, для каждого элемента вызвать метод преобразования полей элемента в одну строку
                    foreach (Event currentEvent in eventList)
                    {
                        sw.WriteLine(GetOutputString(currentEvent)); // записыввем данные события в виде строки в файл
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        /// <summary>
        /// преобразует тип Event в строку, с разделителем ','
        /// </summary>
        /// <param name="currentEvent">Объект типа Event</param>
        /// <returns>строка со значениями полей, разделенных ','</returns>
        private string GetOutputString(Event currentEvent)
        {
            string outputStr = default;

            outputStr += currentEvent.StartOfEvent.ToString() + ",";
            outputStr += currentEvent.EndOfEvent.ToString() + ",";
            outputStr += currentEvent.EventTitile + ",";
            outputStr += currentEvent.EventDescription + ",";
            outputStr += currentEvent.EventType.ToString();

            return outputStr;
        }

        /// <summary>
        /// выводит содержимое списка событий в консоль
        /// </summary>
        public void PrintEvents()
        {
            Console.WriteLine($"{titles[0],20} {titles[1],20} " +
                                $"{titles[2],20} {titles[3],20} " +
                                $"{titles[4],15}");

            foreach(Event currentEvent in eventList)
            {
                Console.WriteLine($"{currentEvent.StartOfEvent,20} {currentEvent.EndOfEvent,20}" +
                                    $"{currentEvent.EventTitile, 20} {currentEvent.EventDescription, 20}" +
                                    $"{currentEvent.EventType, 15}");
            }

        }


        #endregion

    }
}
