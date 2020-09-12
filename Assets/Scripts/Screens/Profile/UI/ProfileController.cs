namespace DefaultNamespace.Screens.Profile
{
    public class ProfileController : IController
    {
        private readonly ProfileContext _context;
        private readonly ProfileComponent _component;
        private readonly ProfileModel _model;
        ControllerCollection _controllerCollection = new ControllerCollection();

        public ProfileController(ProfileContext context,ProfileModel model , ProfileComponent component)
        {
            _context = context;
            _component = component;
            _model = model;
        }
        public void Deactivate()
        {
            throw new System.NotImplementedException();
        }

        public void Activate()
        {
            throw new System.NotImplementedException();
        }
    }
}