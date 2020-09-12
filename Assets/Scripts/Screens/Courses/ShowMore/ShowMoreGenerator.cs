using ScreenObserver;

namespace Screens.Courses.ShowMore
{
    public class ShowMoreGenerator : IScreenGenerator<CoursesContext,CoursesContainer>
    {
        public void Generate(CoursesContext context, CoursesContainer container, ControllerCollection collection)
        {
            var model = new ShowMoreModel();
            context.ShowMoreModel = model;
            var controller = new ShowMoreController(context,model,container.ShowMoreComponent);
            collection.Add(controller);
        }
    }
}