using Screens.Profile.Categories.Achievements;
using Screens.Profile.Categories.Activity;
using Screens.Profile.Categories.Header;
using Screens.Profile.Categories.Info;

namespace Screens.Profile
{
    public class ProfileContext : GlobalContext
    {
        public AchievementsCategoryModel AchievementsCategoryModel { get; set; }
        public ActivityModel ActivityModel { get; set; }
        public HeaderModel HeaderModel { get; set; }
        public InfoModel InfoModel { get; set; }

        public ProfileContext(GlobalContext context) : base(context)
        {
            
        }
    }
}