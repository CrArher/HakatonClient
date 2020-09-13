using ScreenObserver;

namespace Screens.Courses.ShowMore
{
    public class ShowMoreGenerator : IScreenGenerator<DirectionsContext,DirectionsContainer>
    {
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            var model = new ShowMoreModel();
            context.ShowMoreModel = model;
            var controller = new ShowMoreController(context,model,container.ShowMoreComponent);
            collection.Add(controller);
        }
    }
}