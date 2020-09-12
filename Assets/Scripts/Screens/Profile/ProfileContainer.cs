using DefaultNamespace.Screens.Profile.Categories.Achievements;
using DefaultNamespace.Screens.Profile.Categories.Activity;
using DefaultNamespace.Screens.Profile.Categories.Header;
using DefaultNamespace.Screens.Profile.Categories.Info;
using ScreenObserver;

namespace DefaultNamespace.Screens.Profile
{
    public class ProfileContainer : ISceneContainer
    {
        public AchievementsComponent AchievementsComponent;
        public ActivityComponent ActivityComponent;
        public HeaderComponent HeaderComponent;
        public InfoComponent InfoComponent;
    }
}