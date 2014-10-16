using System;
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
            

            // "Metoden CreateShape anropas vid annat val än avsluta och returnerar en referens till Ellips eller Rectangle"
            // "Referensen används sedan vid anrop av ViewShapeDetail som presenterar figurens detaljer"
            do
            {
                // "Visa menyn på nytt när beräkningen är gjord"
                Console.Clear();

                // "Ska anropa metoden ViewMenu för att visa en meny"
                ViewMenu(); 

                // Making sure that the inputValue return to an int value
                int menuValue;
                string inputValue = Console.ReadLine();

                try
                {
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

                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 2. \n");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange enbart heltal mellan 0 och 2. \n");
                    Console.ResetColor();
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Tryck tangent för att fortsätta ");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                 
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.Clear();

            // "Metoden ska ha parametrar av type ShapeType vars värde bestämmer om en ellips eller en rektangel ska skapas"
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("===========================================");
                    Console.WriteLine("=                Rectangle                =");
                    Console.WriteLine("===========================================\n");
                    Console.ResetColor();
                    break;

                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("===========================================");
                    Console.WriteLine("=                 Ellipse                 =");
                    Console.WriteLine("===========================================\n");
                    Console.ResetColor();
                    break;
            }

            // "Läsa in figurens längd och bredd"
            // A string argument and the value is sent from the method ReadDoubleGreaterThanZero

            double lenght = ReadDoubleGreaterThanZero("Ange längden: ");  // Temporary value
            double width = ReadDoubleGreaterThanZero("Ange bredden: "); ;   // Temporary value

            // "Skapa objektet och returnera en referens till det"
            /* Den gamla
            if (shapeType == ShapeType.Rectangle)
            {
                Rectangle rectangle = new Rectangle(lenght, width);
                return rectangle;
            }
            
            else
            {
                Ellipse ellipse = new Ellipse(lenght, width);
                return ellipse;
            }      
             */

            Shape s;
          
            if (shapeType == ShapeType.Rectangle)
            {
                s = new Rectangle(lenght, width);
                
            }
            
            else
            {
                s = new Ellipse(lenght, width);
               
            }
            return s;
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            // "Ska returnera ett värde av typen double som är större än 0"
            // "Ge möjligheten att skicka ett argument av typen string"
            // "Argumentet ska vara information som visas i anslutning till där inmatningen sker"
            // "Om det inmatade värdet inte kan tolkas korrekt ska användaren få en ny chans och ett felmeddelande ska visas"
            
            double promptInput = 1;

            do
            {
                try
                {
                    Console.Write(prompt);
                    promptInput = double.Parse(Console.ReadLine());

                    if (promptInput > 0)
                    {
                        return promptInput;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange ett flyttal större än 0. \n");
                    Console.ResetColor();
                }
                
            } while (true);


            

        }

        private static void ViewMenu()
        {
            // "Presentera en meny med tre val, Avsluta, Ellips och Rektangel"
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===========================================");
            Console.WriteLine("=                                         =");
            Console.WriteLine("=           Geometriska figurer           =");
            Console.WriteLine("=                                         =");
            Console.WriteLine("===========================================");
            Console.ResetColor();

            Console.WriteLine("\n0. Avsluta\n\n1. Ellips\n\n2. Rektangel\n");
            Console.WriteLine("-------------------------------------------");
            Console.Write("\nAnge menyval [0-2]: ");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            // "Presentera en figurs detaljer"
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================================");
            Console.WriteLine("=                Detaljer                 =");
            Console.WriteLine("===========================================");
            Console.ResetColor();

            // "Vid anrop av metoden skickas ett argument med som refererar till figuren, vars detaljer presenteras"
            // "Parametern "shape" av typen "Shape" refererar till figuren"
            // "Nyttja att basklassen Shape överskuggar metoden ToString när figurens längd, bredd, omkrets och area presenteras"
            Console.WriteLine(shape.ToString());
            Console.WriteLine("-------------------------------------------\n");

        }
    }
}
