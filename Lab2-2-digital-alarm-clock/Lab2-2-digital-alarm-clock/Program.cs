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
            // Test 1 
            AlarmClock testClock = new AlarmClock();
            ViewTestHeader("Test 1 \nTest av standardkonstrukorn.");
            Console.WriteLine(testClock.ToString());

            // Test 2 
            testClock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2 \nTest av konstruktorn med två parametrar.");
            Console.WriteLine(testClock.ToString());

            // Test 3 
            testClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3 \nTest av konstruktorn med fyra parametrar.");
            Console.WriteLine(testClock.ToString());

            // Test 4 
            testClock = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("Test 4 \nTest av metoden TickTock() som ska låta klockan gå en minut.");
            Run(testClock, 13);

            // Test 5 
            testClock = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5 \nStäller befintligt AlarmClock-objekt.");
            Run(testClock, 6);

            // Test 6
            ViewTestHeader("Test 6 \nTest av egenskaperna så att undantag kastas.");

            int subtract = 0;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    testClock.Hour = 24 - subtract;
                    testClock.Minute = 61 - subtract;
                    testClock.AlarmHour = 26 - subtract;
                    testClock.AlarmMinute = 64 - subtract;
                }
                catch (ArgumentException e)
                {
                    ViewErrorMessage(e.Message);
                    subtract++;
                }
            }

            // Test 7
            ViewTestHeader("Test 7 \nTest av konstruktorer så att undantag kastas.");

            subtract = 0;
            for (int i = 0; i < 2; i++)
            {
                try
                {
                testClock = new AlarmClock(24 - subtract, 0, 25 - subtract, 0);
                }

                catch (ArgumentException e)
                {
                    ViewErrorMessage(e.Message);
                    subtract++;
                }
            }

           
        }

        private static string HorizontalLine = "═════════════════════════════════════════════════════════";

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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine("\n" + HorizontalLine + "\n" + header + "\n");
        }
    }
}
