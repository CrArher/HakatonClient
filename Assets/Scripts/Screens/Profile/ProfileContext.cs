using Screens.Profile.Categories.Achievements;

namespace Screens.Profile
{
    public class ProfileContext : GlobalContext
    {
        public AchievementsCategoryModel AchievementsCategoryModel { get; set; }

        public ProfileContext(GlobalContext context) : base(context)
        {
            
        }
    }
}