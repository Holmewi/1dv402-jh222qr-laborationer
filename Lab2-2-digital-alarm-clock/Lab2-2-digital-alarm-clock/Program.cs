using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_digital_alarm_clock
{
    class Program
    {
        static void Main(string[] args)
        {
           //AlarmClock ac = new AlarmClock();

            // Test 1 - Standardkonstruktor
           
            Console.WriteLine("{0}\nTest 1 \nTest av standardkonstrukorn.", HorizontalLine);
            AlarmClock testClock1 = new AlarmClock();
            Console.WriteLine(testClock1.ToString());
            
        }

        private static string HorizontalLine = "=============================================";

        private static void Run(AlarmClock ac, int minutes)
        {

        }

        private static void ViewErrorMessage(string message)
        {

        }

        private static void ViewTestHeader(string header)
        {

        }
    }
}
