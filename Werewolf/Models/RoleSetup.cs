using System.Collections.Generic;

namespace Werewolf.Models
{
    public class RoleSetup
    {
        public string SetupName { get; set; } = "";
        public List<RoleItem> Roles { get; set; } = new();
    }
}
