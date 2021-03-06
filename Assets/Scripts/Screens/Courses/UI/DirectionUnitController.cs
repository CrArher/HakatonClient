﻿namespace Screens.Courses
{
    public class DirectionUnitController : IController
    {
        private readonly DirectionsContext _context;
        private readonly DirectionUnitComponent _component;
        private readonly DirectionUnitModel _model;

        public DirectionUnitController(DirectionsContext context,DirectionUnitModel model,DirectionUnitComponent component)
        {
            _context = context;
            _component = component;
            _model = model;
        }
        public void Deactivate()
        {
            _context.ShowMoreModel.OnHide();
            _model.OnHide -= OnHide;
            _model.OnShow -= OnShow;
        }

        public void Activate()
        {
            _component.Name.text = _model.DirectionDescription.Name;
            _component.ShortDescription.text = _model.DirectionDescription.Description;
            _component.ShortDescription.text = _component.ShortDescription.text.Remove(180) + "..";
            _component.ShowMore.onClick.AddListener(OnShowMore);

            _model.OnHide += OnHide;
            _model.OnShow += OnShow;
        }

        private void OnShow()
        {
            _component.gameObject.SetActive(true);
        }

        private void OnHide()
        {
            _component.gameObject.SetActive(false);
        }

        private void OnShowMore()
        {
            _context.ShowMoreModel.SetCurrentModel(_model);
            _context.ShowMoreModel.OnShow();
        }
    }
}