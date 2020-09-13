namespace Screens.BattlePass
{
    public class BattlePassController : IController
    {
        private readonly BattlePassContext _context;
        private readonly BattlePassModel _model;
        private readonly BattlePassComponent _component;
        ControllerCollection _controllerCollection = new ControllerCollection();

        public BattlePassController(BattlePassContext context,BattlePassModel model,BattlePassComponent component)
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
            
            
            _model.OnSetRequirement -= OnSetRequirement;
            _model.OnSetReward -= OnSetReward;
        }

        public void Activate()
        {
            foreach (var unitModel in _model.UnitModels)
            {
                var component = _component.CreateComponent();
                var controller = new BattlePassUnitController(_context,unitModel,component);
                controller.Activate();
                _controllerCollection.Add(controller);
            }

            _model.OnSetRequirement += OnSetRequirement;
            _model.OnSetReward += OnSetReward;
        }

        private void OnSetReward(string obj)
        {
            _component.Reward.text = obj;
        }

        private void OnSetRequirement(string obj)
        {
            _component.Requirement.text = obj;
        }
    }
}