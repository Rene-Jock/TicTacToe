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
                        StartGame();
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

        static void StartGame()
        {
            Player player1 = new Player();
            Player player2 = new Player();

            Console.Write("Gebe einen Namen für Player 1 ein: ");
            string player_1 = Console.ReadLine();
            player1.Name = player_1;

            Console.Write("{0} Wähle ein Spielersymbol x oder o: ",player_1 );
            char symP1 = Convert.ToChar(Console.ReadLine());

            player1.Symbole = symP1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player erfolgreich erstellt: " + player_1 + " mit dem Symbol: " + symP1);
            Console.ResetColor();

            Console.Write("Gebe einen Namen für Player 2 ein: ");
            string player_2 = Console.ReadLine();
            player2.Name = player_2;
            Console.Write("{0} Wähle ein Spielersymbol x oder o: ", player_2);
            char symP2 = Convert.ToChar(Console.ReadLine());
            player2.Name = player_2;            
            player2.Symbole = symP2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player erfolgreich erstellt: " + player_2 + " mit dem Symbol: " + symP2);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Player 1: " + player_1 + ": " + symP1);
            Console.WriteLine("Player 2: " + player_2 + ": " + symP2);
            Console.ReadKey();
        }

    }
}
