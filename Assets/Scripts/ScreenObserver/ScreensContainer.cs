using Screens.AchievementScreen;
using Screens.BattlePass;
using Screens.Courses;
using Screens.Profile;
using UnityEngine;

namespace ScreenObserver
{
    public class ScreensContainer : MonoBehaviour
    {
        public ProfileContainer ProfileContainer;
        public AchievementScreenContainer AchievementScreenContainer;
        public DirectionsContainer directionsContainer;
        public BattlePassContainer BattlePassContainer;
    }
}