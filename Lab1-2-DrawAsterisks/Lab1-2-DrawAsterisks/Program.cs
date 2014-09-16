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
            // Deklarera variabler


            // Satser
            // Console.Write(" ");
            // Console.Write("* ");
            // Console.WriteLine();

            // Skapa nästlade for-loopar med asterisker innhållande 39 kolumner och 25 rader

            for (int col = 0; col < 25; col++ )
            { 
                for (int i = 0; i < 39; i++)
                {
                    Console.Write("* ");
                    for (int j = 0; j < 0; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            // Skjut in varannan rad med hjälp av en if-sats och modulusoperator


            // Skapa modulusoperatorn för att färglägga raderna med hjälp av en switch-satss



        }
    }
}