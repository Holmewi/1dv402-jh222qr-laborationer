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

            //Hämta värden från varsin separat metod
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
                        double _input;
                        Console.Write(prompt);
                        _input = double.Parse(Console.ReadLine());   // Acceptera max två decimaler?

                        if (_input < 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n FEL! {0} är ett för litet tal, var god försök igen \n", _input);
                            Console.ResetColor();
                        }
                        else if(_input >= 1)
                        {
                            return _input;
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
                } while (true);
        }

        // Input från användaren - erhållet belopp
        public static uint ReadUint(string prompt, double SUBTOTAL)
        {
            do
            {
                try
                {
                    uint _input;
                    Console.Write(prompt);
                    _input = uint.Parse(Console.ReadLine());

                    if (_input < SUBTOTAL)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n FEL! Erhållet belopp {0:c0} är för litet. Köpet kunde inte genomföras \n", _input);
                        Console.ResetColor();
                    }
                    if (_input == SUBTOTAL)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n Personen betalade jämna pengar! ");
                        Console.ResetColor();
                        return _input;
                    }

                    else if (_input >= SUBTOTAL)
                    {
                        return _input;
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

            } while (true);
        }


        // Kalkylera och skriv ut sedlar och mynt tillbaka
        static void SplitIntoDenomiations(double SUBTOTAL, uint TOTAL, uint AMOUNTBACK)
        {

            uint _currencyCount = 0; // Ska hålla reda på antal sedlar och mynt

            string[] _textLine = new string[7];
            _textLine[0] = " 500-lappar";
            _textLine[1] = " 100-lappar";
            _textLine[2] = " 50-lappar";
            _textLine[3] = " 20-lappar";
            _textLine[4] = " 10-kronor";
            _textLine[5] = " 5-kronor";
            _textLine[6] = " 1-kronor";

            uint[] _currency = new uint[] { 500, 100, 50, 20, 10, 5, 1 };

            int i;
            for (i = 0; i < _currency.Length; i++)
            {
                if (AMOUNTBACK >= _currency[i])
                {
                    _currencyCount = AMOUNTBACK / _currency[i];
                    AMOUNTBACK %= _currency[i];

                    //Console.WriteLine("AmountBack {0}", AMOUNTBACK);
                    Console.WriteLine(String.Format("{0,11} {1,8} {2}", _textLine[i], ":", _currencyCount)); 
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
