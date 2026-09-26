using System.Collections.Generic;

namespace Werewolf.Models
{
    public static class GameDictionary
    {
        public static List<RoleItem> GetAllRoles()
        {
            return new List<RoleItem>
            {
                new RoleItem { Role = Role.Seer, Name = "預言家", Faction = "好人", Description = "每晚可以查驗一名玩家所屬陣營，直到死亡。", Advantage = "能迅速釐清雙方陣營，並帶領好人走向勝利。", Disadvantage = "身分容易被頂替，且跳預言家後死亡率會直線上升，又查不出隱狼。" },
                new RoleItem { Role = Role.Witch, Name = "女巫", Faction = "好人", Description = "有兩瓶藥，一瓶毒藥，一瓶解藥，不能同時使用。第一晚解藥才能自救，第二晚無法自救。", Advantage = "兩瓶藥都用對人的話，好人直接追兩個回合，毒藥可以直接封技能。", Disadvantage = "用錯藥會使局面變得相當不利。" },
                new RoleItem { Role = Role.Hunter, Name = "獵人", Faction = "好人", Description = "死亡時能開槍殺死一名玩家，被毒死或殉情則無法開槍。", Advantage = "死後帶對人能追一回合。", Disadvantage = "視野跟平民一樣，使用技能前得考慮清楚。" },
                new RoleItem { Role = Role.Guard, Name = "守衛", Faction = "好人", Description = "每晚指定一名玩家無法被狼人殺害，不能連續兩晚守同一人。若與女巫解藥同時使用則該玩家死亡。", Advantage = "可以幫忙擋刀，提高遊戲勝率。", Disadvantage = "狼人可能因此刀其他人，是一場心理戰。" },
                new RoleItem { Role = Role.Knight, Name = "騎士", Faction = "好人", Description = "白天任何時候翻牌查驗指定玩家，若為狼人立即出局並進入夜晚。若為好人，則騎士出局。一局限用一次。", Advantage = "迅速幫好人看清局勢，戳破狼人謊言。", Disadvantage = "撞錯人會使狼更容易辨別神職。" },
                new RoleItem { Role = Role.DemonHunter, Name = "獵魔人", Faction = "好人", Description = "第二個晚上開始狩獵，若目標為狼人則狼人死，若為好人則獵魔人死。不受毒藥影響。", Advantage = "選對能迅速殺狼，提早結束遊戲。", Disadvantage = "選錯人讓好人瞬間陷入劣勢。" },
                new RoleItem { Role = Role.Magician, Name = "魔術師", Faction = "好人", Description = "每晚可選擇兩個人互換，包括自己。每人整場只能被交換一次。", Advantage = "交換到狼坑，可使狼人殺到自己人。", Disadvantage = "對局勢不清容易造成整場混亂。" },
                new RoleItem { Role = Role.GraveKeeper, Name = "守墓人", Faction = "好人", Description = "每天晚上能得知前一天被投票放逐的人屬於好人陣營或是狼人陣營。", Advantage = "得知被放逐的人身分有助於驗證說詞。", Disadvantage = "身分容易被跳，跳身分後也容易死。" },
                new RoleItem { Role = Role.BearTamer, Name = "訓熊師", Faction = "好人", Description = "白天法官確認熊旁邊兩人是不是為狼人，有一隻以上會宣布熊咆哮。", Advantage = "做為代替預言家的角色，能縮小狼坑。", Disadvantage = "若有熊叫，不好分辨左右哪邊是狼。" },
                new RoleItem { Role = Role.Idiot, Name = "白痴", Faction = "好人", Description = "被投票出局後翻牌不會死，但失去投票權。", Advantage = "白天說話分量大，不用怕被票走。", Disadvantage = "並無強力技能。" },
                new RoleItem { Role = Role.Silencer, Name = "禁言長老", Faction = "好人", Description = "每天晚上指定一名玩家隔天無法發言，不得連續禁言同一人。", Advantage = "讓懷疑的目標難以辯解。", Disadvantage = "並無強力技能。" },
                new RoleItem { Role = Role.Dreamcatcher, Name = "攝夢人", Faction = "好人", Description = "每晚選擇一名夢遊者，免疫夜間傷害。若攝夢人死亡，夢遊者一同死亡，連睡兩晚也死亡。", Advantage = "操作多樣，能保人也能殺狼。", Disadvantage = "得看清局勢，否則連同被保人一同死亡。" },
                new RoleItem { Role = Role.Crow, Name = "烏鴉", Faction = "好人", Description = "每晚詛咒一人，該玩家隔天投票環節票數＋１，不得連續詛咒同一人。", Advantage = "能靠票數影響白天投票對象。", Disadvantage = "技能並不強勢。" },
                new RoleItem { Role = Role.OldHooligan, Name = "老流氓", Faction = "平民", Description = "不會被魅惑。被灑毒或射殺後進入狀態，當天不死，隔天發言完才死。", Advantage = "能給好人自證身分。", Disadvantage = "幾乎等同平民。" },
                new RoleItem { Role = Role.Bomber, Name = "炸彈人", Faction = "好人", Description = "白天被票出局時炸死所有投他的玩家，夜間被刀可帶走隨機一狼。", Advantage = "沒人敢投票給你，狼人不想刀你。", Disadvantage = "場上幾乎全軍覆沒時狼人易趁虛而入。" },
                new RoleItem { Role = Role.Villager, Name = "平民", Faction = "平民", Description = "無功能，天亮後必須分辨敵我並用投票跟隨神職人員走向勝利。", Advantage = "不會有什麼出錯，人數眾多。", Disadvantage = "無視野，容易成為扛推對象。" },
                new RoleItem { Role = Role.Werewolf, Name = "狼人", Faction = "狼人", Description = "白天隱藏身分，每個晚上可以決定殺害一人。", Advantage = "晚上能享受處決的快感。", Disadvantage = "無其他技能。" },
                new RoleItem { Role = Role.SnowWolf, Name = "雪狼", Faction = "狼人", Description = "參與處決，無法被預言家查驗，但騎士技能有效。", Advantage = "預言家查不到。", Disadvantage = "剋星是騎士。" },
                new RoleItem { Role = Role.WolfKing, Name = "狼王", Faction = "狼人", Description = "死後發動技能開槍殺死一名玩家，被毒死或自爆則無法開槍。", Advantage = "死後能帶走一人。", Disadvantage = "明顯狼樣會被女巫悶槍。" },
                new RoleItem { Role = Role.WhiteWolfKing, Name = "白狼王", Faction = "狼人", Description = "白天發言環節任一時候自爆並帶走一名玩家。", Advantage = "直接自爆帶走神職，不給發言。", Disadvantage = "一定要自爆。" },
                new RoleItem { Role = Role.WolfBeauty, Name = "狼美人", Faction = "狼人", Description = "單獨魅惑一名好人，狼美人死後該玩家隨之殉情，無法自爆或自刀。", Advantage = "無懼毒藥與開槍，必定帶走一人。", Disadvantage = "老流氓和騎士是剋星。" },
                new RoleItem { Role = Role.GhostRider, Name = "惡靈騎士", Faction = "狼人", Description = "無法死在夜裡，擁有一次性反彈技能（預言家查驗死亡、女巫撒毒死亡）。", Advantage = "只能被票死這點相當強悍。", Disadvantage = "開完技能才被查驗就只能被票出局。" },
                new RoleItem { Role = Role.HiddenWolf, Name = "隱狼", Faction = "狼人", Description = "晚上不跟狼人睜眼，不受騎士、訓熊師技能影響。", Advantage = "可以完全把自己當做平民，沒有破綻。", Disadvantage = "不認識狼同伴。" },
                new RoleItem { Role = Role.Gargoyle, Name = "石像鬼", Faction = "狼人", Description = "每天晚上能查驗一人真實身分，當場上只剩石像鬼時才能殺人。", Advantage = "查驗真實身分屬於超強技能。", Disadvantage = "難以告知狼隊友查驗身分。" },
                new RoleItem { Role = Role.BloodMoonApostle, Name = "血月使徒", Faction = "狼人", Description = "自爆馬上進入天黑並封鎖神職技能。若為最後一名被投票的狼人，可攤牌活到隔天。", Advantage = "封鎖技能，拖延時間。", Disadvantage = "自爆效益高但體驗差。" },
                new RoleItem { Role = Role.Cupid, Name = "邱比特", Faction = "第三方", Description = "第一晚選擇兩名玩家成為情侶，勝利條件與情侶相同。", Advantage = "自選連結，非常有娛樂性質。", Disadvantage = "不知道連到玩家的身分。" },
                new RoleItem { Role = Role.Thief, Name = "盜賊", Faction = "第三方", Description = "第一晚最先睜眼，選擇兩張身分牌其中一張做為新身分。", Advantage = "能有更多選牌機會。", Disadvantage = "取決於選擇的牌。" },
                new RoleItem { Role = Role.WildChild, Name = "野孩子", Faction = "第三方", Description = "第一晚選擇榜樣，榜樣死亡則變成狼人，否則永遠是好人。", Advantage = "可扛推榜樣跳進狼群獲勝。", Disadvantage = "榜樣的生死難以控制。" }
            };
        }
    }
}
