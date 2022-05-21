﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    class MultGame
    {
        public void Play2()
        {
            Ctverec hrac3 = new Ctverec(4, 4, ConsoleColor.Green);
            Ctverec hrac4 = new Ctverec(5, 10, ConsoleColor.Red);

            while (true)
            {
                hrac3.Vykreslit();
                hrac4.Vykreslit();

                ConsoleKeyInfo myKey3 = Console.ReadKey();
                Console.Clear();
                if (myKey3.Key == ConsoleKey.RightArrow)
                {
                    hrac3.Pohybdoprava();
                }
                if (myKey3.Key == ConsoleKey.LeftArrow)
                {
                    hrac3.Pohybdoleva();
                }
                if (myKey3.Key == ConsoleKey.DownArrow)
                {
                    hrac3.Pohybdolu();
                }
                if (myKey3.Key == ConsoleKey.UpArrow)
                {
                    hrac3.Pohybnahoru();
                }

                ConsoleKeyInfo myKey4 = Console.ReadKey();
                Console.Clear();
                if (myKey4.Key == ConsoleKey.W)
                {
                    hrac4.Pohybnahoru();
                }
                if (myKey4.Key == ConsoleKey.S)
                {
                    hrac4.Pohybdolu();
                }
                if (myKey4.Key == ConsoleKey.A)
                {
                    hrac4.Pohybdoleva();
                }
                if (myKey4.Key == ConsoleKey.D)
                {
                    hrac4.Pohybdoprava();
                }

                ConsoleKeyInfo myKey5 = Console.ReadKey();
                Console.Clear();
                if (myKey5.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu mojeMenu = new Menu();
                    mojeMenu.Run();
                }
            }
        }
    }    
}
