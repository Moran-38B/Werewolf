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
        
        // 儲存盜賊的兩張底牌
        public List<string> BottomCards { get; set; } = new();

        public bool HasThief => CurrentSetup.Roles.Any(r => r.Name == "盜賊" && r.Count > 0);

        public void InitializeGame()
        {
            Players.Clear();
            BottomCards.Clear();
            
            // 算出實際座位人數 (總牌數減去底牌)
            int totalCards = CurrentSetup.Roles.Sum(r => r.Count);
            int totalPlayers = HasThief ? totalCards - 2 : totalCards;
            
            for (int i = 1; i <= totalPlayers; i++)
            {
                Players.Add(new Player
                {
                    SeatNumber = i,
                    RoleName = "未知身分",
                    Faction = "未知"
                });
            }

            // 如果有盜賊，初始化兩張底牌的空位
            if (HasThief)
            {
                BottomCards.Add("未知身分");
                BottomCards.Add("未知身分");
            }
        }
    }
}
