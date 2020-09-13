using ScreenObserver;

namespace Screens.CourseDetails
{
    public class CourseDetailsGenerator : IScreenGenerator<CourseDetailsContext,CourseDetailsScreenContainer>
    {
        public void Generate(CourseDetailsContext context, CourseDetailsScreenContainer container, ControllerCollection collection)
        {
            var controller = new CourseDetailsController(context, context.CourseDetailsModel, container.CourseDetailsComponent);
            var model = new RoomDialogModel();
            context.RoomDialogModel = model;
            var roomDialogController = new RoomDialogController(model, container.RoomDialogComponent);
            
            collection.Add(controller);
            collection.Add(roomDialogController);
        }
    }
}