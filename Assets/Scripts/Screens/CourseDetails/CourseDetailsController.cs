using ScreenManager;

namespace Screens.CourseDetails
{
    public class CourseDetailsController : IController
    {
        private readonly CourseDetailsContext _context;
        private readonly CourseDetailsModel _model;
        private readonly CourseDetailsComponent _component;
        private readonly ControllerCollection _controllerCollection = new ControllerCollection();

        public CourseDetailsController(CourseDetailsContext context, CourseDetailsModel model, CourseDetailsComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }

        public void Deactivate()
        {
            _component.Close.onClick.RemoveListener(ClickClose);
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
            _component.Clear();
        }

        public void Activate()
        {
            _component.Count.text = $"{_model.Count}";
            _component.Count2.text = $"{_model.Count2}";
            _component.Rating.text = $"+{_model.Count2 * 5} DKP";
            _component.Close.onClick.AddListener(ClickClose);
            foreach (var unitModel in _model.UnitModels)
            {
                var component = _component.Create();
                var controller = new CourseDetailsUnitController(_context, component,unitModel);
                _controllerCollection.Add(controller);
            }
            
            _controllerCollection.Activate();
        }

        private void ClickClose()
        {
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Profile);
        }
    }
}