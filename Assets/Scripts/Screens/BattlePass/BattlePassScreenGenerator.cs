using System.Collections.Generic;
using ScreenObserver;

namespace Screens.BattlePass
{
    public class BattlePassScreenGenerator : IScreenGenerator<BattlePassContext, BattlePassContainer>
    {
        List<IScreenGenerator<BattlePassContext, BattlePassContainer>> _generators =
            new List<IScreenGenerator<BattlePassContext, BattlePassContainer>>();

        public BattlePassScreenGenerator()
        {
            _generators.Add(new BattlePassGenerator());
        }
        public void Generate(BattlePassContext context, BattlePassContainer container, ControllerCollection collection)
        {
            foreach (var generator in _generators)
            {
                generator.Generate(context,container,collection);
            }
        }
    }
}