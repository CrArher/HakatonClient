using System;
using System.Collections.Generic;
using Utilities;

namespace Screens.Courses
{
    public class DirectionModel
    {
        public event Action<List<string>> ShowByTags;
        public List<DirectionUnitModel> UnitModels = new List<DirectionUnitModel>();


        public DirectionModel(DescriptionCollection<DirectionDescription> Descriptions)
        {
            foreach (var description in Descriptions)
            {
                UnitModels.Add(new DirectionUnitModel(description.Value));
            }    
        }


        public void OnShowByTags(List<string> obj)
        {
            ShowByTags?.Invoke(obj);
        }
    }
}