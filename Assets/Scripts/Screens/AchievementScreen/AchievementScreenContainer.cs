using ScreenObserver;
using Screens.AchievementScreen.AchievementDetailsDialog;
using Screens.AchievementScreen.Base;
using UnityEngine;

namespace Screens.AchievementScreen
{
    public class AchievementScreenContainer : MonoBehaviour, ISceneContainer
    {
        public AchievementComponent AchievementComponent;
        public AchievementDetailsDialogComponent AchievementDetailsDialogComponent;
    }
}