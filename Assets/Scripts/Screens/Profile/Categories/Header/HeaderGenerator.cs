using ScreenObserver;

namespace Screens.Profile.Categories.Header
{
    public class HeaderGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            var model = new HeaderModel();
            context.HeaderModel = model;
            var controller = new HeaderController(context,model,container.HeaderComponent);
            collection.Add(controller);
        }
    }
}