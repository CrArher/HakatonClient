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
            _component.Show();
        }

        private void ClickClose()
        {
            _component.Hide();
        }
    }
}