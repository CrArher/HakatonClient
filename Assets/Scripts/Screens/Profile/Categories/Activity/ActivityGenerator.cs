using ScreenObserver;

namespace Screens.Profile.Categories.Activity
{
    public class ActivityGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            var model = new ActivityModel();
            context.ActivityModel = model;
            var controller = new ActivityController(context,model,container.ActivityComponent);
            collection.Add(controller);
        }
    }
}