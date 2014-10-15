﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3_geometric_figures
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Ska anropa metoden ViewMenu för att visa en meny.
            ViewMenu(); 

            // Metoden CreateShape anropas vid annat val än avsluta och returnerar en referens till Ellips eller Rectangle
            // Referensen används sedan vid anrop av ViewShapeDetail som presenterar figurens detaljer
            do
            {
                // Making sure that the inputValue return to an int value
                int menuValue;
                string inputValue = Console.ReadLine();
                menuValue = int.Parse(inputValue);

                switch (menuValue)
                {
                    case 0: return;

                    case 1:
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        break;

                    case 2:
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                        break;
                }

            } while (true);
            
            // Visa menyn på nytt när beräkningen är gjord
            
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            // Läsa in figurens längd och bredd
            // Skapa objektet och returnera en referens till det
            // Metoden ska ha parametrar av type ShapeType vars värde bestämmer om en ellips ska skapas
            throw new Exception("TEST TEST");
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            // Ska returnera ett värde av typen double som är större än 0
            // Ge möjligheten att skicka ett argument av typen string
            // Argumentet ska vara information som visas i anslutning till där inmatningen sker
            // Om det inmatade värdet inte kan tolkas korekt ska användaren få en ny chans och ett felmeddelande ska visas

            throw new Exception();

        }

        private static void ViewMenu()
        {
            // Presentera en meny med tre val, Avsluta, Ellips och Rektangel
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-                                         -");
            Console.WriteLine("-           Geometriska figurer           -");
            Console.WriteLine("-                                         -");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("\n0. Avsluta\n\n1. Ellips\n\n2. Rektangel\n");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\nAnge menyval [0-2]: ");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            // Presentera en figurs detaljer
            // Vid anrop av metoden skickas ett argument med som refererar till figuren, vars detaljer presenteras
            // Parametern "shape" av typen "Shape" refererar till figuren
            // Nyttja att basklassen Shape överskuggar metoden ToString när figurens längd, bredd, omkrets och area presenteras
        }
    }
}
