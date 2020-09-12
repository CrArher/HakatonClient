using System.Collections.Generic;
using ScreenObserver;
using Screens.Courses.ShowMore;

namespace Screens.Courses
{
    public class CoursesScreenGenerator : IScreenGenerator<CoursesContext, CoursesContainer>
    {
        private List<IScreenGenerator<CoursesContext, CoursesContainer>> _generators =
            new List<IScreenGenerator<CoursesContext, CoursesContainer>>();

        public CoursesScreenGenerator()
        {
            _generators.Add(new DirectionGenerator());
            _generators.Add(new ShowMoreGenerator());
        }
        public void Generate(CoursesContext context, CoursesContainer container, ControllerCollection collection)
        {
        }
    }
}