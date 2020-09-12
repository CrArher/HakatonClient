namespace FootMenu
{
    public class FootMenuGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var controller = new FootMenuController(context,container.FootComponent);
            controllerCollection.Add(controller);
        }
    }
}