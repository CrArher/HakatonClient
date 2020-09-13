using System.Collections.Generic;
using Utilities;

namespace Screens.CourseDetails
{
    public class CourseDetailsDescription : IDescription
    {
        public int Id;
        public bool IsEnable;

        public CourseDetailsDescription(Dictionary<string, object> node)
        {
            Id = node.GetInt("id");
            IsEnable = node.GetBool("is_enable");
        }
    }
}