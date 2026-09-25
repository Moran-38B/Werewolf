namespace Werewolf.Models
{
    public class GameRule
    {
        // 勝利條件：屠邊為 true，屠城為 false
        public bool IsKillSide { get; set; } = true;

        // 女巫首夜可自救
        public bool WitchCanSaveSelf { get; set; } = false;

        // 同守同救存活：true 為存活，false 為奶穿雙死
        public bool DoubleDeadValid { get; set; } = false;
    }
}
