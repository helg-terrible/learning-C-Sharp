using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public enum eventType
    {
        Personal,
        Job,
        Health,
        Other
    }

    public class Event : IComparable<Event>
    {
        // fields
        private DateTime startOfEvent; // start of event
        private DateTime endOfEvent; // end of event
        private string eventTitile; // title of event
        private string eventDescription; // event desc
        private eventType eventType; // type of Event (personal deal, job, chil or other)

        #region ctors
        /// <summary>
        /// type of event other
        /// </summary>
        public Event() : this(new DateTime(), new DateTime(), default, default, eventType.Other) { }

        // конструктор с типом записи other по-умолчанию
        public Event(DateTime startOfEvent, DateTime endOfEvent, string eventTitile) :
            this(startOfEvent, endOfEvent, eventTitile, "", eventType.Other) { }

        public Event(DateTime startOfEvent, DateTime endOfEvent, string eventTitile, string eventDescription, eventType eventType)
        {
            this.startOfEvent = startOfEvent;
            this.endOfEvent = endOfEvent;
            this.eventTitile = eventTitile;
            this.eventDescription = eventDescription;
            this.eventType = eventType;
        }

        #endregion


        #region Properties
        public DateTime StartOfEvent
        {
            get { return startOfEvent; }
            set { startOfEvent = value; }
        }

        public DateTime EndOfEvent
        {
            get { return endOfEvent; }
            set { endOfEvent = value; }
        }

        public string EventTitile
        {
            get { return eventTitile; }
            set { eventTitile = value; }
        }

        public string EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }

        public eventType EventType 
        { 
            get { return eventType; } 
            set { eventType = value; }
        }

        #endregion


        #region Methods
        public void PrintEvent()
        {
            Console.WriteLine($"{this.startOfEvent, 20} {this.endOfEvent, 20} " +
                                $"{this.eventTitile, 20} {this.eventDescription, 20} {this.eventType, 5}");
        }

        /// <summary>
        /// выполняет сортировку по дате окончания мероприятия
        /// </summary>
        /// <param name="otherEvent"></param>
        /// <returns></returns>
        public int CompareTo(Event other)
        {
            int compareResult = default;

            compareResult = DateTime.Compare(this.EndOfEvent, other.EndOfEvent);

            return compareResult;

        }

        /// <summary>
        /// интерфейс IComparer, для реелизации сортировок коллекции объектов
        /// </summary>
        public interface IComparer
        {
            int Compare(object a, object b);
        }

               
        #endregion

    }


    #region copmaparators
    /// <summary>
    /// сортировка дате начала
    /// </summary>
    class SortEventsByStartDate : IComparer<Event>
    {
        public int Compare(Event x, Event y)
        {
            return DateTime.Compare(x.StartOfEvent, y.StartOfEvent);   
        }
    }

    /// <summary>
    /// сортировка по назаванию мероприятия
    /// </summary>
    class SortEventsByTitle : IComparer<Event>
    {
        public int Compare(Event x, Event y)
        {
            return String.Compare(x.EventTitile, y.EventTitile);
        }
    }



    #endregion
}
