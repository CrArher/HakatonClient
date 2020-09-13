namespace Screens.CourseDetails
{
    public class RoomDialogController : IController
    {
        private readonly RoomDialogModel _model;
        private readonly RoomDialogComponent _component;

        public RoomDialogController(RoomDialogModel model, RoomDialogComponent component)
        {
            _model = model;
            _component = component;
        }
        
        public void Deactivate()
        {
            _model.OnShow -= OnShow;
            _component.Close.onClick.RemoveListener(ClickClose);
        }

        public void Activate()
        {
            _model.OnShow += OnShow;
            _component.Close.onClick.AddListener(ClickClose);
        }

        private void ClickClose()
        {
            _component.gameObject.SetActive(false);
        }

        private void OnShow()
        {
            _component.gameObject.SetActive(true);
            _component.Name.text = $"Урок номер {_model.UnitModel.Description.Id}";
        }
    }
}