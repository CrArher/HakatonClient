using ScreenObserver;

namespace DefaultNamespace.Screens.Profile.Categories.Achievements
{
    public class AchievementsGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            var model = new AchievementsModel();
            context.AchievementsModel = model;
            var controller = new AchievementsController(context,model,container.AchievementsComponent);
            collection.Add(controller);
        }
    }
}