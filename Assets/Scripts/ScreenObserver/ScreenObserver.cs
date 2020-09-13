using ScreenManager;
using ScreenManager.ScreenChanger;
using Screens.AchievementScreen;
using Screens.BattlePass;
using Screens.Courses;
using Screens.Profile;

namespace ScreenObserver
{
    public class ScreenObserver : IController
    {
        private ControllerCollection _controllerCollection = new ControllerCollection();
        private readonly GlobalContext _context;
        private readonly ScreenChangerModel _model;
        private readonly ScreensContainer _container;

        public ScreenObserver(GlobalContext context, ScreenChangerModel model, ScreensContainer container)
        {
            _context = context;
            _model = model;
            _container = container;
        }

        public void Deactivate()
        {
            _model.ChangedScreen -= OnChangeScreen;
        }

        public void Activate()
        {
            _model.ChangedScreen += OnChangeScreen;
            OnChangeScreen();
        }

        private void OnChangeScreen()
        {
            _controllerCollection.Deactivate();
            _controllerCollection.Clear();
            switch (_model.CurrentScreen)
            {
                case ScreenType.Profile:
                    new ProfileScreenGenerator().Generate(new ProfileContext(_context), _container.ProfileContainer,
                        _controllerCollection);
                    break;
                case ScreenType.Achievements:
                    new AchievementScreenGenerator().Generate(new AchievementScreenContext(_context),
                        _container.AchievementScreenContainer, _controllerCollection);
                    break;
                case ScreenType.Directions:
                    new DirectionsScreenGenerator().Generate(new DirectionsContext(_context),
                        _container.directionsContainer, _controllerCollection);
                    break;
                case ScreenType.BattlePass:
                    new BattlePassScreenGenerator().Generate(new BattlePassContext(_context),
                        _container.BattlePassContainer, _controllerCollection);
                    break;
            }

            _controllerCollection.Activate();
        }
    }
}