using UnityEngine;

namespace Screens.CourseDetails
{
    public class CourseDetailsUnitController : IController
    {
        private readonly CourseDetailsContext _context;
        private readonly CourseDetailsUnitComponent _component;
        private readonly CourseDetailsUnitModel _unitModel;

        public CourseDetailsUnitController(CourseDetailsContext context, CourseDetailsUnitComponent component, CourseDetailsUnitModel unitModel)
        {
            _context = context;
            _component = component;
            _unitModel = unitModel;
        }

        public void Deactivate()
        {
            _component.Button.onClick.RemoveListener(Click);
        }

        public void Activate()
        {
            _component.Icon.color = _unitModel.Description.IsEnable ? Color.green : Color.red;
            _component.Text.text = $"Урок {_unitModel.Description.Id}";
            _component.Button.onClick.AddListener(Click);
        }

        private void Click()
        {
            _context.RoomDialogModel.Show(_unitModel);
        }
    }
}