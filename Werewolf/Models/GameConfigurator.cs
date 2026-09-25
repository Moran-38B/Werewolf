using System.Collections.Generic;
using System.Linq; // 必須引用 Linq 才能使用 FirstOrDefault

namespace Werewolf.Models
{
    public static class GameConfigurator
    {
        public static List<RoleItem> GetBaseRoles()
        {
            return new List<RoleItem>
            {
                // 平民陣營
                new RoleItem { Name = "平民", Faction = "平民" },
                new RoleItem { Name = "老流氓", Faction = "平民" },
                
                // 狼人陣營
                new RoleItem { Name = "狼人", Faction = "狼人" },
                new RoleItem { Name = "狼王", Faction = "狼人" },
                new RoleItem { Name = "白狼王", Faction = "狼人" },
                new RoleItem { Name = "惡靈騎士", Faction = "狼人" },
                new RoleItem { Name = "石像鬼", Faction = "狼人" },
                new RoleItem { Name = "狼美人", Faction = "狼人" },
                new RoleItem { Name = "血月使徒", Faction = "狼人" },
                new RoleItem { Name = "隱狼", Faction = "狼人" },
                
                // 神職陣營
                new RoleItem { Name = "預言家", Faction = "神職" },
                new RoleItem { Name = "女巫", Faction = "神職" },
                new RoleItem { Name = "獵人", Faction = "神職" },
                new RoleItem { Name = "守衛", Faction = "神職" },
                new RoleItem { Name = "白癡", Faction = "神職" },
                new RoleItem { Name = "炸彈人", Faction = "神職" },
                new RoleItem { Name = "騎士", Faction = "神職" },
                new RoleItem { Name = "禁言長老", Faction = "神職" },
                new RoleItem { Name = "訓熊師", Faction = "神職" },
                new RoleItem { Name = "守墓人", Faction = "神職" },
                new RoleItem { Name = "獵魔人", Faction = "神職" },
                new RoleItem { Name = "攝夢人", Faction = "神職" },
                new RoleItem { Name = "魔術師", Faction = "神職" },
                new RoleItem { Name = "烏鴉", Faction = "神職" },
                
                // 第三方 / 其他
                new RoleItem { Name = "邱比特", Faction = "第三方" },
                new RoleItem { Name = "野孩子", Faction = "第三方" },
                new RoleItem { Name = "盜賊", Faction = "第三方" }
            };
        }

        // 核心防呆方法：改用字串 Name 來尋找角色，如果找不到就會安全跳過
        private static void SetRoleCount(RoleSetup setup, string roleName, int count)
        {
            var target = setup.Roles.FirstOrDefault(r => r.Name == roleName);
            if (target != null)
            {
                target.Count = count;
            }
        }

        public static List<RoleSetup> GetRecommendations()
        {
            var setups = new List<RoleSetup>();

            var _6_1 = new RoleSetup { SetupName = "6 人 明牌場 - 2狼+2神(預言家+獵人)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_6_1, "狼人", 2);
            SetRoleCount(_6_1, "預言家", 1);
            SetRoleCount(_6_1, "獵人", 1); // 配合標題，將原本的 Guard 改為獵人
            SetRoleCount(_6_1, "平民", 2);
            setups.Add(_6_1);

            var _6_2 = new RoleSetup { SetupName = "6 人 暗牌場 - 2狼+2神(預言家+守衛)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_6_2, "狼人", 2);
            SetRoleCount(_6_2, "預言家", 1);
            SetRoleCount(_6_2, "守衛", 1);
            SetRoleCount(_6_2, "平民", 2);
            setups.Add(_6_2);

            var _7 = new RoleSetup { SetupName = "7 人 生還者 - 1狼+白狼王+預言家+女巫+獵人+守衛+1民", Roles = GetBaseRoles() };
            SetRoleCount(_7, "狼人", 1);
            SetRoleCount(_7, "白狼王", 1);
            SetRoleCount(_7, "預言家", 1);
            SetRoleCount(_7, "女巫", 1);
            SetRoleCount(_7, "獵人", 1);
            SetRoleCount(_7, "守衛", 1);
            SetRoleCount(_7, "平民", 1);
            setups.Add(_7);

            var _8_1 = new RoleSetup { SetupName = "8 人 諸神黃昏 - 狼王+白狼王+惡靈騎士+預言家+女巫+獵人+守衛+白癡", Roles = GetBaseRoles() };
            SetRoleCount(_8_1, "狼人", 1);
            SetRoleCount(_8_1, "白狼王", 1);
            SetRoleCount(_8_1, "惡靈騎士", 1);
            SetRoleCount(_8_1, "預言家", 1);
            SetRoleCount(_8_1, "女巫", 1);
            SetRoleCount(_8_1, "獵人", 1);
            SetRoleCount(_8_1, "守衛", 1);
            SetRoleCount(_8_1, "白癡", 1);
            setups.Add(_8_1);

            var _8_2 = new RoleSetup { SetupName = "8 人 末日狂徒 - 3狼+3神(預言家+守衛+騎士)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_8_2, "狼人", 3);
            SetRoleCount(_8_2, "預言家", 1);
            SetRoleCount(_8_2, "守衛", 1);
            SetRoleCount(_8_2, "騎士", 1);
            SetRoleCount(_8_2, "平民", 2);
            setups.Add(_8_2);

            var _9 = new RoleSetup { SetupName = "9 人 暗牌場 - 3狼+3神(預言家+女巫+獵人)+3民", Roles = GetBaseRoles() };
            SetRoleCount(_9, "狼人", 3);
            SetRoleCount(_9, "預言家", 1);
            SetRoleCount(_9, "女巫", 1);
            SetRoleCount(_9, "獵人", 1);
            SetRoleCount(_9, "平民", 3);
            setups.Add(_9);

            var _10_1 = new RoleSetup { SetupName = "10 人 速推場 - 3狼+3神(預言家+女巫+獵人)+4民/3民+1炸彈人", Roles = GetBaseRoles() };
            SetRoleCount(_10_1, "狼人", 3);
            SetRoleCount(_10_1, "預言家", 1);
            SetRoleCount(_10_1, "女巫", 1);
            SetRoleCount(_10_1, "獵人", 1);
            SetRoleCount(_10_1, "平民", 4);
            SetRoleCount(_10_1, "炸彈人", 1);
            setups.Add(_10_1);

            var _10_2 = new RoleSetup { SetupName = "10 人 假面之夜 - 3狼+3神(預言家+女巫+獵人+守衛+白癡)+神職5選3+4民", Roles = GetBaseRoles() };
            SetRoleCount(_10_2, "狼人", 3);
            SetRoleCount(_10_2, "預言家", 1);
            SetRoleCount(_10_2, "女巫", 1);
            SetRoleCount(_10_2, "獵人", 1);
            SetRoleCount(_10_2, "守衛", 1);
            SetRoleCount(_10_2, "白癡", 1);
            SetRoleCount(_10_2, "平民", 4);
            setups.Add(_10_2);

            var _12_1 = new RoleSetup { SetupName = "12 人 標準場 - 4狼+4神(預言家+女巫+獵人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_1, "狼人", 4);
            SetRoleCount(_12_1, "平民", 4);
            SetRoleCount(_12_1, "預言家", 1);
            SetRoleCount(_12_1, "女巫", 1);
            SetRoleCount(_12_1, "獵人", 1);
            SetRoleCount(_12_1, "白癡", 1);
            setups.Add(_12_1);

            var _12_2 = new RoleSetup { SetupName = "12 人 邱比特場 - 4狼+4神(預言家+女巫+獵人+邱比特)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_2, "狼人", 4);
            SetRoleCount(_12_2, "平民", 4);
            SetRoleCount(_12_2, "預言家", 1);
            SetRoleCount(_12_2, "女巫", 1);
            SetRoleCount(_12_2, "獵人", 1);
            SetRoleCount(_12_2, "邱比特", 1);
            setups.Add(_12_2);

            var _12_3 = new RoleSetup { SetupName = "12 人 禁言長老 - 4狼+4神(預言家+女巫+禁言長老+騎士)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_3, "狼人", 4);
            SetRoleCount(_12_3, "平民", 4);
            SetRoleCount(_12_3, "預言家", 1);
            SetRoleCount(_12_3, "女巫", 1);
            SetRoleCount(_12_3, "騎士", 1);
            SetRoleCount(_12_3, "禁言長老", 1);
            setups.Add(_12_3);

            var _12_4 = new RoleSetup { SetupName = "12 人 炸彈人 - 4狼+4神(預言家+女巫+獵人+炸彈人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_4, "狼人", 4);
            SetRoleCount(_12_4, "平民", 4);
            SetRoleCount(_12_4, "預言家", 1);
            SetRoleCount(_12_4, "女巫", 1);
            SetRoleCount(_12_4, "獵人", 1);
            SetRoleCount(_12_4, "炸彈人", 1);
            setups.Add(_12_4);

            var _12_5 = new RoleSetup { SetupName = "12 人 隱狼+訓熊師 - 3狼+隱狼+4神(訓熊師+女巫+獵人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_5, "狼人", 3);
            SetRoleCount(_12_5, "隱狼", 1);
            SetRoleCount(_12_5, "平民", 4);
            SetRoleCount(_12_5, "訓熊師", 1);
            SetRoleCount(_12_5, "女巫", 1);
            SetRoleCount(_12_5, "獵人", 1);
            SetRoleCount(_12_5, "白癡", 1);
            setups.Add(_12_5);

            var _12_6 = new RoleSetup { SetupName = "12 人 狼王守衛/騎士 - 3狼+狼王+4神(預言家+女巫+獵人+守衛/騎士)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_6, "狼人", 3);
            SetRoleCount(_12_6, "狼王", 1);
            SetRoleCount(_12_6, "平民", 4);
            SetRoleCount(_12_6, "預言家", 1);
            SetRoleCount(_12_6, "女巫", 1);
            SetRoleCount(_12_6, "獵人", 1);
            SetRoleCount(_12_6, "守衛", 1);
            SetRoleCount(_12_6, "騎士", 1);
            setups.Add(_12_6);

            var _12_7 = new RoleSetup { SetupName = "12 人 石像鬼&守墓人 - 3狼+石像鬼+4神(預言家+女巫+獵人+守墓人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_7, "狼人", 3);
            SetRoleCount(_12_7, "石像鬼", 1);
            SetRoleCount(_12_7, "平民", 4);
            SetRoleCount(_12_7, "預言家", 1);
            SetRoleCount(_12_7, "女巫", 1);
            SetRoleCount(_12_7, "獵人", 1);
            SetRoleCount(_12_7, "守墓人", 1);
            setups.Add(_12_7);

            var _12_8 = new RoleSetup { SetupName = "12 人 白狼/狼美人&守衛騎士 + 3狼+白狼王+4神(預言家+女巫+騎士+守衛)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_8, "狼人", 3);
            SetRoleCount(_12_8, "白狼王", 1);
            SetRoleCount(_12_8, "平民", 4);
            SetRoleCount(_12_8, "預言家", 1);
            SetRoleCount(_12_8, "女巫", 1);
            SetRoleCount(_12_8, "守衛", 1);
            SetRoleCount(_12_8, "騎士", 1);
            setups.Add(_12_8);

            var _12_9 = new RoleSetup { SetupName = "12 人 血月使徒&獵魔人 - 3狼+血月使徒+4神(預言家+女巫+獵魔人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_9, "狼人", 3);
            SetRoleCount(_12_9, "血月使徒", 1);
            SetRoleCount(_12_9, "平民", 4);
            SetRoleCount(_12_9, "預言家", 1);
            SetRoleCount(_12_9, "女巫", 1);
            SetRoleCount(_12_9, "獵魔人", 1);
            SetRoleCount(_12_9, "白癡", 1);
            setups.Add(_12_9);

            var _12_10 = new RoleSetup { SetupName = "12 人 狼王&攝夢人 - 3狼+狼王+4神(預言家+女巫+獵人+攝夢人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_10, "狼人", 3);
            SetRoleCount(_12_10, "狼王", 1);
            SetRoleCount(_12_10, "平民", 4);
            SetRoleCount(_12_10, "預言家", 1);
            SetRoleCount(_12_10, "女巫", 1);
            SetRoleCount(_12_10, "攝夢人", 1);
            SetRoleCount(_12_10, "獵人", 1);
            setups.Add(_12_10);

            var _12_11 = new RoleSetup { SetupName = "12 人 隱狼&烏鴉 - 3狼+隱狼+4神(預言家+女巫+獵人+烏鴉)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_11, "狼人", 3);
            SetRoleCount(_12_11, "隱狼", 1);
            SetRoleCount(_12_11, "平民", 4);
            SetRoleCount(_12_11, "預言家", 1);
            SetRoleCount(_12_11, "女巫", 1);
            SetRoleCount(_12_11, "烏鴉", 1);
            SetRoleCount(_12_11, "獵人", 1);
            setups.Add(_12_11);

            var _12_12 = new RoleSetup { SetupName = "12 人 野孩子 - 3狼+野孩子+4神(預言家+女巫+獵人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_12, "狼人", 3);
            SetRoleCount(_12_12, "野孩子", 1);
            SetRoleCount(_12_12, "平民", 4);
            SetRoleCount(_12_12, "預言家", 1);
            SetRoleCount(_12_12, "女巫", 1);
            SetRoleCount(_12_12, "獵人", 1);
            SetRoleCount(_12_12, "白癡", 1);
            setups.Add(_12_12);

            var _12_13 = new RoleSetup { SetupName = "12 人 狼美人&騎士/老流氓 - 3狼+狼美人+4神(預言家+女巫+獵人+騎士/老流氓)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_13, "狼人", 3);
            SetRoleCount(_12_13, "狼美人", 1);
            SetRoleCount(_12_13, "平民", 4);
            SetRoleCount(_12_13, "預言家", 1);
            SetRoleCount(_12_13, "女巫", 1);
            SetRoleCount(_12_13, "獵人", 1);
            SetRoleCount(_12_13, "騎士", 1);
            SetRoleCount(_12_13, "老流氓", 1);
            setups.Add(_12_13);

            var _12_14 = new RoleSetup { SetupName = "12 人 惡靈騎士&守衛 - 3狼+惡靈騎士+4神(預言家+女巫+獵人+守衛)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_14, "狼人", 3);
            SetRoleCount(_12_14, "惡靈騎士", 1);
            SetRoleCount(_12_14, "平民", 4);
            SetRoleCount(_12_14, "預言家", 1);
            SetRoleCount(_12_14, "女巫", 1);
            SetRoleCount(_12_14, "獵人", 1);
            SetRoleCount(_12_14, "守衛", 1);
            setups.Add(_12_14);

            var _12_15 = new RoleSetup { SetupName = "12 人 狼王&邱比特/盜賊 - 2狼+狼王+4神(預言家+女巫+獵人+白癡)+邱比特/盜賊+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_15, "狼人", 2);
            SetRoleCount(_12_15, "狼王", 1);
            SetRoleCount(_12_15, "平民", 4);
            SetRoleCount(_12_15, "預言家", 1);
            SetRoleCount(_12_15, "女巫", 1);
            SetRoleCount(_12_15, "獵人", 1);
            SetRoleCount(_12_15, "白癡", 1);
            SetRoleCount(_12_15, "邱比特", 1);
            SetRoleCount(_12_15, "盜賊", 1);
            setups.Add(_12_15);

            return setups;
        }
    }
}
