using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string ch;

            do
            {

                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerId = playerId,
                            PlayerName = playerName,
                            PlayerAge = playerAge
                        };

                        team.Add(newPlayer);
                        break;

                    case 2:
                        Console.WriteLine("Enter Player Id to remove:");
                        int removePlayerId = int.Parse(Console.ReadLine());
                        team.Remove(removePlayerId);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player Id to get details:");
                        int getPlayerId = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(getPlayerId);
                        if (playerById != null)
                        {
                            Console.WriteLine($"Player Details: Id={playerById.PlayerId}, Name={playerById.PlayerName}, Age={playerById.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name to get details:");
                        string getPlayerName = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(getPlayerName);
                        if (playerByName != null)
                        {
                            Console.WriteLine($"Player Details: Id={playerByName.PlayerId}, Name={playerByName.PlayerName}, Age={playerByName.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        Console.WriteLine("All Players:");
                        foreach (Player player in allPlayers)
                        {
                            Console.WriteLine($"Id={player.PlayerId}, Name={player.PlayerName}, Age={player.PlayerAge}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;

                }

                Console.Write("Do You Want To Continue (Yes/No)?:");
                ch = Console.ReadLine();
            }
            while (ch == "Yes" || ch == "yes");
            

            }
    }
}

            
            
    
