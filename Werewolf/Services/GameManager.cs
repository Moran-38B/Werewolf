using System.Collections.Generic;
using System.Linq;
using Werewolf.Models;

namespace Werewolf.Services
{
    public class GameManager
    {
        public GameRule GlobalRule { get; set; } = new();
        public RoleSetup CurrentSetup { get; set; } = new();
        
        public List<Player> Players { get; set; } = new();

        // 產生給法官登記的空座位
        public void InitializeGame()
        {
            Players.Clear();
            
            // 算出首頁設定的總人數
            int totalPlayers = CurrentSetup.Roles.Sum(r => r.Count);
            
            for (int i = 1; i <= totalPlayers; i++)
            {
                Players.Add(new Player
                {
                    SeatNumber = i,
                    RoleName = "未知身分",
                    Faction = "未知"
                });
            }
        }
    }
}
