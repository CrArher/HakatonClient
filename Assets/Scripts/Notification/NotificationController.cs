namespace Notification
{
    public class NotificationController : IController
    {
        private readonly GlobalContext _context;
        private readonly NotificationModel _model;
        private readonly NotificationComponent _component;

        public NotificationController(GlobalContext context,NotificationModel model,NotificationComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }
        public void Deactivate()
        {
            _model.Notification -= OnNotifiaction;
        }

        public void Activate()
        {
            _model.Notification += OnNotifiaction;
        }

        private void OnNotifiaction()
        {
            if (_model.IsNotification)
            {
                _component.Notification.gameObject.SetActive(true);
            }
            else
            {
                _component.Notification.gameObject.SetActive(false);
            }
        }
    }
}