using Screens.Courses.Search;
using Screens.Courses.ShowMore;

namespace Screens.Courses
{
    public class DirectionsContext : GlobalContext
    {
        public DirectionsContext(GlobalContext context) : base(context)
        {
        }

        public DirectionModel DirectionModel { get; set; }
        public ShowMoreModel ShowMoreModel { get; set; }
        public SearchModel SearchModel { get; set; }
    }
}