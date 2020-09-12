namespace Screens.Courses
{
    public class DirectionController : IController
    {
        private readonly CoursesContext _context;
        private readonly DirectionModel _model;
        private readonly DirectionComponent _component;
        ControllerCollection _controllerCollection = new ControllerCollection();

        public DirectionController(CoursesContext context,DirectionModel model,DirectionComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _model.UnitModels.Clear();
            _component.Clear();
            _controllerCollection.Clear();
        }

        public void Activate()
        {
            foreach (var unitModel in _model.UnitModels)
            {
                var component = _component.CreateComponent();
                var controller = new DirectionUnitController(_context,unitModel,component);
                controller.Activate();
                _controllerCollection.Add(controller);
            }
        }
    }
}