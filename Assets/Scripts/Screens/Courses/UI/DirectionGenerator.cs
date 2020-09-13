using ScreenObserver;

namespace Screens.Courses
{
    public class DirectionGenerator : IScreenGenerator<DirectionsContext,DirectionsContainer>
    {
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            var model = new DirectionModel(context.References.Directions);
            context.DirectionModel = model;
            var controller = new DirectionController(context,model,container.DirectionComponent);
            collection.Add(controller);
        }
    }
}