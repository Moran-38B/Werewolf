namespace Werewolf.Models
{
    public class Player
    {
        public int SeatNumber { get; set; }
        
        // 核心判斷使用 Enum
        public Role Role { get; set; } = Role.Unknown;
        
        // 畫面顯示使用中文字串
        public string RoleName { get; set; } = "未知身分";
        public string Faction { get; set; } = "未知";
        
        public bool IsAlive { get; set; } = true;
        public bool HasBadge { get; set; } = false;
        public string DeadReason { get; set; } = "";
    }
}
