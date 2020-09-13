namespace Screens.Courses.Search
{
    public class TagController : IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchModel _model;
        private readonly Tag _component;

        public TagController(DirectionsContext context,SearchModel model,Tag component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _component.AddOrRemoveTag.onClick.RemoveListener(OnAddOrRemoveTag);
        }

        public void Activate()
        {
            _component.AddOrRemoveTag.onClick.AddListener(OnAddOrRemoveTag);
        }

        private void OnAddOrRemoveTag()
        {
            if (!_model.tags.Contains(_component.tag.text))
            {
                _model.tags.Add(_component.tag.text);
                _component.Mark.gameObject.SetActive(true);
            }
            else
            {
                _model.tags.Remove(_component.tag.text);
                _component.Mark.gameObject.SetActive(false);
            }
            _context.DirectionModel.OnShowByTags(_model.tags);
        }
    }
}