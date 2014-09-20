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
            int row = 0;
            string _prompt = "Ange antal löner att mata in: ";
            
            int _salaryCount = ReadInt(_prompt);
            Console.WriteLine("");

            ProcessSalaries(row, _salaryCount);
        }

        // Mata in antal löner som ska redovisas - skriv ut meddelande och värdet
        static int ReadInt(string _prompt)
        {
            int _salaryCount;
            Console.Write(_prompt);
            _salaryCount = int.Parse(Console.ReadLine());
            if (_salaryCount < 2)
            {
                throw new Exception();
            }
            else
            {
                return _salaryCount;
            }
            
        }


        // Mata in löner och spara dessa i en array av typen int - skriv ut meddelande och värdet
        // Skapade en array för variablen _salary för att spara x antal löner som specifieras av _salaryCount
        static void ProcessSalaries(int row, int _salaryCount)
        {
            int[] _salary = new int[_salaryCount];
            

            for (row = 0; row < _salaryCount; row++)
            {
                Console.Write("Ange lön nummer {0}: ", row + 1);
                _salary[row] = int.Parse(Console.ReadLine());
            }

            // Kopierade arrayen för att kunna lista den i ursprunglig ordning efter att den sorterats
            int[] _target = new int[_salaryCount];
            Array.Copy(_salary, _target, _salaryCount);
            

            Console.WriteLine("\n-----------------------------------");
            MediumSalary(_salary, _salaryCount);
            AvarageSalary(_salary);
            SalaryDistribution(_salary);
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
        static void MediumSalary(int[] _salary, int _salaryCount)
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
        static void SalaryDistribution(int[] _salary)
        {
            Console.WriteLine("{0} {1,10:c0}", "Lönespridning:", _salary.Max() - _salary.Min());
        }

        
        

        // Skapa en felhantering med try-catch-satser


        // Skapa hantering av key input där escape avslutar programmet medan andra tangenter startar om applikationen


    }
}
