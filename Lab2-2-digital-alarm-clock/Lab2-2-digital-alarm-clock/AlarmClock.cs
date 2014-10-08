using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_digital_alarm_clock
{
    class AlarmClock
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
                if(_alarmHour < 0 && _alarmHour > 23)
                {
                    throw new ArgumentException();
                }
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set 
            {
                if (_alarmMinute < 0 && _alarmMinute > 59)
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Hour
        {
            get { return _hour; }
            set 
            {
                if (_hour < 0 && _hour > 23)
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Minute
        {
            get { return _minute; }
            set 
            {
                if (_minute < 0 && _minute > 59)
                {
                    throw new ArgumentException();
                }
            }
        }

        public AlarmClock()
        {

        }

        public AlarmClock(int hour, int minute)
        {
  
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = _hour;
            Minute = _minute;
            AlarmHour = _alarmHour;
            AlarmMinute = _alarmMinute;
        }

        public bool TickTock()
        {

        }

        public string ToString()
        {

        }
    }
}
