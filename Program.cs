using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenue();
        }

        static void MainMenue()
        {
            bool end = false;

            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("###################");
                Console.WriteLine("### TIC TAC TOE ###");
                Console.WriteLine("###################");
                Console.ResetColor();

                Console.WriteLine();

                Console.WriteLine("Wähle eine Aktion:");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("[1] Spiel starten");
                Console.WriteLine("[2] Spiel Beenden");
                Console.ResetColor();

                Console.WriteLine();

                Console.Write("Aktion: >>");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //StartGame();
                        break;
                    case 2:
                        end= true;
                        break;


                }
                if (end)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Auf Wiedersehen! Zum Beenden, drücke 'Enter'.");
                    Console.ReadKey();
                    break;
                }

            }

        }

        static void DrawBoard(string[] board)
        {
            Console.WriteLine();
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| " + board[0] + " | " + board[1] + " | " + board[2] + " | ");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| " + board[3] + " | " + board[4] + " | " + board[5] + " | ");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| " + board[6] + " | " + board[7] + " | " + board[8] + " | ");
            Console.WriteLine("+---+---+---+");
        }

    }
}
