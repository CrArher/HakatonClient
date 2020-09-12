using System;
using Screens.AchievementScreen.Base;

namespace Screens.AchievementScreen.AchievementDetailsDialog
{
    public class AchievementDetailsDialogModel
    {
        public event Action OnShow;

        public AchievementUnitModel Achievement;
        
        public void Show(AchievementUnitModel achievement)
        {
            Achievement = achievement;
            OnShow?.Invoke();
        }
    }
}