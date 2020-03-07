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

            string [] strArrEvent = GetRandomEvent();

            AddEvent(strArrEvent[0], strArrEvent[1], strArrEvent[2], strArrEvent[3], strArrEvent[4]);

            Console.WriteLine("Запись создана и добавлена в ежедневник");

        }

        /// <summary>
        /// метод позволяет изменить значения полей события
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        public void EditEvent(int index)
        {
            // имитируем полное изменение события
            Event curentEvent = eventList[index];

            string[] strArrEvent = GetRandomEvent();

            curentEvent.StartOfEvent = GetDateTime(strArrEvent[0]);
            curentEvent.EndOfEvent = GetDateTime(strArrEvent[1]);

            // изменить название
            curentEvent.EventTitile = strArrEvent[2];

            // изменить описание
            curentEvent.EventDescription = strArrEvent[3];

            // изменить тип мероприятия
            curentEvent.EventType = GetEventType(strArrEvent[4]);

            // вывести поля текущего события после изменением
            curentEvent.PrintEvent();
        }
        
        /// <summary>
        /// сортирует ежедневник по дате начала мероприятия
        /// </summary>
        public void SortScheduleByStarEvent()
        {
            eventList.Sort(new SortEventsByStartDate());
        }

        /// <summary>
        /// сортирует ежедневник по дате окончания мероприятия
        /// </summary>
        public void SortSchedulebyEndEvent()
        {
            eventList.Sort();
        }
        
        /// <summary>
        /// сортирует ежедневник по названию мероприятий
        /// </summary>
        public void SortScheduleByTitle()
        {
            eventList.Sort(new SortEventsByTitle());
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
        /// Удаляет элемент по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveEvent(int index)
        {
            eventList.RemoveAt(index);
        }
               
        /// <summary>
        /// выполняет загрузку данных из основного хранилища
        /// </summary>
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.InputPath))
            {
                while (!sr.EndOfStream)
                {
                    // получаем массив строк по разделителю
                    string[] args = sr.ReadLine().Split(',');
                    AddEvent(args[0], args[1], args[2], args[3], args[4]);
                }
            }
            Console.WriteLine("Данные загружены");

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

        #region service methods

        /// <summary>
        /// возвращает объект DateTime из строки
        /// </summary>
        /// <param name="dateTime">строка с датой в формате yyyy mm dd hh mm ss </param>
        /// <returns></returns>{
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

        private string GetStrStartDate()
        {
            Random r = new Random();

            string strDateTime = Convert.ToString(r.Next(1, 2020)) + " " +
                                    Convert.ToString(r.Next(1, 6)) + " " +
                                    Convert.ToString(r.Next(1, 28)) + " " + "00 " + "00 " + "00";

            return strDateTime;

        }

        private string GetStrEndtDate()
        {
            Random r = new Random();

            string strDateTime = Convert.ToString(r.Next(2020, 3000)) + " " +
                                    Convert.ToString(r.Next(6, 12)) + " " +
                                    Convert.ToString(r.Next(1, 28)) + " " + "00 " + "00 " + "00";

            return strDateTime;

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
        /// генерирует случайное событие
        /// </summary>
        /// <returns>массив строк с полями для создания события</returns>
        private string[] GetRandomEvent()
        {

            // массив для хранения значений полей события
            string[] strArrEvent = new string[5];

            strArrEvent[0] = (GetStrStartDate()); // дата начала события
            strArrEvent[1] = (GetStrEndtDate()); // дата окончания события

            Random r = new Random();

            strArrEvent[2] = ("Test event " + Convert.ToString(r.Next(1, 9999))); // название события

            strArrEvent[3] = ("Test event " + Convert.ToString(r.Next(1, 9999))); // описание события

            int intTypeOfEvent = r.Next(1, 4);
            string strEventType = default;

            switch (intTypeOfEvent)
            {
                case 1:
                    strEventType = "Personal";
                    break;
                case 2:
                    strEventType = "Job"; break;
                case 3:
                    strEventType = "Health"; break;
                default:
                    strEventType = "Other"; break;
            }

            strArrEvent[4] = (strEventType); // тип события

            return strArrEvent;

        }


        #endregion

    }
}
