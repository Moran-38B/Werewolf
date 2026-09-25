namespace Werewolf.Models
{
    public class RoleItem
    {
        public Role Role { get; set; } = Role.Unknown;
        public string Name { get; set; } = "";
        public string Faction { get; set; } = "";
        public int Count { get; set; } = 0;
        
        // 百科擴充屬性
        public string Description { get; set; } = "";
        public string Advantage { get; set; } = "";
        public string Disadvantage { get; set; } = "";
    }
}
