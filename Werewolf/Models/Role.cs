namespace Werewolf.Models
{
    public enum Role
    {
        Unknown,
        // --- 平民陣營 ---
        Villager,           // 平民
        OldHooligan,        // 老流氓

        // --- 狼人陣營 ---
        Werewolf,           // 狼人
        WolfKing,           // 狼王
        WhiteWolfKing,      // 白狼王
		SnowWolf			// 雪狼
    	GhostRider,        	// 惡靈騎士
        Gargoyle,           // 石像鬼
        WolfBeauty,         // 狼美人
        BloodMoonApostle,   // 血月使徒
        HiddenWolf,         // 隱狼

        // --- 神職陣營 ---
        Seer,               // 預言家
        Witch,              // 女巫
        Hunter,             // 獵人
        Guard,              // 守衛
        Idiot,              // 白癡
        Knight,             // 騎士
        Silencer,           // 禁言長老
        BearTamer,          // 訓熊師
        GraveKeeper,        // 守墓人
        DemonHunter,        // 獵魔人
        Dreamcatcher,       // 攝夢人
        Magician,           // 魔術師
        Crow,               // 烏鴉

        // --- 第三方 / 特殊陣營 ---
        Cupid,              // 邱比特
        WildChild,          // 野孩子
        Thief,              // 盜賊
        Bomber              // 炸彈人
    }
}
