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

        // 隱狼與其他狼人一同睜眼

        // True: 晚上與狼人一同睜眼，但被騎士選擇為決鬥對象時一樣會死
        // False: 晚上不跟狼人睜眼，好處是不受騎士技能影響
        public bool HiddenWolfMode { get; set; } = false;
        // HiddenWolfMode == false
        // True: 若場上僅剩隱狼一名狼人時，則狼人失敗
        // False: 場上所有狼隊友均被淘汰後，隱狼可開始殺人，但同時也會被預言家查驗出來
        public bool HiddenWolfMode_ { get; set; } = false;

		// 自動播放語音
		public bool AutoPlayVioce { get; set; } = true;
    }
}
