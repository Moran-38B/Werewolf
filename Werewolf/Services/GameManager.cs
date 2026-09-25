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
        
        // 底牌改存 Role Enum
        public List<Role> BottomCards { get; set; } = new();

        // 判斷盜賊 (改用 Enum)
        public bool HasThief => CurrentSetup.Roles.Any(r => r.Role == Role.Thief && r.Count > 0);

        public void InitializeGame()
        {
            Players.Clear();
            BottomCards.Clear();
            
            int totalCards = CurrentSetup.Roles.Sum(r => r.Count);
            int totalPlayers = HasThief ? totalCards - 2 : totalCards;
            
            for (int i = 1; i <= totalPlayers; i++)
            {
                Players.Add(new Player
                {
                    SeatNumber = i,
                    Role = Role.Unknown,
                    RoleName = "未知身分",
                    Faction = "未知"
                });
            }

            if (HasThief)
            {
                BottomCards.Add(Role.Unknown);
                BottomCards.Add(Role.Unknown);
            }
        }
    }
}
