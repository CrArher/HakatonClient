using ScreenObserver;

namespace Screens.Courses.Search
{
    public class SearchGenerator : IScreenGenerator<DirectionsContext,DirectionsContainer>
    {
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            var model = new SearchModel();
            var controller = new SearchController(context,model,container.SearchComponent);
            var observer = new TagObserver(context, model);
            
            context.SearchModel = model;
            collection.Add(controller);
            collection.Add(observer);
        }
    }
}