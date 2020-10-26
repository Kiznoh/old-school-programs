using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obdélník
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    Console.WriteLine("\nZadáváš data do pravoúhlého rovnoběžníku");
                    double a = double.Parse(Question("Zadej A:"));
                    double b = double.Parse(Question("Zadej B:"));
                    bool repeat = true;
                    while (repeat)
                    {
                        char key = QuestionChar("Chceš znát Obvod nebo obSah (s/o):");
                        key = Char.ToLower(key);
                        Console.WriteLine(key);
                        switch (key)
                        {
                            case 's':
                                repeat = false;
                                Console.WriteLine("Obsah tohoto pravoúhlého rovnoběžníku je: {0}", a * b);
                                break;
                            case 'o':
                                repeat = false;
                                Console.WriteLine("Obvod tohoto pravoúhlého rovnoběžníku je: {0}", 2 * (a + b));
                                break;
                            default:
                                break;
                        }
                    }

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Měl jsi tam zadat číslo!");
                    Console.ResetColor();
                }
            }
        }
        static string Question(string question)
        {
            Console.Write(question + " ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            question = Console.ReadLine();
            Console.ResetColor();
            return question;
        }
        static char QuestionChar(string question)
        {
            Console.Write(question + " ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            char key = Console.ReadKey().KeyChar;
            Console.ResetColor();
            return key;
        }
    }
}
