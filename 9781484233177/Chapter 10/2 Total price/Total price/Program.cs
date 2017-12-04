using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_price
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fixed values
            const double bookPrice = 29.8;
            const double dvdPrice = 9.9;
            const double shipmentPrice = 75;

            // Inputs
            Console.WriteLine("Order");
            Console.WriteLine("-----");

            Console.Write("Product \"C# for beginners (book)\" - enter number of pieces: ");
            string inputBookPieces = Console.ReadLine();
            int bookPieces = Convert.ToInt32(inputBookPieces);

            Console.Write("Product \"All quiet on western front (DVD)\" - enter number of pieces: ");
            string inputDvdPieces = Console.ReadLine();
            int dvdPieces = Convert.ToInt32(inputDvdPieces);

            // Calculations
            double totalForBook = bookPrice * bookPieces;
            double totalForDvd = dvdPrice * dvdPieces;
            double totalForOrder = totalForBook + totalForDvd + shipmentPrice;

            // Outputs
            Console.WriteLine();
            Console.WriteLine("Order calculation");
            Console.WriteLine("-----------------");
            Console.WriteLine("Book: " + totalForBook);
            Console.WriteLine("Dvd: " + totalForDvd);
            Console.WriteLine("Shipment: " + shipmentPrice);
            Console.WriteLine("TOTAL: " + totalForOrder);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
