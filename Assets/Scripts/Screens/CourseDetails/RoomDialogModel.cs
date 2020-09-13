using System;

namespace Screens.CourseDetails
{
    public class RoomDialogModel
    {
        public event Action OnShow;
        
        public CourseDetailsUnitModel UnitModel;
        
        public void Show(CourseDetailsUnitModel unitModel)
        {
            UnitModel = unitModel;
            OnShow?.Invoke();
        }
    }
}