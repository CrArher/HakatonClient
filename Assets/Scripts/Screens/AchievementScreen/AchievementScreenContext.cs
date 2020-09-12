using Screens.AchievementScreen.AchievementDetailsDialog;

namespace Screens.AchievementScreen
{
    public class AchievementScreenContext : GlobalContext
    {
        public AchievementDetailsDialogModel AchievementDetailsDialogModel { get; set; }
        
        public AchievementScreenContext(GlobalContext context) : base(context)
        {
            
        }
    }
}