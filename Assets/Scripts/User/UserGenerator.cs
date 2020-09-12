using DefaultNamespace;

namespace User
{
    public class UserGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var model = new UserModel();
            context.UserModel = model;
            var controller = new UserController(context,model);
            controllerCollection.Add(controller);
        }
    }
}