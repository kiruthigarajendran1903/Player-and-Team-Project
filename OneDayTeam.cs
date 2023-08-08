using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Project
{
    public class OneDayTeam : ITeam

    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Successfully Player added to the team.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        public Player GetPlayerById(int playerId)
        {
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerId == playerId)
                {
                    return player;
                }
            }

            return null;
        }

        public Player GetPlayerByName(string playerName)
        {
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase))
                {
                    return player;
                }
            }

            return null;
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = null;

            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerId == playerId)
                {
                    playerToRemove = player;
                    break;
                }
            }

            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("Player successfully removed from the team.");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

    }
}

