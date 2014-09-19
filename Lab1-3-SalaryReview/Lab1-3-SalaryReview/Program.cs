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
            int _salary = 0;

            // Mata in antal löner som ska redovisas - skriv ut meddelande och värdet
            Console.Write("Ange antal löner att mata in: ");
            _salaryCount = int.Parse(Console.ReadLine());


            // Mata in löner och spara dessa i en array av typen int - skriv ut meddelande och värdet

            for (int row = 1; row <= _salaryCount; row++)
            {
                Console.Write("Ange lön nummer {0}: ", row);
                _salary = int.Parse(Console.ReadLine());
            }


            
            // Räkna ut medianlön - Sortera arrayen och plocka ut medianlönen


            // Räkna ut medellön - Addera lönerna och dividera med antalet inmatade löner


            // Räkna ut lönespridning - Subrahera den högsta lönen med den lägsta


            // Skapa en felhantering med try-catch-satser


            // Skapa hantering av key input där escape avslutar programmet medan andra tangenter startar om applikationen


        }


    }
}
