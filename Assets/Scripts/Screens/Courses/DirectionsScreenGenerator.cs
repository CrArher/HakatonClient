using System.Collections.Generic;
using ScreenObserver;
using Screens.Courses.ShowMore;

namespace Screens.Courses
{
    public class DirectionsScreenGenerator : IScreenGenerator<DirectionsContext, DirectionsContainer>
    {
        private List<IScreenGenerator<DirectionsContext, DirectionsContainer>> _generators =
            new List<IScreenGenerator<DirectionsContext, DirectionsContainer>>();

        public DirectionsScreenGenerator()
        {
            _generators.Add(new DirectionGenerator());
            _generators.Add(new ShowMoreGenerator());
        }
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
        }
    }
}