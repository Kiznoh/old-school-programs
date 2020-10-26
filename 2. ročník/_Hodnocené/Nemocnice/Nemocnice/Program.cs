using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nemocnice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double teplota = double.Parse(Question("Zadej teplotu:"));
                Console.ResetColor();
                if (!Console.NumberLock)
                {
                    Console.WriteLine("Proč nepužíváš numerickou klávesnici? Ty ji snad nemáš??");
                }
                else
                {

                    if (teplota <= 34)
	                {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
		                Console.WriteLine("Pacient je asi v mrazáku");
	                }
                    else if (teplota < 37)
                    {
                        Console.WriteLine("Pacient je zdravý");
                    }
                    else if (teplota <= 38)
                    {
                        Console.WriteLine("Pacient má zvýšenou teplotu");
                    }
                    else if (teplota <= 42)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Pacient je nemocný");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Pacient si dal teploměr do ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("horkého čaje");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" nebo v něm probíhá jaderná fůze.");
                        
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\n\nMěl jsi tam zadat číslo!\n\n");
            }
            Console.ReadLine();
        }
        static string Question(string question)
        {
            Console.Write(question + " ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            return Console.ReadLine();
        }
    }
}
