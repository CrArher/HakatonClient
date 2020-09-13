using ScreenObserver;
using Screens.Profile.Categories.Achievements;
using UnityEngine;
using UnityEngine.UI;

namespace Screens.Profile
{
    public class ProfileContainer : MonoBehaviour,ISceneContainer
    {
        public AchievementsCategoryComponent achievementsCategoryComponent;
        public Button JavaClick;
        public Button ArClick;
    }
}