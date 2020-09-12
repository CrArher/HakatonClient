using System.Collections.Generic;
using UnityEngine;
using Utilities;

namespace Screens.AchievementScreen
{
    public class AchievementDescription : IDescription
    {
        public string Icon;
        public string AchievementType;
        public string Name;
        public string NameCourse;
        public string Description;
        
        public AchievementDescription(IDictionary<string, object> node)
        {
            AchievementType = node.GetString("type");
            Name = node.GetString("name");
            NameCourse = node.GetString("name_course");
            Description = node.GetString("description");
            Icon = node.GetString("icon");
        }
    }
}