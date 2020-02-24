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

    public class Event
    {
        // fields
        private DateTime startOfEvent; // start of event
        private DateTime endOfEvent; // end of event
        private string eventTitile; // title of event
        private string eventDescription; // event desc
        private eventType eventType; // type of Event (personal deal, job, chil or other)
                                     // private Event parentEvenet; // parent event (link to another event)


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
        public void Print()
        {
            Console.WriteLine($"{this.startOfEvent, 20} {this.endOfEvent, 20} " +
                                $"{this.eventTitile, 20} {this.eventDescription, 20} {this.eventType, 5}");
        }

        #endregion

    }
}
