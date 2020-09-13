using System.Collections.Generic;
using ScreenObserver;

namespace Screens.CourseDetails
{
    public class CourseDetailsScreenGenerator : IScreenGenerator<CourseDetailsContext,CourseDetailsScreenContainer>
    {
        private readonly List<IScreenGenerator<CourseDetailsContext,CourseDetailsScreenContainer>> _generators = new List<IScreenGenerator<CourseDetailsContext, CourseDetailsScreenContainer>>();

        public CourseDetailsScreenGenerator()
        {
            _generators.Add(new CourseDetailsGenerator());
        }
        
        public void Generate(CourseDetailsContext context, CourseDetailsScreenContainer container, ControllerCollection collection)
        {
            foreach (var generator in _generators)
            {
                generator.Generate(context, container, collection);
            }
        }
    }
}