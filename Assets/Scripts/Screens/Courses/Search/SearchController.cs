namespace Screens.Courses.Search
{
    public class SearchController : IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchModel _model;
        private readonly SearchComponent _component;
        private readonly ControllerCollection _controllerCollection = new ControllerCollection();

        public SearchController(DirectionsContext context, SearchModel model, SearchComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }

        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
            _component.Clear();
        }

        public void Activate()
        {
            foreach (var tag in _model.GetAll())
            {
                var component = _component.Create();
                var controller = new SearchUnitController(_context, tag, component);
                _controllerCollection.Add(controller);
            }

            _controllerCollection.Activate();
        }
    }
}