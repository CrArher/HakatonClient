namespace ScreenManager.ScreenChanger
{
    public class ScreenChangerGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var model = new ScreenChangerModel(ScreenType.BattlePass);
            var controller = new ScreenChangerController(context,model,container.GameScreens);
            var screenObserver = new ScreenObserver.ScreenObserver(context,model, container.ScreensContainer);

            context.ScreenChangerModel = model;
            controllerCollection.Add(screenObserver);
            controllerCollection.Add(controller);
        }
    }
}