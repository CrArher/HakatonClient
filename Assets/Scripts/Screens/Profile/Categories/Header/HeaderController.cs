namespace Screens.Profile.Categories.Header
{
    public class HeaderController : IController
    {
        private readonly ProfileContext _context;
        private readonly HeaderComponent _component;
        private readonly HeaderModel _model;

        public HeaderController(ProfileContext context, HeaderModel model , HeaderComponent component)
        {
            _context = context;
            _component = component;
            _model = model;
        }
        public void Deactivate()
        {
            
        }

        public void Activate()
        {
            _component.Avatar.texture = _model.Avatar;
            _component.MainAchievement.texture = _model.MainAchievement;
            _component.RateNumber.text = _model.RateNumber.ToString();
        }
    }
}