using System.Collections.Generic;
using Utilities;

namespace Screens.Courses
{
    public class DirectionDescription : IDescription
    {

        public DirectionDescription(Dictionary<string,object> node)
        {
            Name = node.GetString("name");
            Description = node.GetString("description");
            Teacher = node.GetString("teacher");
            Tags = node.GetStingArray("tags");
            
        }

        public string Description;

        public string Name;
        public string Teacher;
        public List<string> Tags;
    }
}