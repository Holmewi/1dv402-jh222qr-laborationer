using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1_3_SalaryReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler

            int _salaryCount;
            int[] _salary;
            string _prompt = "Ange antal löner att mata in: ";
            string _promptSalary = "Ange lön nummer {0}: ";

            do
            {
                _salaryCount = ReadInt(_prompt);
                _salary = ReadSalaries(_salaryCount, _promptSalary);
                    
            Console.WriteLine("");

            ProcessSalaries(_salary, _salaryCount);
            KeyInput(args);

            } while (IsContinuing());

        }





        // Mata in antal löner som ska redovisas - skriv ut meddelande och värdet
        private static int ReadInt(string _prompt) 
        {
                /* 
                 * Efter väldigt mycket läsande, fann jag en lösning till att få med sig värdet 
                 * som string till catch-satsen FormatException. Känns som att det borde finnas
                 * mer logiska sätt att lösa det på.
                 * Källa: http://stackoverflow.com/questions/12550184/throw-a-format-exception-c-sharp
                 */ 
                Console.Write(_prompt);
                string line = Console.ReadLine();
                int _value;

                _value = Int32.Parse(line);

                return _value; 
        }

        private static int[] ReadSalaries(int _salaryCount, string _promptSalary)
        {
            int[] _salary = new int[_salaryCount];
            

            for (int row = 0; row < _salaryCount; row++)
                    {
                        Console.Write(_promptSalary, row + 1);
                        _salary[row] = int.Parse(Console.ReadLine());
                    }
                return _salary;

        }

        // Mata in löner och spara dessa i en array av typen int - skriv uts meddelande och värdet
        // Skapade en array för variablen _salary för att spara x antal löner som specifieras av _salaryCount
        private static void ProcessSalaries(int[] _salary, int _salaryCount)
        {
            

            // Kopierade arrayen för att kunna lista den i ursprunglig ordning efter att den sorterats
            int[] _target = new int[_salaryCount];
            Array.Copy(_salary, _target, _salaryCount);


            Console.WriteLine("\n-----------------------------------");
            GetMedian(_salary, _salaryCount);
            AvarageSalary(_salary);
            GetDispertion(_salary);
            Console.WriteLine("-----------------------------------");


            // Skapa en lista med max tre columner

            for (int i = 0; i < _target.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                System.Console.Write("{0,8}", _target[i]);
            }
            Console.WriteLine("\n\n");
        }

        // Räkna ut medianlön - Sortera arrayen och plocka ut medianlönen

        /* Jag satt själv och kodade ihop en liknande lösning genom att dra av -1 på slutvärder på variabel 'b'
         * men tog för givet att det måste finnas ett bättre sätt. Men till min förvåning och glädje var
         * det första jag hittade en liknande lösning.
         * Källa: http://stackoverflow.com/questions/5275115/add-a-median-method-to-a-list
         */
        static void GetMedian(int[] _salary, int _salaryCount)
        {
            
            Array.Sort(_salary);

            if (_salaryCount % 2 == 0)
            {
                int a = _salary[_salaryCount / 2 - 1];
                int b = _salary[_salaryCount / 2];
                Console.WriteLine("{0} {1,14:c0}", "Medianlön:", (a + b) / 2);
            }
            else
            {
                Console.WriteLine("{0} {1,14:c0}", "Medianlön:", _salary[_salaryCount / 2]);
            }
        }

        // Räkna ut medellön - Addera lönerna och dividera med antalet inmatade löner
        static void AvarageSalary(int[] _salary)
        {
            Console.WriteLine("{0} {1,15:c0}", "Medellön:", _salary.Average());
        }

        // Räkna ut lönespridning - Subrahera den högsta lönen med den lägsta
        static void GetDispertion(int[] _salary)
        {
            Console.WriteLine("{0} {1,10:c0}", "Lönespridning:", _salary.Max() - _salary.Min());
        }


        // Skapa hantering av key input där escape avslutar programmet medan andra tangenter startar om applikationen
        static void KeyInput(string[] args)  // Källa http://www.codeproject.com/Questions/271195/Is-it-possible-to-refresh-the-console-application
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Tryck tangent för ny beräkning - Esc avslutar. ");
            Console.ResetColor();


            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Clear();  // Källa: http://stackoverflow.com/questions/6238232/how-to-clear-the-entire-console-window
                Main(args);
            }
            else
            {
                Environment.Exit(0);  // Källa: http://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
            }
        }

        public static bool IsContinuing()
        {
            
            bool _isError = true;
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                _isError = false;
            }
            return _isError;   
        }

        /* Frågor:
         * Hur kan medianlönen och medellönen vara olika när man enbart matar in två tal?
         * Varför funkar inte metoden IsContinuing?
         * Hur gör man för att slippa börja från start i arrayen efter att ett exception har kastats?
         */
    }
}
