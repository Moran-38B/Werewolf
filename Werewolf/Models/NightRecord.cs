namespace Werewolf.Models
{
    public class NightRecord
    {
        public int Day { get; set; } = 1;

        // ==========================================
        // 1. 狼人陣營行動紀錄
        // ==========================================

        /// <summary> 狼人擊殺目標 </summary>
        public int? WolfKillTarget { get; set; }

        /// <summary> 狼美人魅惑目標 </summary>
        public int? WolfBeautyCharmTarget { get; set; }

        /// <summary> 石像鬼查驗目標 </summary>
        public int? GargoyleCheckTarget { get; set; }


        // ==========================================
        // 2. 神職陣營行動紀錄
        // ==========================================

        /// <summary> 預言家查驗目標 </summary>
        public int? SeerCheckTarget { get; set; }

        /// <summary> 女巫是否使用解藥 </summary>
        public bool IsHealUsed { get; set; } = false;

        /// <summary> 女巫使用毒藥的目標 </summary>
        public int? WitchPoisonTarget { get; set; }

        /// <summary> 守衛守護目標 </summary>
        public int? GuardTarget { get; set; }

        /// <summary> 攝夢人攝夢目標 </summary>
        public int? DreamcatcherTarget { get; set; }

        /// <summary> 獵魔人狩獵目標 </summary>
        public int? DemonHunterTarget { get; set; }

        /// <summary> 禁言長老禁言目標 </summary>
        public int? SilencerTarget { get; set; }

        /// <summary> 烏鴉詛咒（誹謗）目標 </summary>
        public int? CrowCurseTarget { get; set; }

        /// <summary> 魔術師交換目標 A </summary>
        public int? MagicianSwapTargetA { get; set; }

        /// <summary> 魔術師交換目標 B </summary>
        public int? MagicianSwapTargetB { get; set; }


        // ==========================================
        // 3. 第三方 / 首夜特殊行動紀錄
        // ==========================================

        /// <summary> 邱比特連結的情侶 A </summary>
        public int? CupidLoverA { get; set; }

        /// <summary> 邱比特連結的情侶 B </summary>
        public int? CupidLoverB { get; set; }

        /// <summary> 野孩子選擇的榜樣 (認父) </summary>
        public int? WildChildModel { get; set; }

        /// <summary> 盜賊換牌後最終選擇的職業 (記錄用) </summary>
        public Role? ThiefFinalRole { get; set; }
    }

    // ==========================================
    // 夜晚喚醒順序 (GamePhase)
    // ==========================================
    public enum GamePhase
    {
        // 首夜專屬階段
        ThiefTurn,          // 盜賊請睜眼
        CupidTurn,          // 邱比特請睜眼
        LoversTurn,         // 情侶請睜眼 (確認彼此)
        WildChildTurn,      // 野孩子請睜眼

        // 每晚常規階段 (標準喚醒順序)
        DreamcatcherTurn,   // 攝夢人請睜眼 (通常在狼人之前)
        GuardTurn,          // 守衛請睜眼
        WerewolfTurn,       // 狼人請睜眼
        WolfBeautyTurn,     // 狼美人請睜眼
        GargoyleTurn,       // 石像鬼請睜眼
        WitchTurn,          // 女巫請睜眼
        SeerTurn,           // 預言家請睜眼
        DemonHunterTurn,    // 獵魔人請睜眼
        MagicianTurn,       // 魔術師請睜眼
        SilencerTurn,       // 禁言長老請睜眼
        CrowTurn,           // 烏鴉請睜眼

        // 夜晚結束
        DayTime             // 天亮了
    }
}