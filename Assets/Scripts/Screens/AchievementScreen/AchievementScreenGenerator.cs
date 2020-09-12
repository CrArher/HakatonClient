using System.Collections.Generic;
using ScreenObserver;
using Screens.AchievementScreen.AchievementDetailsDialog;
using Screens.AchievementScreen.Base;

namespace Screens.AchievementScreen
{
    public class AchievementScreenGenerator: IScreenGenerator<AchievementScreenContext,AchievementScreenContainer>
    {
        private readonly List<IScreenGenerator<AchievementScreenContext,AchievementScreenContainer>> _generators = new List<IScreenGenerator<AchievementScreenContext,AchievementScreenContainer>>();

        public AchievementScreenGenerator()
        {
            _generators.Add(new AchievementDetailsDialogGenerator());
            _generators.Add(new AchievementsScreenGenerator());
        }
        
        public void Generate(AchievementScreenContext context, AchievementScreenContainer container, ControllerCollection collection)
        {
            foreach (var generator in _generators)
            {
                generator.Generate(context, container, collection);
            }
        }
    }
}