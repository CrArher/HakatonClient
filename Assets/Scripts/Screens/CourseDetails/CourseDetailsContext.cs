namespace Screens.CourseDetails
{
    public class CourseDetailsContext : GlobalContext
    {
        public RoomDialogModel RoomDialogModel;
        public CourseDetailsContext(GlobalContext context) : base(context)
        {
            
        }
    }
}