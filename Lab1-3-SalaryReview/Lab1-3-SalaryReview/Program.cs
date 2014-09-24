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

            int _salaryCount = 0;
            int[] _salary;
            string _prompt = "Ange antal löner att mata in: ";
            string _promptSalary = "Ange lön nummer {0}: ";

            do
            {
                _salaryCount = ReadInt(_prompt, _salaryCount);
                Console.WriteLine("");
                _salary = ReadSalaries(_salaryCount, _promptSalary);

                Console.WriteLine("");
                ViewResult(_salary, _salaryCount);

            KeyInput(args);
            } while (IsContinuing());
            
        }





        // Mata in antal löner som ska redovisas - skriv ut meddelande och värdet
        private static int ReadInt(string _prompt, int _salaryCount) 
        {
                /* 
                 * Efter väldigt mycket läsande, fann jag en lösning till att få med sig värdet 
                 * som string till catch-satsen FormatException. Känns som att det borde finnas
                 * mer logiska sätt att lösa det på.
                 * Källa: http://stackoverflow.com/questions/12550184/throw-a-format-exception-c-sharp
                 */
        while (true)
        {
            Console.Write(_prompt);
            string line = Console.ReadLine();
            try 
            {
                _salaryCount = Int32.Parse(line);
                if (_salaryCount < 2)
                {
                    throw new Exception();
                }
                return _salaryCount;
            }

            catch (OverflowException)
            {
                ViewMessage(" FEL! Det angivna talet är för stort. ", true);
            }
            catch (FormatException)
            {
                ViewMessage(" FEL! '" + line + "' kan inte tolkas som ett heltal. ", true);
            }
            catch (Exception)
            {
                ViewMessage(" FEL! Det angivna talet får inte vara mindre än 2. ", true);
            }         
        }
            
        }



        private static int[] ReadSalaries(int _salaryCount, string _promptSalary)
        {
            int[] _salary = new int[_salaryCount];

            while (true)
            {
                
                try
                {
                    for (int row = 0; row < _salaryCount; row++)
                    {
                        Console.Write(_promptSalary, row + 1);
                        _salary[row] = int.Parse(Console.ReadLine());
                        if (_salary[row] < 1)
                        {
                            throw new Exception();
                        }
                    }
                    
                    return _salary;
                }
                catch (OverflowException)
                {
                    ViewMessage(" FEL! Det angivna talet är för stort. ", true);
                }
                catch (FormatException)
                {
                    ViewMessage(" FEL! Kan inte tolkas som ett heltal. ", true);
                }
                catch (Exception)
                {
                    ViewMessage(" FEL! Det angivna talet får inte vara mindre än 1. ", true);
                }
            }

        }

        // Mata in löner och spara dessa i en array av typen int - skriv uts meddelande och värdet
        // Skapade en array för variablen _salary för att spara x antal löner som specifieras av _salaryCount
        static void ViewResult(int[] _salary, int _salaryCount)
        {
            MyExtensions myExtensions = new MyExtensions();

            // Kopierade arrayen för att kunna lista den i ursprunglig ordning efter att den sorterats
            int[] _target = new int[_salaryCount];
            Array.Copy(_salary, _target, _salaryCount);


            Console.WriteLine("\n-----------------------------------");
            myExtensions.GetMedian(_salary, _salaryCount);
            myExtensions.AvarageSalary(_salary);
            myExtensions.GetDispertion(_salary);
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



        // Skapa hantering av key input där escape avslutar programmet medan andra tangenter startar om applikationen
        static void KeyInput(string[] args)  // Källa http://www.codeproject.com/Questions/271195/Is-it-possible-to-refresh-the-console-application
        {
            ViewMessage(" Tryck tangent för ny beräkning - Esc avslutar. ", false);
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

            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }

        static void ViewMessage(string prompt, bool isError/*ConsoleColor BackgroundColor, ConsoleColor ForegroundColor*/)
        {
            Console.WriteLine("");
            if (isError)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.WriteLine(prompt);
            Console.ResetColor();
            Console.WriteLine("");
        }

        /* Frågor:
         * Hur kan medianlönen och medellönen vara olika när man enbart matar in två tal?
         * Varför funkar inte metoden IsContinuing?
         * Hur gör man för att slippa börja från start i arrayen efter att ett exception har kastats?
         * Hur skickar jag in ett värde som ligger i en Exception som ligger i en try-sats?
         */
    }
}
