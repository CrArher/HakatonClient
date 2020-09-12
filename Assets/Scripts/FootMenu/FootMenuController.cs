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
            _component.Profile.onClick.RemoveListener(OnProfile);
            _component.Shop.onClick.RemoveListener(OnShop);
            _component.BattlePass.onClick.RemoveListener(OnBattlePass);
            _component.Directions.onClick.RemoveListener(OnDirections);
            _context.ScreenChangerModel.ChangedScreen -= IsActive;
        }

        public void Activate()
        {
            _component.Profile.onClick.AddListener(OnProfile);
            _component.Shop.onClick.AddListener(OnShop);
            _component.BattlePass.onClick.AddListener(OnBattlePass);
            _component.Directions.onClick.AddListener(OnDirections);
            _context.ScreenChangerModel.ChangedScreen += IsActive;
        }

        private void IsActive()
        {
            if (_context.ScreenChangerModel.CurrentScreen == ScreenType.Directions || 
                _context.ScreenChangerModel.CurrentScreen == ScreenType.Profile ||
                _context.ScreenChangerModel.CurrentScreen == ScreenType.Shop ||
                _context.ScreenChangerModel.CurrentScreen == ScreenType.BattlePass)
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
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Directions);
        }

        private void OnBattlePass()
        {
            _context.ScreenChangerModel.SwitchScreen(ScreenType.BattlePass);
        }

        private void OnShop()
        {
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Shop);
        }

        private void OnProfile()
        {
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Profile);
        }
    }
}