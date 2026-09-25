using Werewolf.Models;

namespace Werewolf.Services
{
    public class GameManager
    {
        // 儲存當局的遊戲規則 (屠城/屠邊等)
        public GameRule GlobalRule { get; set; } = new();

        // 儲存當局的角色配置名單
        public RoleSetup CurrentSetup { get; set; } = new();
        
        // 之後還可以在這裡擴充：遊戲當前天數、存活玩家列表等全域狀態
    }
}
