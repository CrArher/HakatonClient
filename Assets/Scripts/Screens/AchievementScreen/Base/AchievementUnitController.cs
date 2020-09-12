namespace Screens.AchievementScreen.Base
{
    public class AchievementUnitController : IController
    {
        private readonly AchievementScreenContext _context;
        private readonly AchievementUnitModel _model;
        private readonly AchievementUnitComponent _component;

        public AchievementUnitController(AchievementScreenContext context, AchievementUnitModel model, AchievementUnitComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        
        public void Deactivate()
        {
            _component.Click -= OnClick;
        }

        public void Activate()
        {
            _component.Click += OnClick;
            _component.SetIcon(_context.ImageLoaderComponent.Get(_model.Description.Icon), _model.Description.Enabled);
        }

        private void OnClick()
        {
            _context.AchievementDetailsDialogModel.Show(_model);
        }
    }
}