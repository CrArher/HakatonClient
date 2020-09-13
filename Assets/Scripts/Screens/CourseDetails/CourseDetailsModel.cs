using System.Collections.Generic;
using Utilities;

namespace Screens.CourseDetails
{
    public class CourseDetailsModel
    {
        public readonly List<CourseDetailsUnitModel> UnitModels = new List<CourseDetailsUnitModel>();
        public int Count;
        public int Count2;
        public void Show(DescriptionCollection<CourseDetailsDescription> descriptions)
        {
            UnitModels.Clear();
            Count = 0;
            Count2 = 0;
            foreach (var description in descriptions)
            {
                if (!description.Value.IsEnable)
                {
                    Count++;
                }
                else
                {
                    Count2++;
                }
                
                UnitModels.Add(new CourseDetailsUnitModel(description.Value));
            }
        }
    }
}