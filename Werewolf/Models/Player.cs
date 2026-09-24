namespace Werewolf.Models
{
    public class Player
    {
        //座位編號
        public int SeatNumber { get; set; }
        //真實身分
        public Role Role { get; set; } = Role.Unknown;
        //是否存活
        public bool IsAlive { get; set; } = true;
        //是否有警徽
        public bool HasBadge { get; set; }=false;
        //死亡原因
        public string DeadReason { get; set; } = "";
    }
}
