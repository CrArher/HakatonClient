using DefaultNamespace.Screens.Profile.Categories.Achievements;
using DefaultNamespace.Screens.Profile.Categories.Activity;
using DefaultNamespace.Screens.Profile.Categories.Header;
using DefaultNamespace.Screens.Profile.Categories.Info;

namespace DefaultNamespace.Screens.Profile
{
    public class ProfileContext : GlobalContext
    {
        public AchievementsModel AchievementsModel { get; set; }
        public ActivityModel ActivityModel { get; set; }
        public HeaderModel HeaderModel { get; set; }
        public InfoModel InfoModel { get; set; }
    }
}