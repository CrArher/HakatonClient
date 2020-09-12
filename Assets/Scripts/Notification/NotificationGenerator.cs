namespace Notification
{
    public class NotificationGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var model = new NotificationModel();
            context.NotificationModel = model;
            var controller = new NotificationController(context,model,container.NotificationComponent);
            controllerCollection.Add(controller);
        }
    }
}