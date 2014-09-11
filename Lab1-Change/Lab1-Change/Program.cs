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
            double _subtotal = 0d;
            uint _total = 0;
            double _roundingOffAmount;
            uint _amountToPay;
            uint _amountBack;
            bool _error = true;


            
                // Input från användaren

                do
                {
                    try
                    {
                        Console.Write("Ange totalsumma \t: ");
                        _subtotal = double.Parse(Console.ReadLine());   // Acceptera max två decimaler
                        _error = false;

                        if (_subtotal < 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n FEL! {0} är ett för litet tal, var god försök igen \n", _subtotal);
                            Console.ResetColor();
                            _error = true;
                        }
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
                } while (_error);
                    


         
                do
                {
	                try
	                {
                        _error = true;
	                    Console.Write("Ange erhållet belopp \t: ");
	                    _total = uint.Parse(Console.ReadLine());
                        _error = false;
                        if (_total < _subtotal)
			                {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n FEL! Erhållet belopp {0:c0} är för litet. Köpet kunde inte genomföras \n", _total);
                                Console.ResetColor();
                                _error = true;
			                }
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

                } while (_error);


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

                // Kalkylera och skriv ut sedlar tillbaka

                uint _count = 0;    // Ska hålla reda på summan
                uint _currency = 0; // Ska hålla reda på antal sedlar och mynt

                if (_amountBack >= 1)
                {
                    if (_amountBack >= 500)
                    {
                        _count = _amountBack % 500;
                        _currency = _amountBack / 500;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 500-lappar", ":", _currency));

                        _amountBack = _count;   // Finns det något annat sätt att göra detta på?
                    }

                    if (_amountBack >= 100)
                    {
                        _count = _amountBack % 100;
                        _currency = _amountBack / 100;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 100-lappar", ":", _currency));

                        _amountBack = _count;
                    }

                    if (_amountBack >= 50)
                    {
                        _count = _amountBack % 50;
                        _currency = _amountBack / 50;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 50-lappar", ":", _currency));

                        _amountBack = _count;
                    }

                    if (_amountBack >= 20)
                    {
                        _count = _amountBack % 20;
                        _currency = _amountBack / 20;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 20-lappar", ":", _currency));

                        _amountBack = _count;
                    }

                    if (_amountBack >= 10)
                    {
                        _count = _amountBack % 10;
                        _currency = _amountBack / 10;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 10-kronor", ":", _currency));

                        _amountBack = _count;
                    }

                    if (_amountBack >= 5)
                    {
                        _count = _amountBack % 5;
                        _currency = _amountBack / 5;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 5-kronor", ":", _currency));

                        _amountBack = _count;
                    }

                    if (_amountBack >= 1)
                    {
                        _count = _amountBack % 1;
                        _currency = _amountBack / 1;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine(String.Format("{0,-18} {1} {2}", " 1-kronor", ":", _currency));

                        _amountBack = _count;
                    }
                }

                else
                {
                    Console.WriteLine("Personen betalade jämna pengar!");
                }


                Console.WriteLine("\n\n");
 
        }
    }
}
