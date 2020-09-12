﻿namespace Screens.Courses
{
    public class DirectionUnitController : IController
    {
        private readonly CoursesContext _context;
        private readonly DirectionUnitComponent _component;
        private readonly DirectionUnitModel _model;

        public DirectionUnitController(CoursesContext context,DirectionUnitModel model,DirectionUnitComponent component)
        {
            _context = context;
            _component = component;
            _model = model;
        }
        public void Deactivate()
        {
            _context.ShowMoreModel.OnHide();
        }

        public void Activate()
        {
            _component.Name.text = _model.DirectionDescription.Name;
            _component.Teacher.text = _model.DirectionDescription.Teacher;
            _component.ShortDescription.text = _model.DirectionDescription.Description.Substring(20) + "...";
            foreach (var tag in _model.DirectionDescription.Tags)
            {
                _component.Tags.text += tag + ",";
            }

            _component.Tags.text.Substring(_component.Tags.text.Length);
            _component.ShowMore.onClick.AddListener(OnShowMore);
        }

        private void OnShowMore()
        {
            _context.ShowMoreModel.SetCurrentModel(_model);
            _context.ShowMoreModel.OnShow();
        }
    }
}