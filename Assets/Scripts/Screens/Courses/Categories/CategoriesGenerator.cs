using ScreenObserver;

namespace Screens.Courses.Categories
{
    public class CategoriesGenerator : IScreenGenerator<DirectionsContext,DirectionsContainer>
    {
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            var controller = new CategoriesController(context,container.CategoriesComponent);
            collection.Add(controller);
        }
    }
}