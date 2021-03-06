﻿using System.Collections.Generic;
using Screens.AchievementScreen;
using Screens.BattlePass;
using Screens.CourseDetails;
using Screens.Courses;

namespace Utilities
{
    public class References
    {
        public DescriptionCollection<AchievementDescription> Achievements { get; }
        public DescriptionCollection<DirectionDescription> Directions { get; }
        public DescriptionCollection<BattlePassDescription> BattlePass { get; }
        public DescriptionCollection<CourseDetailsDescription> ArCourseDetails { get; }
        public DescriptionCollection<CourseDetailsDescription> JavaCourseDetails { get; }

        public References(Dictionary<string, object> rawData, Factory factory)
        {
            Achievements = LoadDictionary<AchievementDescription>((Dictionary<string, object>) rawData["achievements"], factory);
            Directions = LoadDictionary<DirectionDescription>((Dictionary<string, object>) rawData["directions"], factory);
            BattlePass = LoadDictionary<BattlePassDescription>((Dictionary<string, object>) rawData["battlepass"], factory);
            ArCourseDetails = LoadDictionary<CourseDetailsDescription>((Dictionary<string, object>) rawData["ar_course_details"], factory);
            JavaCourseDetails = LoadDictionary<CourseDetailsDescription>((Dictionary<string, object>) rawData["java_course_details"], factory);
        }

        private DescriptionCollection<T> LoadDictionary<T>(Dictionary<string, object> nodes, Factory factory)
            where T : IDescription
        {
            var dictionary = new DescriptionCollection<T>();

            foreach (var node in nodes)
            {
                foreach (var keyValuePair in (Dictionary<string, object>) node.Value)
                {
                    dictionary.Add(keyValuePair.Key,
                        (T) factory.DescriptionFactory[node.Key]((Dictionary<string, object>) keyValuePair.Value));
                }
            }

            return dictionary;
        }
    }
}