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
            // Test 1 - Standardkonstruktor
            AlarmClock testClock1 = new AlarmClock();
            ViewTestHeader("Test 1 \nTest av standardkonstrukorn.");
            Console.WriteLine(testClock1.ToString());

            // Test 2 - Standardkonstruktor
            AlarmClock testClock2 = new AlarmClock(9, 42);
            ViewTestHeader("Test 2 \nTest av konstruktorn med två parametrar.");
            Console.WriteLine(testClock2.ToString());


            
        }

        private static string HorizontalLine = "=============================================";

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if(ac.TickTock()) // If true in AlarmClock
                {
                    Console.WriteLine(ac.ToString() + "BEEP!");
                }
                else 
                {
                    Console.WriteLine(ac.ToString());
                }              
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine("\n" + HorizontalLine + "\n" + header + "\n");
        }
    }
}
