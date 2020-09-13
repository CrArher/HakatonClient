using ScreenObserver;

namespace Screens.Profile.Categories.Achievements
{
    public class AchievementsCategoryGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            var model = new AchievementsCategoryModel();
            context.AchievementsCategoryModel = model;
            var controller = new AchievementsCategoryController(context,model,container);
            collection.Add(controller);
        }
    }
}