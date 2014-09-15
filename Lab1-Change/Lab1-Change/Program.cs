using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Change
{
    class Program
    {   

        static void Main(string[] args)
        {
            // Deklarera variabler
            string _subtotalInfo = "Ange totalsumma \t: ";
            string _totalInfo = "Ange erhållet belopp \t: ";

            //Hämta värden från vardin separat metod
            double _subtotal = ReadPostiveDouble(_subtotalInfo);
            uint _total = ReadUint(_totalInfo, _subtotal);

            double _roundingOffAmount;
            uint _amountToPay;
            uint _amountBack;
            
            // Räkna ut öresavrundning
            _amountToPay = (uint)Math.Round(_subtotal);
            _roundingOffAmount = _amountToPay - _subtotal;

            // Räkna ut differens
            _amountBack = _total - _amountToPay;

            // Skriv ut kvittens
            // Källa till formateringen på stings http://www.csharp-examples.net/align-string-with-spaces/

            Console.WriteLine("\nKVITTO\n-----------------------------------");
            Console.WriteLine(String.Format("{0,-18} {1} {2,14:c}", "Totalt", ":", _subtotal));
            Console.WriteLine(String.Format("{0,-18} {1} {2,14:c}", "Öresavrundning", ":", _roundingOffAmount));
            Console.WriteLine(String.Format("{0,-18} {1} {2,14:c0}", "Att betala", ":", _amountToPay));
            Console.WriteLine(String.Format("{0,-18} {1} {2,14:c0}", "Kontant", ":", _total));
            Console.WriteLine(String.Format("{0,-18} {1} {2,14:c0}", "Tillbaka", ":", _amountBack));
            Console.WriteLine("-----------------------------------\n");

            SplitIntoDenomiations(_subtotal, _total, _amountBack);    
        }

        // Input från användaren - belopp att betala
        public static double ReadPostiveDouble(string prompt)
        {
            do
                {
                    try
                    {
                        double input;
                        Console.Write(prompt);
                        input = double.Parse(Console.ReadLine());   // Acceptera max två decimaler?
                        //ERROR = false;

                        if (input < 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n FEL! {0} är ett för litet tal, var god försök igen \n", input);
                            Console.ResetColor();
                            //ERROR = true;
                        }
                        return input;
                    }

                    catch (OverflowException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n FEL! Du matade in ett för stort tal, var god försök igen \n");
                        Console.ResetColor();
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n FEL! Du matade in ett felaktigt tal, var god försök igen \n");
                        Console.ResetColor();
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n Något allvarligt fel inträffade \n");
                    }
                } while (true);
        }

        // Input från användaren - erhållet belopp
        public static uint ReadUint(string prompt, double SUBTOTAL)
        {
            do
            {
                try
                {
                    uint input;
                    Console.Write(prompt);
                    input = uint.Parse(Console.ReadLine());

                    if (input < SUBTOTAL)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n FEL! Erhållet belopp {0:c0} är för litet. Köpet kunde inte genomföras \n", input);
                        Console.ResetColor();
                    }
                    return input;
                    
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Du matade in ett för stort tal, var god försök igen \n");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Du matade in ett felaktigt tal, var god försök igen \n");
                    Console.ResetColor();
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Något allvarligt fel inträffade \n");
                }

            } while (true);
        }


        // Kalkylera och skriv ut sedlar tillbaka
        static void SplitIntoDenomiations(double SUBTOTAL, uint TOTAL, uint AMOUNTBACK)
        {

            uint _currency = 0; // Ska hålla reda på antal sedlar och mynt

            if (TOTAL == SUBTOTAL)
            {
                Console.WriteLine("Personen betalade jämna pengar!");
            }

            if (AMOUNTBACK >= 500)
            {
                _currency = AMOUNTBACK / 500;
                AMOUNTBACK %= 500;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 500-lappar", ":", _currency));
            }

            if (AMOUNTBACK >= 100)
            {
                _currency = AMOUNTBACK / 100;
                AMOUNTBACK %= 100;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 100-lappar", ":", _currency));
            }

            if (AMOUNTBACK >= 50)
            {
                _currency = AMOUNTBACK / 50;
                AMOUNTBACK %= 50;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 50-lappar", ":", _currency));
            }

            if (AMOUNTBACK >= 20)
            {
                _currency = AMOUNTBACK / 20;
                AMOUNTBACK %= 20;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 20-lappar", ":", _currency));
            }

            if (AMOUNTBACK >= 10)
            {
                _currency = AMOUNTBACK / 10;
                AMOUNTBACK %= 10;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 10-kronor", ":", _currency));
            }

            if (AMOUNTBACK >= 5)
            {
                _currency = AMOUNTBACK / 5;
                AMOUNTBACK %= 5;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 5-kronor", ":", _currency));
            }

            if (AMOUNTBACK >= 1)
            {
                _currency = AMOUNTBACK / 1;
                AMOUNTBACK %= 1;

                //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                Console.WriteLine(String.Format("{0,-18} {1} {2}", " 1-kronor", ":", _currency));
            }

            Console.WriteLine("\n\n");
        }
    }
}
