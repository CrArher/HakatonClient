namespace Screens.Courses.Search
{
    public class SearchController : IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchModel _model;
        private readonly SearchComponent _component;
        private ControllerCollection _controllerCollection = new ControllerCollection();

        public SearchController(DirectionsContext context,SearchModel model,SearchComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
        }

        public void Activate()
        {
            foreach (var tag in _component.Tags)
            {
                var controller = new TagController(_context,_model,tag);
                controller.Activate();
                _controllerCollection.Add(controller);
            }
        }
    }
}