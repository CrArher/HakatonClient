using System.Collections.Generic;
using System.Linq;

namespace Screens.Courses.Search
{
    public class TagUnitObserver: IController
    {
        private readonly DirectionsContext _context;
        private readonly SearchModel _model;
        private readonly SearchUnitModel _unitModel;

        public TagUnitObserver(DirectionsContext context, SearchModel model, SearchUnitModel unitModel)
        {
            _context = context;
            _model = model;
            _unitModel = unitModel;
        }

        public void Deactivate()
        {
            _unitModel.OnClick -= OnClick;
        }

        public void Activate()
        {
            _unitModel.OnClick += OnClick;
        }

        private void OnClick()
        {
            var list = new List<string>();
            
            foreach (var unitModel in _model.GetAll())
            {
                if (unitModel.IsEnable)
                {
                    list.Add(unitModel.Tag);
                }    
            }

            foreach (var directionUnitModel in _context.DirectionModel.UnitModels)
            {
                var isExist = true;

                foreach (var tag in list)
                {
                    if (!directionUnitModel.DirectionDescription.Tags.Contains(tag))
                    {
                        isExist = false;
                    }
                }

                if (!isExist)
                {
                    directionUnitModel.Hide();
                }
                else
                {
                    directionUnitModel.Show();
                }
            }
        }
    }
}