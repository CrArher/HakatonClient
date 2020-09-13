namespace Screens.Courses.Search
{
    public class SearchUnitController : IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchUnitModel _model;
        private readonly SearchUnitComponent _component;

        public SearchUnitController(DirectionsContext context, SearchUnitModel model, SearchUnitComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }

        public void Deactivate()
        {
            _component.Click -= OnClick;
        }

        public void Activate()
        {
            _component.NameTag.text = _model.Tag;
            _component.Click += OnClick;
        }

        private void OnClick()
        {
            _model.Click();
            _component.Icon.gameObject.SetActive(_model.IsEnable);
        }
    }
}