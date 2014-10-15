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
            // Metoden CreateShape anropas vid annat val än avsluta och returnerar en referens till Ellips eller Rectangle
            // Referensen används sedan vid anrop av ViewDetail som presenterar figurens detaljer
            // Visa menyn på nytt när beräkningen är gjord

        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            // Läsa in figurens längd och bredd
            
            // Skapa objektet och returnera en referens till det
            // Metoden ska ha parametrar av type ShapeType vars värde bestämmer om en ellips ska skapas
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            // Ska returnera ett värde av typen double som är större än 0
            // Ge möjligheten att skicka ett argument av typen string
            // Argumentet ska vara information som visas i anslutning till där inmatningen sker
            // Om det inmatade värdet inte kan tolkas korekt ska användaren få en ny chans och ett felmeddelande ska visas

        }

        private static void ViewMenu()
        {
            // Presentera en meny med tre val, Avsluta, Ellips och Rektangel
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
