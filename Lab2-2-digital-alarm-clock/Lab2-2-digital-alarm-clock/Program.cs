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
            AlarmClock testClock = new AlarmClock();
            ViewTestHeader("Test 1 \nTest av standardkonstrukorn.");
            Console.WriteLine(testClock.ToString());

            // Test 2 - Konstruktorn med två parametrar
            testClock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2 \nTest av konstruktorn med två parametrar.");
            Console.WriteLine(testClock.ToString());

            // Test 3 - Konstruktorn med fyra parametrar
            testClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3 \nTest av konstruktorn med fyra parametrar.");
            Console.WriteLine(testClock.ToString());

            // Test 4 - Metoden TickTock som ska låta klockan gå en minut
            testClock = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("Test 4 \nTest av metoden TickTock() som ska låta klockan gå en minut.");
            Run(testClock, 13);
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
