using System.Collections.Generic;
using ScreenObserver;
using Screens.Courses.Search;
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
            _generators.Add(new SearchGenerator());
        }
        public void Generate(DirectionsContext context, DirectionsContainer container, ControllerCollection collection)
        {
            foreach (var generator in _generators)
            {
                generator.Generate(context, container, collection);
            }
        }
    }
}