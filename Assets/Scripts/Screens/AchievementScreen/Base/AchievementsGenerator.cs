using DefaultNamespace;

namespace Screens.AchievementScreen.Base
{
    public class AchievementsGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {

            var model = new AchievementsModel(context.References.Achievements);
            context.AchievementsModel = model;
        }
    }
}