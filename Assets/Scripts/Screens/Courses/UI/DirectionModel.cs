using System.Collections.Generic;
using Utilities;

namespace Screens.Courses
{
    public class DirectionModel
    {
        public List<DirectionUnitModel> UnitModels = new List<DirectionUnitModel>();

        public DirectionModel(DescriptionCollection<DirectionDescription> Descriptions)
        {
            foreach (var description in Descriptions)
            {
                UnitModels.Add(new DirectionUnitModel(description.Value));
            }    
        }
    }
}