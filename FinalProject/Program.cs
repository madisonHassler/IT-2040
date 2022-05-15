using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "player_log.csv";
            List<Player> playerList = null;
            while (true)
            {

                try
                {
                    playerList = PlayerLoader.loadPlayers(filePath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(2);
                }


                string choiceEntered = welcomMenu();
                string name = "";

                if (choiceEntered == "1")
                {
                    name = getUserName(playerList);
                    Player player1 = new Player(name, 0, 0, 0);

                    if (name == null)
                    {
                        Console.WriteLine("\nTry again or load previous game.");
                        continue;
                    }

                    startNewGame(playerList, name, player1);
                    gamePlayWinner(player1);
                    string promptMenuChoice = promptMenu();
                    playAgain(promptMenuChoice, playerList, name, player1);

                }
                else if (choiceEntered == "2")
                {
                    var loadedPlayer = loadGame(playerList);
                    if (loadedPlayer == null)
                    {
                        Console.WriteLine("\nName not found please try again.");
                        continue;
                    }
                    name = loadedPlayer.Name;
                    gamePlayWinner(loadedPlayer);
                    string promptMenuChoice = promptMenu();
                    playAgain(promptMenuChoice, playerList, name, loadedPlayer);

                }
                else if (choiceEntered == "3")
                {
                    Environment.Exit(1);
                }
            }

        }



        public static string welcomMenu()
        {
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors!\n\n");
            Console.WriteLine("        1. Start New Game");
            Console.WriteLine("        2. Load Game");
            Console.WriteLine("        3. Quit\n\n");
            string choiceEntered;


            while (true)
            {
                Console.WriteLine("Enter choice (1, 2, or 3): ");
                choiceEntered = Console.ReadLine();
                if (choiceEntered != "1" && choiceEntered != "2" && choiceEntered != "3")
                {
                    Console.WriteLine("\nNot a valid choice, please select one of the following: 1, 2, or 3");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return choiceEntered;
        }

        public static string getUserName(List<Player> playerList)
        {

            Console.WriteLine("\n\nWhat is your name?");
            string name = Console.ReadLine();
            try
            {
                foreach (var player in playerList)
                {
                    if (player.Name == name)
                    {
                        Console.WriteLine($"\n{name} is already in use, please select a different name.");
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{name} Found");

            }
            return name;
        }


        public static string startNewGame(List<Player> playerList, string name, Player player1)
        {
            playerList.Add(player1);
            float round = player1.roundNumber();
            Console.WriteLine($"\n\nHello {name}. Let's play!");
            return name;
        }


        public static Player loadGame(List<Player> playerList)
        {
            Console.WriteLine("\n\nWhat is your name?");
            string userName = Console.ReadLine();
            try
            {
                foreach (var player in playerList)
                {
                    if (player.getName() == userName)
                    {
                        Console.WriteLine($"Welcome back {userName}. Let’s play!");
                        return player;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{userName}, Not Found");
            }

            return null;
        }


        public static string gamePlay(Player player1)
        {
            Console.WriteLine($"\n\nRound {player1.roundNumber()}\n");
            Console.WriteLine($"        1. Rock");
            Console.WriteLine($"        2. Paper");
            Console.WriteLine($"        3. Scissors\n");

            string gameChoice = "";
            while (true)
            {
                Console.WriteLine("What will it be (1, 2, or 3)?");
                gameChoice = Console.ReadLine();
                if (gameChoice != "1" && gameChoice != "2" & gameChoice != "3")
                {
                    Console.WriteLine("\nThat is not a valid choice, pick enter numbers 1, 2, or 3.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return gameChoice;
        }

        public static void gamePlayWinner(Player player1)
        {
            Random random = new Random();
            string computer = "";
            string gameChoice = gamePlay(player1);


            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "1";
                    break;
                case 2:
                    computer = "2";
                    break;
                case 3:
                    computer = "3";
                    break;
            }


            switch (gameChoice)
            {
                case "1":
                    if (computer == "1")
                    {
                        Console.WriteLine("\nYou chose rock. The computer chose rock. You tied!");
                        player1.Tie++;
                    }
                    else if (computer == "2")
                    {
                        Console.WriteLine("\nYou chose rock. The computer chose paper. You lose!");
                        player1.Loss++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou chose rock. The computer chose scissors. You win!");
                        player1.Win++;
                    }
                    break;
                case "2":
                    if (computer == "1")
                    {
                        Console.WriteLine("\nYou chose paper. The computer chose rock. You win!");
                        player1.Win++;
                    }
                    else if (computer == "2")
                    {
                        Console.WriteLine("\nYou chose paper. The computer chose paper. You tied!");
                        player1.Tie++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou chose paper. The computer chose scissors. You lose!");
                        player1.Loss++;
                    }
                    break;
                case "3":
                    if (computer == "1")
                    {
                        Console.WriteLine("\nYou chose scissors. The computer chose rock. You lose!");
                        player1.Loss++;
                    }
                    else if (computer == "2")
                    {
                        Console.WriteLine("\nYou chose scissors. The computer chose paper. You win!");
                        player1.Win++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou chose scissors. The computer chose scissors. You tied!");
                        player1.Tie++;
                    }
                    break;
            }
        }


        public static string promptMenu()
        {
            string promptMenuChoice;
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("        1. Play Again");
            Console.WriteLine("        2. View Player Statistics");
            Console.WriteLine("        3. View Leaderboard");
            Console.WriteLine("        4. Quit");
            Console.WriteLine("Enter choice (1, 2, 3, or 4):");

            while (true)
            {
                promptMenuChoice = Console.ReadLine();
                if (promptMenuChoice != "1" && promptMenuChoice != "2" && promptMenuChoice != "3" && promptMenuChoice != "4")
                {
                    Console.WriteLine("\nEnter a number corresponding to the options above (1, 2, 3 or 4).");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return promptMenuChoice;
        }


        public static string playAgain(string promptMenuChoice, List<Player> playerList, string name, Player player1)
        {
            if (promptMenuChoice == "1")
            {
                gamePlayWinner(player1);
                promptMenuChoice = promptMenu();
                playAgain(promptMenuChoice, playerList, name, player1);
            }
            else if (promptMenuChoice == "2")
            {
                viewStats(playerList, player1, name);
            }
            else if (promptMenuChoice == "3")
            {
                viewLeaderboard(playerList, player1, name);
            }
            else if (promptMenuChoice == "4")
            {
                saveGame(playerList);
                Environment.Exit(1);
            }

            return promptMenuChoice;

        }


        public static void saveGame(List<Player> playerList)
        {
            using (var writer = new StreamWriter("player_log.csv"))
            {
                foreach (var player in playerList)
                {
                    try
                    {
                        writer.WriteLine($"{player.Name},{player.Win},{player.Loss},{player.Tie}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"{player}, the game could not be saved.");
                    }
                }
            }
        }


        public static void viewStats(List<Player> playerList, Player player1, string name)
        {
            Console.WriteLine($"{player1.Name}, here are your game play statistics...");
            Console.WriteLine($"Wins: {player1.Win}");
            Console.WriteLine($"Losses: {player1.Loss}");
            Console.WriteLine($"Ties: {player1.Tie}");
            double winLossRatio = 0;

            try
            {
                winLossRatio = (((double)player1.Win / (double)player1.Loss));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Play more games for a Win/Loss Ratio");

                winLossRatio = 0;
            }
            Console.WriteLine($"Win/Loss Ratio: {winLossRatio: 0.00}");
           
            string promptMenuChoice = promptMenu();
            playAgain(promptMenuChoice, playerList, name, player1);
        }


        public static void viewLeaderboard(List<Player> playerList, Player player1, string name)
        {
            Console.WriteLine("\n\nGlobal Game Statistics");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Top 10 Winning Players");
            Console.WriteLine("----------------------");

            var top10 = (from player in playerList orderby player.Win descending select player).Take(10);
            foreach (var player in top10)
            {
                Console.WriteLine($"{player.Name}: {player.Win} wins");
            }


            Console.WriteLine("\n\n-----------------");
            Console.WriteLine("Most Games Played:");
            Console.WriteLine("-----------------");
            var mostGames = (from player in playerList orderby player.roundNumber() descending select player).Take(5);
            foreach (var played in mostGames)
            {
                Console.WriteLine($"{played.Name}: {played.roundNumber() - 1} games played");
            }

            Console.WriteLine("\n\n-----------------");
            float totWin = 0;
            float totLoss = 0;

            foreach (var total in playerList)
            {
                totWin += total.Win;
                totLoss += total.Loss;
            }
            float overallWinLoss = totWin / totLoss;
            Console.WriteLine($"Overall win/Loss Ratio: {overallWinLoss: 0.00}");
            Console.WriteLine("-----------------");
            Console.WriteLine("\n\n-----------------");



            float totalPlayed = 0;
            foreach (var games in playerList)
            {
                totalPlayed += games.roundNumber() - 1;
            }
            Console.WriteLine($"Total Games Played: {totalPlayed}");
            Console.WriteLine("-----------------\n\n");
            string promptMenuChoice = promptMenu();
            playAgain(promptMenuChoice, playerList, name, player1);
        }
    }
}
