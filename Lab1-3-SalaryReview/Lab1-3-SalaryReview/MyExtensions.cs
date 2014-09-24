using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3_SalaryReview
{
    public class MyExtensions
    {
        // Räkna ut medianlön - Sortera arrayen och plocka ut medianlönen

        /* Jag satt själv och kodade ihop en liknande lösning genom att dra av -1 på slutvärder på variabel 'b'
         * men tog för givet att det måste finnas ett bättre sätt. Men till min förvåning och glädje var
         * det första jag hittade en liknande lösning.
         * Källa: http://stackoverflow.com/questions/5275115/add-a-median-method-to-a-list
         */
        public void GetMedian(int[] _salary, int _salaryCount)
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

        // Räkna ut lönespridning - Subrahera den högsta lönen med den lägsta
        public void GetDispertion(int[] _salary)
        {
            Console.WriteLine("{0} {1,10:c0}", "Lönespridning:", _salary.Max() - _salary.Min());
        }

        // Räkna ut medellön - Addera lönerna och dividera med antalet inmatade löner
        public void AvarageSalary(int[] _salary)
        {
            Console.WriteLine("{0} {1,15:c0}", "Medellön:", _salary.Average());
        }
    }
}
