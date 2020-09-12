using DefaultNamespace;

namespace ScreenManager.ScreenChanger
{
    public class ScreenChangerGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var model = new ScreenChangerModel(ScreenType.SignUp);
            context.ScreenChangerModel = model;
            var controller = new ScreenChangerController(context,model,container.GameScreens);
            controllerCollection.Add(controller);
        }
    }
}