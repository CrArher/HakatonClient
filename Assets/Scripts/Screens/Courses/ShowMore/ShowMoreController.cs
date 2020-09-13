namespace Screens.Courses.ShowMore
{
    public class ShowMoreController : IController
    {
        private readonly DirectionsContext _context;
        private readonly ShowMoreModel _model;
        private readonly ShowMoreComponent _component;

        public ShowMoreController(DirectionsContext context,ShowMoreModel model,ShowMoreComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _model.ChangedModel -= ChangedModel;
            _model.Hide -= OnHide;
            _model.Show -= OnShow;
            _component.Close.onClick.RemoveListener(OnHide);
        }

        public void Activate()
        {
            _model.ChangedModel += ChangedModel;
            _model.Hide += OnHide;
            _model.Show += OnShow;
            _component.Close.onClick.AddListener(OnHide);
        }

        private void OnShow()
        {
            _component.Root.SetActive(true);
        }

        private void OnHide()
        {
            _component.Root.SetActive(false);
        }

        private void ChangedModel()
        {
            _component.Name.text = _model.GetCurrentModel().DirectionDescription.Name;
            _component.Description.text = _model.GetCurrentModel().DirectionDescription.Description;
        }
    }
}