﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satser
{
    class Program
    {
        static void Main(string[] args)
        {

            /** Övning 1
            Console.Write("Ange ett heltal: ");
            string tal = Console.ReadLine();
            int tal1 = int.Parse(tal); 

            switch (tal1){
                case 1: tal1 = 1; Console.Write("Ett"); break;
                case 2: tal1 = 2; Console.Write("Två"); break;
                case 3: tal1 = 3; Console.Write("Tre"); break;
                case 4: tal1 = 4; Console.Write("Fyra"); break;

            }

            **/
            /** Övning 2
            Console.Write("Skriv väderstreck: ");
            string bokstav = Console.ReadLine();
            char bokstav1 = char.Parse(bokstav);

            switch (bokstav1)
            {
                case 'N': Console.Write("You walk north"); break;
                case 'n': Console.Write("You walk north"); break;
                case 'S': Console.Write("You walk south"); break;
                case 's': Console.Write("You walk south"); break;
                case 'W': Console.Write("You walk west");  break;
                case 'w': Console.Write("You walk west"); break;
                case 'E': Console.Write("You walk east");  break;
                case 'e': Console.Write("You walk east"); break;
            **/
                   
            }
            Console.ReadLine();
        }
    }
}
