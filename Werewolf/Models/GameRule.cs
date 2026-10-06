namespace Werewolf.Models
{
    public class GameRule
    {
        // 勝利條件：屠邊為 true，屠城為 false
        public bool IsKillSide { get; set; } = false;

        // 啟用警長：true 為啟用，false 為禁用
        public bool EnableSheriff { get; set; } = false;

        // 女巫首夜可自救
        public bool WitchCanSaveSelf { get; set; } = true;

        // 同守同救存活：true 為存活，false 為奶穿雙死
        public bool DoubleDeadValid { get; set; } = false;

		// 自動播放語音
		public bool AutoPlayVioce { get; set; } = true;
    }
}
