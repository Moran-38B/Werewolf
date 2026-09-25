using System.Collections.Generic;

namespace Werewolf.Models
{
    // 遊戲規則設定
    public class GameRule
    {
        public bool IsKillSide { get; set; } = true; // true = 屠邊, false = 屠城
        public bool WitchCanSaveSelf { get; set; } = false; // 女巫首夜能否自救
        public bool DoubleDeadValid { get; set; } = false; // 同守同救是否存活
    }

    // 角色配置
    public class RoleSetup
    {
        public string SetupName { get; set; } = "自訂配置";
        public List<RoleItem> Roles { get; set; } = new();
        public GameRule Rule { get; set; } = new(); // 綁定規則
    }
}
