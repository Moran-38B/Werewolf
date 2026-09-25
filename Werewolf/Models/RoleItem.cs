namespace Werewolf.Models
{
    // 定義所有角色的強型別 Enum
    public enum Role
    {
        Unknown,
        Villager, OldHooligan,
        Werewolf, WolfKing, WhiteWolfKing, GhostRider, Gargoyle, WolfBeauty, BloodMoonApostle, HiddenWolf,
        Seer, Witch, Hunter, Guard, Idiot, Bomber, Knight, Silencer, BearTamer, GraveKeeper, DemonHunter, Dreamcatcher, Magician, Crow,
        Cupid, WildChild, Thief
    }

    public class RoleItem
    {
        public Role Role { get; set; } = Role.Unknown; // 加回強型別
        public string Name { get; set; } = "";
        public string Faction { get; set; } = "";
        public int Count { get; set; } = 0;
        
        // 百科擴充屬性
        public string Description { get; set; } = "";
        public string Advantage { get; set; } = "";
        public string Disadvantage { get; set; } = "";
    }
}
