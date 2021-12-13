using System;
using System.Collections.Generic;

namespace TH_Week13_ArielCristoHaryono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };

            while (true)
            {
                Console.WriteLine("\n1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll");
                Console.WriteLine("Choose what to do");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    Console.WriteLine("\n1. Book of Peace \n2. Scroll of Swords \n3. Silence Guide Book");
                }

                else if (pilihan == 2)
                {
                    Console.WriteLine("Insert scroll name");
                    var insert = Console.ReadLine();
                }
                else if (pilihan == 3)
                {
                    Console.WriteLine("Search scroll");
                    var search = Console.ReadLine();
                }
                else if (pilihan == 4)
                {
                    Console.WriteLine("Remove from list ?");
                    var remove = Console.ReadLine();
                    Console.WriteLine("Book Removed !");
                }
            }
        }
    }
}

