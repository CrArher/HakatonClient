namespace Screens.BattlePass
{
    public class BattlePassUnitController : IController
    {
        private readonly BattlePassContext _context;
        private readonly BattlePassUnitModel _model;
        private readonly BattlePassUnitComponent _component;

        public BattlePassUnitController(BattlePassContext context,BattlePassUnitModel model,BattlePassUnitComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _component.ShowDescription.onClick.RemoveListener(OnShowDescription);
        }

        public void Activate()
        {
            _component.LVL.text = _model.BattlePassDescription.Level.ToString();
            _component.Image.sprite = _context.ImageLoaderComponent.Get(_model.BattlePassDescription.Sprite);
            _component.ShowDescription.onClick.AddListener(OnShowDescription);
            if (_model.BattlePassDescription.IsTaken)
            {
                _component.Alpha.alpha = 0.5f;
            }
            else
            {
                _component.Alpha.alpha = 1.0f;
            }
        }

        private void OnShowDescription()
        {
            _context.BattlePassModel.SetRequirement(_model.BattlePassDescription.Requirement);
            _context.BattlePassModel.SetReward(_model.BattlePassDescription.Reward);
        }
    }
}