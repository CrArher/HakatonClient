using ScreenObserver;

namespace Screens.AchievementScreen.Base
{
    public class AchievementsScreenGenerator : IScreenGenerator<AchievementScreenContext, AchievementScreenContainer>
    {
        public void Generate(AchievementScreenContext context, AchievementScreenContainer container, ControllerCollection collection)
        {
            var controller = new AchievementController(context, container.AchievementComponent, context.AchievementsModel);
            collection.Add(controller);
        }
    }
}