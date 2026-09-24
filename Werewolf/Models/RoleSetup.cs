namespace Werewolf.Models
{
    // 單一角色的設定數量
    public class RoleItem
    {
        public Role Role { get; set; }
        public string Name { get; set; } = "";
        public string Faction { get; set; } = ""; // 陣營分類，例如："神職", "狼人"
        public int Count { get; set; }
    }

    public class RoleSetup
    {
        public string SetupName { get; set; } = "";

        // 記錄該版子所有啟用的角色
        public List<RoleItem> Roles { get; set; } = new();

        // 動態計算總人數
        public int TotalPlayers => Roles.Sum(r => r.Count);

        // 供法官微調時複製一份獨立資料
        public RoleSetup Clone()
        {
            return new RoleSetup
            {
                SetupName = this.SetupName,
                Roles = this.Roles.Select(r => new RoleItem
                {
                    Role = r.Role,
                    Name = r.Name,
                    Faction = r.Faction,
                    Count = r.Count
                }).ToList()
            };
        }
    }
}

