using ScreenObserver;

namespace Screens.Courses.Search
{
    public class SearchGenerator : IScreenGenerator<DirectionsContext,DirectionsContainer>
    {
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            var model = new SearchModel();
            context.SearchModel = model;
            var controller = new SearchController(context,model,container.SearchComponent);
            collection.Add(controller);
        }
    }
}