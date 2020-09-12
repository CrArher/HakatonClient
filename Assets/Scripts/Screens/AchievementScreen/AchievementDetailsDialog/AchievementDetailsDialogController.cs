namespace Screens.AchievementScreen.AchievementDetailsDialog
{
    public class AchievementDetailsDialogController : IController
    {
        private readonly AchievementScreenContext _context;
        private readonly AchievementDetailsDialogModel _model;
        private readonly AchievementDetailsDialogComponent _component;

        public AchievementDetailsDialogController(AchievementScreenContext context, AchievementDetailsDialogModel model, AchievementDetailsDialogComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        
        public void Deactivate()
        {
            _model.OnShow -= OnShow;
            _component.CloseButton.onClick.RemoveListener(ClickClose);
        }

        public void Activate()
        {
            _model.OnShow += OnShow;
            _component.CloseButton.onClick.AddListener(ClickClose);
        }

        private void OnShow()
        {
            var description = _model.Achievement.Description;
            
            _component.Name.text = description.Name;
            _component.Desciption.text = description.Description;
            _component.State.text = description.Enabled ? "Получено" : "Еще не получено";
            _component.Show(_context.ImageLoaderComponent.Get(description.Icon));
        }

        private void ClickClose()
        {
            _component.Hide();
        }
    }
}