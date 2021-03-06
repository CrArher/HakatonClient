﻿using System;
using System.Collections.Generic;
using Screens.AchievementScreen;
using Screens.BattlePass;
using Screens.CourseDetails;
using Screens.Courses;

namespace Utilities
{
    public class Factory
    {
        public readonly Dictionary<string, Func<Dictionary<string, object>, IDescription>> DescriptionFactory;

        public Factory()
        {
            DescriptionFactory = new Dictionary<string, Func<Dictionary<string, object>, IDescription>>
            {
                {"achievements", (node) => new AchievementDescription(node)},
                {"directions", (node) => new DirectionDescription(node)},
                {"ar_course_details", (node) => new CourseDetailsDescription(node)},
                {"java_course_details", (node) => new CourseDetailsDescription(node)},
                {"battlepass", (node) => new BattlePassDescription(node)}
                
            };
        }
        
        
    }
}