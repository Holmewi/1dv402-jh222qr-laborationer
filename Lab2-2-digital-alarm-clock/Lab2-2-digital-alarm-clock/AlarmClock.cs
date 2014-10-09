using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_digital_alarm_clock
{
    public class AlarmClock // Åh... public så klart!!
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public int AlarmHour
        {
            get { return _alarmHour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte inom intervallet 0-23.");
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set 
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte inom intervallet 0-59.");
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte inom intervallet 0-23.");
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set 
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte inom intervallet 0-59.");
                }
                _minute = value;
            }
        }

        public AlarmClock()
            :this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        {
  
        }

        // I finally found the evil little error to get the tests to work properly. 
        // I accidentally gave the fields the new values instead of giving the value to the new variables.
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            // Clock is ticking
            Minute++;

            if(Minute > 59)
            {
                Minute = 0;
                Hour++;
                if (Hour > 23)
                {
                    Hour = 0;
                }
            }

            

            // Alarm i ringing when true in the method run in the base class (hopefully)
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;  
            }
               
        }

        // The method overrides the ToString in the base class
        public override string ToString()
        {
            // Returning a string to the run method
            // Tried to make the minutes show correctly. Time will tell...
            // Well, they didn't so I changed the format to show correctly with 00.
            // Source: http://www.csharp-examples.net/string-format-datetime/
            return String.Format("{0:}:{1:00} <{2:}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute); 
        }
    }
}
