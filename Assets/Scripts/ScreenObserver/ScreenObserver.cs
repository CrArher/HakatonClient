using DefaultNamespace;
using DefaultNamespace.Screens.Profile;
using ScreenManager;
using ScreenManager.ScreenChanger;

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
                    var generator = new ProfileScreenGenerator();
                    generator.Generate(new ProfileContext(), _container.ProfileContainer,_controllerCollection);
                    break;
            }

            _controllerCollection.Activate();
        }
    }
}