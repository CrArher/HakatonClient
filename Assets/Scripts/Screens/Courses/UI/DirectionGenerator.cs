using ScreenObserver;

namespace Screens.Courses
{
    public class DirectionGenerator : IScreenGenerator<CoursesContext,CoursesContainer>
    {
        public void Generate(CoursesContext context, CoursesContainer container, ControllerCollection collection)
        {
            var model = new DirectionModel(context.References.Directions);
            context.DirectionModel = model;
            var controller = new DirectionController(context,model,container.DirectionComponent);
            collection.Add(controller);
        }
    }
}