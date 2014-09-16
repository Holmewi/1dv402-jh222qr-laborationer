using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa nästlade for-loopar med asterisker innhållande 39 kolumner och 25 rader

            for (int row = 0; row < 25; row++)
            {
                // Skjut in varannan rad med hjälp av en if-sats och modulusoperator
                // Hittade lite hjälp på källan http://www.dotnetperls.com/odd
                // Om parameten row inte är delbar med 2 så är remindern inte lika med 0, vilket tyder på att talet inte är jämt

                if (row % 2 != 0)
                {  
                    Console.Write(" ");
                }
                for (int col = 0; col < 39; col++)
                {
                    // Skapa modulusoperatorn för att färglägga raderna med hjälp av en switch-sats
                    switch (row % 3)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case 1:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }

                    Console.Write("* ");
                    Console.ResetColor();
                }

                Console.WriteLine("");
            }

            

            

        }


    }
}