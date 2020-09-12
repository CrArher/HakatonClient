using ScreenObserver;
using Screens.Profile.Categories.Achievements;
using Screens.Profile.Categories.Activity;
using Screens.Profile.Categories.Header;
using Screens.Profile.Categories.Info;
using UnityEngine;

namespace Screens.Profile
{
    public class ProfileContainer : MonoBehaviour,ISceneContainer
    {
        public AchievementsCategoryComponent achievementsCategoryComponent;
        public ActivityComponent ActivityComponent;
        public HeaderComponent HeaderComponent;
        public InfoComponent InfoComponent;
    }
}