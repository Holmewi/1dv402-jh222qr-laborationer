﻿using System;
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
            double _subtotal;
            uint _total;
            double _roundingOffAmount;
            uint _amountToPay;
            uint _amountBack;

            try
            {
                // Input från användaren
                
                do
                {
                    Console.Write("Ange totalsumma \t: ");
                    _subtotal = double.Parse(Console.ReadLine());   // Acceptera max två decimaler
                    Console.Write("\n");

                    if(_subtotal < 1)
                    {
                        throw new OverflowException();  // Loopen bryts av Exception - FIXA
                    }
                } while (_subtotal < 1);

                Console.Write("Ange erhållet belopp \t: ");
                _total = uint.Parse(Console.ReadLine());


                // Räkna ut öresavrundning
                _amountToPay = (uint)Math.Round(_subtotal);
                _roundingOffAmount = _amountToPay - _subtotal;

                // Räkna ut differens
                _amountBack = _total - _amountToPay;

                // Skriv ut kvittens

                Console.WriteLine("KVITTO\n---------------------------------------");
                Console.WriteLine("Totalt \t\t\t: {0:c}", _subtotal);
                Console.WriteLine("Öresavrundning \t\t: {0:c}", _roundingOffAmount);
                Console.WriteLine("Att betala \t\t: {0:c0}", _amountToPay);
                Console.WriteLine("Kontant \t\t: {0:c0}", _total);
                Console.WriteLine("Tillbaka \t\t: {0:c0}:", _amountBack);
                Console.WriteLine("---------------------------------------\n");

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
                        Console.WriteLine("500-lappar \t: {0}", _currency);

                        _amountBack = _count;   // Finns det något annat sätt att göra detta på?
                    }

                    if (_amountBack >= 100)
                    {
                        _count = _amountBack % 100;
                        _currency = _amountBack / 100;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("100-lappar \t: {0}", _currency);

                        _amountBack = _count;
                    }

                    if (_amountBack >= 50)
                    {
                        _count = _amountBack % 50;
                        _currency = _amountBack / 50;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("50-lappar \t: {0}", _currency);

                        _amountBack = _count;
                    }

                    if (_amountBack >= 20)
                    {
                        _count = _amountBack % 20;
                        _currency = _amountBack / 20;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("20-lappar \t: {0}", _currency);

                        _amountBack = _count;
                    }

                    if (_amountBack >= 10)
                    {
                        _count = _amountBack % 10;
                        _currency = _amountBack / 10;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("10-kronor \t: {0}", _currency);

                        _amountBack = _count;
                    }

                    if (_amountBack >= 5)
                    {
                        _count = _amountBack % 5;
                        _currency = _amountBack / 5;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("5-kronor \t: {0}", _currency);

                        _amountBack = _count;
                    }

                    if (_amountBack >= 1)
                    {
                        _count = _amountBack % 1;
                        _currency = _amountBack / 1;

                        //Console.WriteLine("AmountBack {0}", _amountBack);
                        //Console.WriteLine("Count {0}", _count);
                        Console.WriteLine("1-kronor \t: {0}", _currency);

                        _amountBack = _count;
                    }
                }

                else
                {
                    Console.WriteLine("Personen betalade jämna pengar!");
                }


                Console.WriteLine("\n\n");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Du matade in ett för litet tal \n");
            }

            
            
            // Felmeddelanden

           
        }
    }
}
