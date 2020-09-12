using ScreenObserver;

namespace Screens.AchievementScreen.AchievementDetailsDialog
{
    public class AchievementDetailsDialogGenerator : IScreenGenerator<AchievementScreenContext,AchievementScreenContainer>
    {
        public void Generate(AchievementScreenContext context, AchievementScreenContainer container, ControllerCollection collection)
        {
            var model = new AchievementDetailsDialogModel();
            var controller = new AchievementDetailsDialogController(context,model, container.AchievementDetailsDialogComponent);

            context.AchievementDetailsDialogModel = model;
            collection.Add(controller);
        }
    }
}