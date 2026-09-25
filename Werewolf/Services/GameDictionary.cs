using System.Collections.Generic;
using Werewolf.Models;

namespace Werewolf.Services
{
    public static class GameDictionary
    {
        public static List<RoleItem> GetAllRoles()
        {
            return new List<RoleItem>
            {
                // ===== 好人陣營 =====
                new RoleItem { 
                    Name = "預言家", Faction = "好人",
                    Description = "預言家身為好人陣營的領導者，每晚可以查驗一名玩家所屬陣營，直到死亡。",
                    Advantage = "能迅速釐清雙方陣營，並帶領好人走向勝利。",
                    Disadvantage = "身分容易被頂替，且跳預言家後死亡率會直線上升，又查不出隱狼。"
                },
                new RoleItem { 
                    Name = "女巫", Faction = "好人",
                    Description = "有兩瓶藥，毒藥毒死一人，解藥解救一人。第一晚解藥才能自救，第二晚開始被狼人殺害無法自救。",
                    Advantage = "兩瓶藥都用對人的話，好人直接追兩個回合，勝率也大幅提升。",
                    Disadvantage = "每瓶藥都很關鍵，用錯藥會使局面變得相當不利。"
                },
                new RoleItem { 
                    Name = "獵魔人", Faction = "好人",
                    Description = "第二晚開始可狩獵，目標為狼人則狼人死且下晚可繼續；若為好人則獵魔人死。不受女巫毒藥影響。",
                    Advantage = "選對能迅速殺狼，讓好人瞬間步入優勢，提早結束遊戲。",
                    Disadvantage = "選錯人讓好人瞬間陷入劣勢，進入屠神局勢。"
                },
                // ===== 狼人陣營 =====
                new RoleItem { 
                    Name = "狼美人", Faction = "狼人",
                    Description = "夜間魅惑一名好人陣營玩家，當狼美人死後該玩家隨之殉情，且無法自爆或自刀。",
                    Advantage = "無懼女巫毒藥，獵人開槍，必定帶走一名玩家殉情。",
                    Disadvantage = "技能要能魅惑到神職才能最大化，老流氓和騎士是剋星。"
                },
                new RoleItem { 
                    Name = "惡靈騎士", Faction = "狼人",
                    Description = "無法死在夜裡也無法自刀，擁有一次性反彈技能（彈死預言家、女巫或守衛）。",
                    Advantage = "只能被票死這點相當強悍，只要發言好，獲勝沒煩惱。",
                    Disadvantage = "開完技能才被查驗的話，就只能被投票出局了。"
                },
                // ===== 第三方陣營 =====
                new RoleItem { 
                    Name = "盜賊", Faction = "第三方",
                    Description = "第一晚最先睜眼，從兩張底牌中選一張做為新身分，若有狼人必選狼。",
                    Advantage = "能有更多選牌機會。",
                    Disadvantage = "取決於選擇的牌。"
                },
                // 依照此格式將你提供的其他 20 幾個角色依序補齊...
            };
        }
    }
}
