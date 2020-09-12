using ScreenObserver;

namespace DefaultNamespace.Screens.Profile.Categories.Info
{
    public class InfoGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            var model = new InfoModel();
            context.InfoModel = model;
            var controller = new InfoController(context,model,container.InfoComponent);
        }
    }
}