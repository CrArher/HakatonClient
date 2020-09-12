namespace Screens.AchievementScreen.Base
{
    public class AchievementController : IController
    {
        private readonly AchievementScreenContext _context;
        private readonly AchievementComponent _component;
        private readonly AchievementsModel _model;
        private readonly ControllerCollection _controllerCollection = new ControllerCollection();

        public AchievementController(AchievementScreenContext context, AchievementComponent component, AchievementsModel model)
        {
            _context = context;
            _component = component;
            _model = model;
        }
        
        public void Deactivate()
        {
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
            _component.Clear();
        }

        public void Activate()
        {
            foreach (var unitModel in _model.GetAll())
            {
                var component = _component.Create();
                var controller = new AchievementUnitController(_context, unitModel, component);
                _controllerCollection.Add(controller);
            }   
            
            _controllerCollection.Activate();
        }
    }
}