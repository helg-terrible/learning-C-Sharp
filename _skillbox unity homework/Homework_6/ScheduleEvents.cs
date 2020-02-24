using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class ScheduleEvents
    {
        #region fields
        private List<Event> eventList = new List<Event>();

        private static string[] titles = { "Start of event", "End of event", "Title", "Description", "Event's type" };

        #endregion

        #region ctors
        public ScheduleEvents() {}

        #endregion

        #region properties


        #endregion

        #region methods
        /// <summary>
        /// добавляет новый объект типа Event в список
        /// </summary>
        /// <param name="startOfEvent">формат yyyy mm dd hh mm ss</param>
        /// <param name="endOfEvent">формат yyyy mm dd hh mm ss</param>
        /// <param name="eventTitle">заголовок события, не более 15 символов</param>
        /// <param name="eventDescription">описание события, не более 300 символов</param>
        /// <param name="eventType">тип события</param>
        public void AddItem(string strStartOfEvent, string strEndOfEvent, string strEventTitle, string strEventDescription, string strEventType)
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
        /// возвращает объект дата время из строки
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
        /// по строке определяет тип события
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

        public void RemoveItem(int index)
        {
            eventList.RemoveAt(index);
        }
        #endregion

    }
}
