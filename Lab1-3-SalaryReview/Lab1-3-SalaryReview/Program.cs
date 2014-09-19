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
            int row;

            // Mata in antal löner som ska redovisas - skriv ut meddelande och värdet
            Console.Write("Ange antal löner att mata in: ");
            _salaryCount = int.Parse(Console.ReadLine());


            // Mata in löner och spara dessa i en array av typen int - skriv ut meddelande och värdet
            // Skapade en array för variablen _salary för att spara x antal löner som specifieras av _salaryCount
            int[] _salary = new int[_salaryCount];
 
            for (row = 0; row < _salaryCount; row++)
            {
                Console.Write("Ange lön nummer {0}: ", row+1);
                _salary[row] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n-----------------------------------");
            MediumSalary(_salary, _salaryCount, row);
            Console.WriteLine("-----------------------------------\n");
            
            for (row = 0; row < _salaryCount; row++ )
            {
                Console.WriteLine(_salary[row]);
            }

        }

        // Räkna ut medianlön - Sortera arrayen och plocka ut medianlönen

        /* Jag satt själv och kodade ihop en liknande lösning genom att dra av -1 på slutvärder på variabel 'b'
         * men tog för givet att det måste finnas ett bättre sätt. Men till min förvåning och glädje var
         * det första jag hittade en liknande lösning.
         * Källa: http://stackoverflow.com/questions/5275115/add-a-median-method-to-a-list
         */
        static void MediumSalary(int[] _salary, int _salaryCount, int row)
        {
            Array.Sort(_salary);
            int _count = _salary.Length;           
           
            if (_count % 2 == 0)
            {
                int a = _salary[_count / 2 - 1];
                int b = _salary[_count / 2];
                Console.WriteLine("Medianlön: {0}", (a + b) / 2);
            }
            else
            {
                Console.WriteLine("Medianlön: {0}", _salary[_count / 2]);
            }
        }

        // Räkna ut medellön - Addera lönerna och dividera med antalet inmatade löner
        static void AvarageSalary()
        {
            throw new NotImplementedException();
        }

        // Räkna ut lönespridning - Subrahera den högsta lönen med den lägsta
        static void SalaryDistribution()
        {
            throw new NotImplementedException();
        }

        // Skapa en felhantering med try-catch-satser


        // Skapa hantering av key input där escape avslutar programmet medan andra tangenter startar om applikationen


    }
}
