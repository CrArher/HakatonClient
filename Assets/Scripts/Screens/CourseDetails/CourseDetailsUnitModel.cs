namespace Screens.CourseDetails
{
    public class CourseDetailsUnitModel
    {
        public CourseDetailsDescription Description { get; }

        public CourseDetailsUnitModel(CourseDetailsDescription description)
        {
            Description = description;
        }
    }
}