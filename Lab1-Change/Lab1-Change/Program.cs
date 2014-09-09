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
            double _subtotal;
            // uint _amount;
            uint _total;
            double _roundingOffAmount;
            uint _amountToPay;
            uint _amountBack;
            

            // Input från användaren
            Console.Write("Ange totalsumma \t: ");
            _subtotal = double.Parse(Console.ReadLine());
            Console.Write("Ange erhållet belopp \t: ");
            _total = uint.Parse(Console.ReadLine());


            // Räkna ut öresavrundning
            _amountToPay = (uint)Math.Round(_subtotal);
            _roundingOffAmount = _amountToPay - _subtotal;

            // Räkna ut differens
            _amountBack = _total - _amountToPay;

            // Skriv ut kvittens
       
            Console.WriteLine("\nKVITTO\n---------------------------------------");
            Console.WriteLine("Totalt \t\t\t: {0:c}", _subtotal);
            Console.WriteLine("Öresavrundning \t\t: {0:c}", _roundingOffAmount);
            Console.WriteLine("Att betala \t\t: {0:c0}", _amountToPay);
            Console.WriteLine("Kontant \t\t: {0:c0}", _total);
            Console.WriteLine("Tillbaka \t\t: {0:c0}:", _amountBack);
            Console.WriteLine("---------------------------------------\n");

            // Räkna ut sedlar tillbaka


            // Skriv ut sedlar tillbaka


            // Felmeddelanden        
        }
    }
}
