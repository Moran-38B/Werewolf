namespace Werewolf.Models
{
    public class Player
    {
        // 座位編號
        public int SeatNumber { get; set; }
        
        // 為了與首頁動態配置連動，改為儲存角色名稱與陣營
        public string RoleName { get; set; } = "未知身分";
        public string Faction { get; set; } = "未知";
        
        // 是否存活
        public bool IsAlive { get; set; } = true;
        
        // 是否有警徽
        public bool HasBadge { get; set; } = false;
        
        // 死亡原因
        public string DeadReason { get; set; } = "";
    }
}