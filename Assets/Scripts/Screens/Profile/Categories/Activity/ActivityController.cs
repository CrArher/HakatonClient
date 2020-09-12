namespace Screens.Profile.Categories.Activity
{
    public class ActivityController : IController
    {
        private readonly ProfileContext _context;
        private readonly ActivityModel _model;
        private readonly ActivityComponent _component;

        public ActivityController(ProfileContext context,ActivityModel model,ActivityComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
        }

        public void Activate()
        {
        }
    }
}