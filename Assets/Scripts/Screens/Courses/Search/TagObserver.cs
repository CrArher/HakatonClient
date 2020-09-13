namespace Screens.Courses.Search
{
    public class TagObserver : IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchModel _model;
        private ControllerCollection _controllerCollection = new ControllerCollection();


        public TagObserver(DirectionsContext context, SearchModel model)
        {
            _context = context;
            _model = model;
        }

        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
        }

        public void Activate()
        {
            foreach (var unitModel in _model.GetAll())
            {
                _controllerCollection.Add(new TagUnitObserver(_context, _model, unitModel));
            }
            _controllerCollection.Activate();
        }
    }
}