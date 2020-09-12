using System;

namespace Screens.Courses.ShowMore
{
    public class ShowMoreModel
    {
        public event Action ChangedModel;
        public event Action Show;
        public event Action Hide;

        private DirectionUnitModel currentModel;

        public void SetCurrentModel(DirectionUnitModel unitModel)
        {
            currentModel = unitModel;
            ChangedModel?.Invoke();
        }

        public void OnHide()
        {
            Hide?.Invoke();
        }

        public void OnShow()
        {
            Show?.Invoke();
        }

        public DirectionUnitModel GetCurrentModel()
        {
            return currentModel;
        }
    }
}