using ScreenManager;

namespace FootMenu
{
    public class FootMenuController : IController
    {
        private readonly GlobalContext _context;
        private readonly FootMenuComponent _component;

        public FootMenuController(GlobalContext context, FootMenuComponent component)
        {
            _context = context;
            _component = component;
        }

        public void Deactivate()
        {
            _component.Profile.Button.onClick.RemoveListener(OnProfile);
            _component.Shop.Button.onClick.RemoveListener(OnShop);
            _component.BattlePass.Button.onClick.RemoveListener(OnBattlePass);
            _component.Directions.Button.onClick.RemoveListener(OnDirections);
            _component.Achievements.Button.onClick.RemoveListener(OnAchievements);
            _context.ScreenChangerModel.ChangedScreen -= IsActive;
        }

        public void Activate()
        {
            _component.Show(_component.Profile);

            _component.Profile.Button.onClick.AddListener(OnProfile);
            _component.Shop.Button.onClick.AddListener(OnShop);
            _component.BattlePass.Button.onClick.AddListener(OnBattlePass);
            _component.Directions.Button.onClick.AddListener(OnDirections);
            _component.Achievements.Button.onClick.AddListener(OnAchievements);
            _context.ScreenChangerModel.ChangedScreen += IsActive;
        }

        private void OnAchievements()
        {
            _component.Show(_component.Achievements);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Achievements);        }

        private void IsActive()
        {
            if (_context.ScreenChangerModel.CurrentScreen == ScreenType.Directions || 
                _context.ScreenChangerModel.CurrentScreen == ScreenType.Profile ||
                _context.ScreenChangerModel.CurrentScreen == ScreenType.Shop ||
                _context.ScreenChangerModel.CurrentScreen == ScreenType.BattlePass ||
                _context.ScreenChangerModel.CurrentScreen == ScreenType.Achievements)
            {
                _component.root.SetActive(true);
            }
            else
            {
                _component.root.SetActive(false);
            }
        }
        
        
        
        private void OnDirections()
        {
            _component.Show(_component.Directions);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Directions);
        }

        private void OnBattlePass()
        {
            _component.Show(_component.BattlePass);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.BattlePass);
        }

        private void OnShop()
        {
            _component.Show(_component.Shop);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Shop);
        }

        private void OnProfile()
        {
            _component.Show(_component.Profile);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Profile);
            _context.NotificationModel.OnNotificationFalse();
        }
    }
}