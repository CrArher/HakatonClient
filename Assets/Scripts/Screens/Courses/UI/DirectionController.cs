using System.Collections.Generic;

namespace Screens.Courses
{
    public class DirectionController : IController
    {
        private readonly DirectionsContext _context;
        private readonly DirectionModel _model;
        private readonly DirectionComponent _component;
        ControllerCollection _controllerCollection = new ControllerCollection();

        public DirectionController(DirectionsContext context, DirectionModel model, DirectionComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }

        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _component.Clear();
            _controllerCollection.Clear();
        }

        public void Activate()
        {
            foreach (var unitModel in _model.UnitModels)
            {
                ShowDirection(unitModel);
            }
        }

        public void ShowDirection(DirectionUnitModel unitModel)
        {
            var component = _component.CreateComponent();
            var controller = new DirectionUnitController(_context, unitModel, component);
            controller.Activate();
            _controllerCollection.Add(controller);
        }
    }
}