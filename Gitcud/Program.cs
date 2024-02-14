using System;
using System.Security.Cryptography.X509Certificates;

namespace Gitcud;

internal class Program
{
    static void Main(string[] args)
    {

        List<Game> games = new List<Game>();
        games.Add(new Game("Couner Strike", "FEJF", 2014));
        games.Add(new Game("Call of Duty", "GNJBJ", 2000));
        while (true)
        {
            Console.WriteLine("1. peržiūrėti žaidimus ");
            Console.WriteLine("2. pridėti žaidimą");
            Console.WriteLine("3. redaguoti žaidimą");
            Console.WriteLine("4. ištrinti žaidimą");
            Console.WriteLine("5. išeiti iš programos");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {

                case 1:
                    foreach (var game in games)
                    {
                        Console.WriteLine(game);
                    }
                    break;
                //  public  static void AddGame
                case 2:
                    Console.WriteLine("Pridedu žaidimą");
                    Game g = new Game();
                    Console.WriteLine("Įveskite pavadinimą");
                    g.Title = Console.ReadLine();
                    Console.WriteLine("Įveskite žaidimo tipą ");
                    g.Type = Console.ReadLine();
                    Console.WriteLine("Įveskite žaidimo išleidimo metus");
                    g.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                    games.Add(g);
                    break;

                case 3:
                    // Console.WriteLine("Redaguoju žaidimą");
                    Console.WriteLine("Įveskite žaidimo id, kurį norite redaguoti");
                    int idEdit = Convert.ToInt32(Console.ReadLine());
                    foreach (var game in games)
                    {
                        if (game.Id == idEdit)
                        {
                            Console.WriteLine($"Įveskite pavadinimą. dabartinis {game.Title}");
                            game.Title = Console.ReadLine();
                            Console.WriteLine("Įveskite žaidimo tipą ");
                            game.Type = Console.ReadLine();
                            Console.WriteLine("Įveskite žaidimo išleidimo metus");
                            game.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                            break;
                        }

                    }
                    break;
                case 4:
                    //Console.WriteLine("Ištrinu žaidimą");
                    Console.WriteLine("Įveskite žaidimo id, kurį norite ištrinti");
                    int idDelete = Convert.ToInt32(Console.ReadLine());
                    string title = "";
                    foreach (var game in games)
                    {
                        if (game.Id == idDelete)
                        {
                            title = game.Title;
                            games.Remove(game);
                            break;
                        }
                    }
                    Console.WriteLine($"Zaidimas \"{title}\" buvo sekmingai istrintas");
                    break;
                case 5:
                    Console.WriteLine("Išeinu iš programos");

                    Environment.Exit(0);
                    break;
            }//switch

        }//while


    }//main method


}//class


