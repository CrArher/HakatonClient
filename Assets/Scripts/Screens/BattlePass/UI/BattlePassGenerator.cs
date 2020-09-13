using ScreenObserver;

namespace Screens.BattlePass
{
    public class BattlePassGenerator : IScreenGenerator<BattlePassContext,BattlePassContainer>
    {
        public void Generate(BattlePassContext context, BattlePassContainer container, ControllerCollection collection)
        {
            var model = new BattlePassModel(context.References.BattlePass);
            context.BattlePassModel = model;
            var controller = new BattlePassController(context,model,container.BattlePassComponent);
            collection.Add(controller);
        }
    }
}