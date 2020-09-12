namespace Screens.Profile.Categories.Info
{
    public class InfoController : IController
    {
        private readonly ProfileContext _context;
        private readonly InfoComponent _component;
        private readonly InfoModel _model;

        public InfoController(ProfileContext context,InfoModel model,InfoComponent component)
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
            _component.Name.text = _model.Name;
            _component.LastName.text = _model.LastName;
            _component.Description.text = _model.Description;
            _component.Interests.text = _model.Interests;
            _component.Directions.text = _model.Directions;
        }
    }
}