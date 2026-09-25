using System.Collections.Generic;

namespace Werewolf.Models
{
    // 遊戲規則設定 (獨立存在)
    public class GameRule
    {
        public bool IsKillSide { get; set; } = true; // true = 屠邊, false = 屠城
        public bool WitchCanSaveSelf { get; set; } = false; // 女巫首夜能否自救
        public bool DoubleDeadValid { get; set; } = false; // 同守同救是否存活
    }

    // 單一角色項目 (剛剛不小心遺失的類別)
    public class RoleItem
    {
        public Role Role { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Faction { get; set; } = string.Empty;
        public int Count { get; set; } = 0;
    }

    // 角色配置 (不再包含 Rule)
    public class RoleSetup
    {
        public string SetupName { get; set; } = "自訂配置";
        public List<RoleItem> Roles { get; set; } = new();
    }
}
