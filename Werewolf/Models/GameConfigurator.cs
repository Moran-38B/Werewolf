namespace Werewolf.Models
{
    public class GameConfigurator
    {
        public static List<RoleItem> GetBaseRoles()
        {
            return new List<RoleItem>
            {
                // 平民陣營
                new RoleItem { Role = Role.Villager, Name = "平民", Faction = "平民" },
                new RoleItem { Role = Role.OldHooligan, Name = "老流氓", Faction = "平民" },
                
                // 狼人陣營
                new RoleItem { Role = Role.Werewolf, Name = "狼人", Faction = "狼人" },
                new RoleItem { Role = Role.WolfKing, Name = "狼王", Faction = "狼人" },
                new RoleItem { Role = Role.WhiteWolfKing, Name = "白狼王", Faction = "狼人" },
                new RoleItem { Role = Role.GhostRider, Name = "惡靈騎士", Faction = "狼人" },
                new RoleItem { Role = Role.Gargoyle, Name = "石像鬼", Faction = "狼人" },
                new RoleItem { Role = Role.WolfBeauty, Name = "狼美人", Faction = "狼人" },
                new RoleItem { Role = Role.BloodMoonApostle, Name = "血月使徒", Faction = "狼人" },
                new RoleItem { Role = Role.HiddenWolf, Name = "隱狼", Faction = "狼人" },
                
                // 神職陣營
                new RoleItem { Role = Role.Seer, Name = "預言家", Faction = "神職" },
                new RoleItem { Role = Role.Witch, Name = "女巫", Faction = "神職" },
                new RoleItem { Role = Role.Hunter, Name = "獵人", Faction = "神職" },
                new RoleItem { Role = Role.Guard, Name = "守衛", Faction = "神職" },
                new RoleItem { Role = Role.Idiot, Name = "白癡", Faction = "神職" },
                new RoleItem { Role = Role.Bomber, Name = "炸彈人", Faction = "神職" },
                new RoleItem { Role = Role.Knight, Name = "騎士", Faction = "神職" },
                new RoleItem { Role = Role.Silencer, Name = "禁言長老", Faction = "神職" },
                new RoleItem { Role = Role.BearTamer, Name = "訓熊師", Faction = "神職" },
                new RoleItem { Role = Role.GraveKeeper, Name = "守墓人", Faction = "神職" },
                new RoleItem { Role = Role.DemonHunter, Name = "獵魔人", Faction = "神職" },
                new RoleItem { Role = Role.Dreamcatcher, Name = "攝夢人", Faction = "神職" },
                new RoleItem { Role = Role.Magician, Name = "魔術師", Faction = "神職" },
                new RoleItem { Role = Role.Crow, Name = "烏鴉", Faction = "神職" },
                
                // 第三方 / 其他
                new RoleItem { Role = Role.Cupid, Name = "邱比特", Faction = "第三方" },
                new RoleItem { Role = Role.WildChild, Name = "野孩子", Faction = "第三方" },
                new RoleItem { Role = Role.Thief, Name = "盜賊", Faction = "第三方" }
            };
        }

        // 核心防呆方法：如果找不到該角色，就會安全跳過，不會引發 NullReferenceException
        private static void SetRoleCount(RoleSetup setup, Role role, int count)
        {
            var target = setup.Roles.FirstOrDefault(r => r.Role == role);
            if (target != null)
            {
                target.Count = count;
            }
        }

        public static List<RoleSetup> GetRecommendations()
        {
            var setups = new List<RoleSetup>();

            var _6_1 = new RoleSetup { SetupName = "6 人 明牌場 - 2狼+2神(預言家+獵人)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_6_1, Role.Werewolf, 2);
            SetRoleCount(_6_1, Role.Seer, 1);
            SetRoleCount(_6_1, Role.Guard, 1);
            SetRoleCount(_6_1, Role.Villager, 2);
            setups.Add(_6_1);

            var _6_2 = new RoleSetup { SetupName = "6 人 暗牌場 - 2狼+2神(預言家+守衛)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_6_2, Role.Werewolf, 2);
            SetRoleCount(_6_2, Role.Seer, 1);
            SetRoleCount(_6_2, Role.Guard, 1);
            SetRoleCount(_6_2, Role.Villager, 2);
            setups.Add(_6_2);

            var _7 = new RoleSetup { SetupName = "7 人 生還者 - 1狼+白狼王+預言家+女巫+獵人+守衛+1民", Roles = GetBaseRoles() };
            SetRoleCount(_7, Role.Werewolf, 1);
            SetRoleCount(_7, Role.WhiteWolfKing, 1);
            SetRoleCount(_7, Role.Seer, 1);
            SetRoleCount(_7, Role.Witch, 1);
            SetRoleCount(_7, Role.Hunter, 1);
            SetRoleCount(_7, Role.Guard, 1);
            SetRoleCount(_7, Role.Villager, 1);
            setups.Add(_7);

            var _8_1 = new RoleSetup { SetupName = "8 人 諸神黃昏 - 狼王+白狼王+惡魔騎士+預言家+女巫+獵人+守衛+白痴", Roles = GetBaseRoles() };
            SetRoleCount(_8_1, Role.Werewolf, 1);
            SetRoleCount(_8_1, Role.WhiteWolfKing, 1);
            SetRoleCount(_8_1, Role.GhostRider, 1);
            SetRoleCount(_8_1, Role.Seer, 1);
            SetRoleCount(_8_1, Role.Witch, 1);
            SetRoleCount(_8_1, Role.Hunter, 1);
            SetRoleCount(_8_1, Role.Guard, 1);
            SetRoleCount(_8_1, Role.Idiot, 1);
            setups.Add(_8_1);

            var _8_2 = new RoleSetup { SetupName = "8 人 末日狂徒 - 3狼+3神(預言家+守衛+騎士)+2民", Roles = GetBaseRoles() };
            SetRoleCount(_8_2, Role.Werewolf, 3);
            SetRoleCount(_8_2, Role.Seer, 1);
            SetRoleCount(_8_2, Role.Guard, 1);
            SetRoleCount(_8_2, Role.Knight, 1);
            SetRoleCount(_8_2, Role.Villager, 2);
            setups.Add(_8_2);

            var _9 = new RoleSetup { SetupName = "9 人 暗牌場 - 3狼+3神(預言家+女巫+獵人)+3民", Roles = GetBaseRoles() };
            SetRoleCount(_9, Role.Werewolf, 3);
            SetRoleCount(_9, Role.Seer, 1);
            SetRoleCount(_9, Role.Witch, 1);
            SetRoleCount(_9, Role.Hunter, 1);
            SetRoleCount(_9, Role.Villager, 3);
            setups.Add(_9);

            var _10_1 = new RoleSetup { SetupName = "10 人 速推場 - 3狼+3神(預言家+女巫+獵人)+4民/3民+1炸彈人", Roles = GetBaseRoles() };
            SetRoleCount(_10_1, Role.Werewolf, 3);
            SetRoleCount(_10_1, Role.Seer, 1);
            SetRoleCount(_10_1, Role.Witch, 1);
            SetRoleCount(_10_1, Role.Hunter, 1);
            SetRoleCount(_10_1, Role.Villager, 4);
            SetRoleCount(_10_1, Role.Bomber, 1);
            setups.Add(_10_1);

            var _10_2 = new RoleSetup { SetupName = "10 人 假面之夜 - 3狼+3神(預言家+女巫+獵人+守衛+白癡)+神職5選3+4民", Roles = GetBaseRoles() };
            SetRoleCount(_10_2, Role.Werewolf, 3);
            SetRoleCount(_10_2, Role.Seer, 1);
            SetRoleCount(_10_2, Role.Witch, 1);
            SetRoleCount(_10_2, Role.Hunter, 1);
            SetRoleCount(_10_2, Role.Guard, 1);
            SetRoleCount(_10_2, Role.Idiot, 1);
            SetRoleCount(_10_2, Role.Villager, 4);
            setups.Add(_10_2);

            var _12_1 = new RoleSetup { SetupName = "12 人 標準場 - 4狼+4神(預言家+女巫+獵人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_1, Role.Werewolf, 4);
            SetRoleCount(_12_1, Role.Villager, 4);
            SetRoleCount(_12_1, Role.Seer, 1);
            SetRoleCount(_12_1, Role.Witch, 1);
            SetRoleCount(_12_1, Role.Hunter, 1);
            SetRoleCount(_12_1, Role.Idiot, 1);
            setups.Add(_12_1);

            var _12_2 = new RoleSetup { SetupName = "12 人 邱比特場 - 4狼+4神(預言家+女巫+獵人+邱比特)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_2, Role.Werewolf, 4);
            SetRoleCount(_12_2, Role.Villager, 4);
            SetRoleCount(_12_2, Role.Seer, 1);
            SetRoleCount(_12_2, Role.Witch, 1);
            SetRoleCount(_12_2, Role.Hunter, 1);
            SetRoleCount(_12_2, Role.Cupid, 1);
            setups.Add(_12_2);

            var _12_3 = new RoleSetup { SetupName = "12 人 禁言長老 - 4狼+4神(預言家+女巫+禁言長老+騎士)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_3, Role.Werewolf, 4);
            SetRoleCount(_12_3, Role.Villager, 4);
            SetRoleCount(_12_3, Role.Seer, 1);
            SetRoleCount(_12_3, Role.Witch, 1);
            SetRoleCount(_12_3, Role.Knight, 1);
            SetRoleCount(_12_3, Role.Silencer, 1);
            setups.Add(_12_3);

            var _12_4 = new RoleSetup { SetupName = "12 人 炸彈人 - 4狼+4神(預言家+女巫+獵人+炸彈人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_4, Role.Werewolf, 4);
            SetRoleCount(_12_4, Role.Villager, 4);
            SetRoleCount(_12_4, Role.Seer, 1);
            SetRoleCount(_12_4, Role.Witch, 1);
            SetRoleCount(_12_4, Role.Hunter, 1);
            SetRoleCount(_12_4, Role.Bomber, 1);
            setups.Add(_12_4);

            var _12_5 = new RoleSetup { SetupName = "12 人 隱狼+訓熊師 - 3狼+隱狼+4神(訓熊師+女巫+獵人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_5, Role.Werewolf, 3);
            SetRoleCount(_12_5, Role.HiddenWolf, 1);
            SetRoleCount(_12_5, Role.Villager, 4);
            SetRoleCount(_12_5, Role.BearTamer, 1);
            SetRoleCount(_12_5, Role.Witch, 1);
            SetRoleCount(_12_5, Role.Hunter, 1);
            SetRoleCount(_12_5, Role.Idiot, 1);
            setups.Add(_12_5);

            var _12_6 = new RoleSetup { SetupName = "12 人 狼王守衛/騎士 - 3狼+狼王+4神(預言家+女巫+獵人+守衛/騎士)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_6, Role.Werewolf, 3);
            SetRoleCount(_12_6, Role.WolfKing, 1);
            SetRoleCount(_12_6, Role.Villager, 4);
            SetRoleCount(_12_6, Role.Seer, 1);
            SetRoleCount(_12_6, Role.Witch, 1);
            SetRoleCount(_12_6, Role.Hunter, 1);
            SetRoleCount(_12_6, Role.Guard, 1);
            SetRoleCount(_12_6, Role.Knight, 1);
            setups.Add(_12_6);

            var _12_7 = new RoleSetup { SetupName = "12 人 石像鬼&守墓人 - 3狼+石像鬼+4神(預言家+女巫+獵人+守墓人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_7, Role.Werewolf, 3);
            SetRoleCount(_12_7, Role.Gargoyle, 1);
            SetRoleCount(_12_7, Role.Villager, 4);
            SetRoleCount(_12_7, Role.Seer, 1);
            SetRoleCount(_12_7, Role.Witch, 1);
            SetRoleCount(_12_7, Role.Hunter, 1);
            SetRoleCount(_12_7, Role.GraveKeeper, 1);
            setups.Add(_12_7);

            var _12_8 = new RoleSetup { SetupName = "12 人 白狼/狼美人&守衛騎士 + 3狼+白狼王+4神(預言家+女巫+騎士+守衛)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_8, Role.Werewolf, 3);
            SetRoleCount(_12_8, Role.WhiteWolfKing, 1);
            SetRoleCount(_12_8, Role.Villager, 4);
            SetRoleCount(_12_8, Role.Seer, 1);
            SetRoleCount(_12_8, Role.Witch, 1);
            SetRoleCount(_12_8, Role.Guard, 1);
            SetRoleCount(_12_8, Role.Knight, 1);
            setups.Add(_12_8);

            var _12_9 = new RoleSetup { SetupName = "12 人 血月使徒&獵魔人 - 3狼+血月使徒+4神(預言家+女巫+獵魔人+白癡)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_9, Role.Werewolf, 3);
            SetRoleCount(_12_9, Role.BloodMoonApostle, 1);
            SetRoleCount(_12_9, Role.Villager, 4);
            SetRoleCount(_12_9, Role.Seer, 1);
            SetRoleCount(_12_9, Role.Witch, 1);
            SetRoleCount(_12_9, Role.DemonHunter, 1);
            SetRoleCount(_12_9, Role.Idiot, 1);
            setups.Add(_12_9);

            var _12_10 = new RoleSetup { SetupName = "12 人 狼王&攝夢人 - 3狼+狼王+4神(預言家+女巫+獵人+攝夢人)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_10, Role.Werewolf, 3);
            SetRoleCount(_12_10, Role.WolfKing, 1);
            SetRoleCount(_12_10, Role.Villager, 4);
            SetRoleCount(_12_10, Role.Seer, 1);
            SetRoleCount(_12_10, Role.Witch, 1);
            SetRoleCount(_12_10, Role.Dreamcatcher, 1);
            SetRoleCount(_12_10, Role.Hunter, 1);
            setups.Add(_12_10);

            var _12_11 = new RoleSetup { SetupName = "12 人 隱狼&烏鴉 - 3狼+隱狼+4神(預言家+女巫+獵人+烏鴉)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_11, Role.Werewolf, 3);
            SetRoleCount(_12_11, Role.HiddenWolf, 1);
            SetRoleCount(_12_11, Role.Villager, 4);
            SetRoleCount(_12_11, Role.Seer, 1);
            SetRoleCount(_12_11, Role.Witch, 1);
            SetRoleCount(_12_11, Role.Crow, 1);
            SetRoleCount(_12_11, Role.Hunter, 1);
            setups.Add(_12_11);

            var _12_12 = new RoleSetup { SetupName = "12 人 野孩子 - 3狼+野孩子+4神(預言家+女巫+獵人+白痴)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_12, Role.Werewolf, 3);
            SetRoleCount(_12_12, Role.WildChild, 1);
            SetRoleCount(_12_12, Role.Villager, 4);
            SetRoleCount(_12_12, Role.Seer, 1);
            SetRoleCount(_12_12, Role.Witch, 1);
            SetRoleCount(_12_12, Role.Hunter, 1);
            SetRoleCount(_12_12, Role.Idiot, 1);
            setups.Add(_12_12);

            var _12_13 = new RoleSetup { SetupName = "12 人 狼美人&騎士/老流氓 - 3狼+狼美人+4神(預言家+女巫+獵人+騎士/老流氓)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_13, Role.Werewolf, 3);
            SetRoleCount(_12_13, Role.WolfBeauty, 1);
            SetRoleCount(_12_13, Role.Villager, 4);
            SetRoleCount(_12_13, Role.Seer, 1);
            SetRoleCount(_12_13, Role.Witch, 1);
            SetRoleCount(_12_13, Role.Hunter, 1);
            SetRoleCount(_12_13, Role.Knight, 1);
            SetRoleCount(_12_13, Role.OldHooligan, 1);
            setups.Add(_12_13);

            var _12_14 = new RoleSetup { SetupName = "12 人 惡靈騎士&守衛 - 3狼+惡靈騎士+4神(預言家+女巫+獵人+守衛)+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_14, Role.Werewolf, 3);
            SetRoleCount(_12_14, Role.GhostRider, 1);
            SetRoleCount(_12_14, Role.Villager, 4);
            SetRoleCount(_12_14, Role.Seer, 1);
            SetRoleCount(_12_14, Role.Witch, 1);
            SetRoleCount(_12_14, Role.Hunter, 1);
            SetRoleCount(_12_14, Role.Guard, 1);
            setups.Add(_12_14);

            var _12_15 = new RoleSetup { SetupName = "12 人 狼王&邱比特/盜賊 - 2狼+狼王+4神(預言家+女巫+獵人+白痴)+邱比特/盜賊+4民", Roles = GetBaseRoles() };
            SetRoleCount(_12_15, Role.Werewolf, 2);
            SetRoleCount(_12_15, Role.WolfKing, 1);
            SetRoleCount(_12_15, Role.Villager, 4);
            SetRoleCount(_12_15, Role.Seer, 1);
            SetRoleCount(_12_15, Role.Witch, 1);
            SetRoleCount(_12_15, Role.Hunter, 1);
            SetRoleCount(_12_15, Role.Idiot, 1);
            SetRoleCount(_12_15, Role.Cupid, 1);
            SetRoleCount(_12_15, Role.Thief, 1);
            setups.Add(_12_15);

            return setups;
        }
    }
}
