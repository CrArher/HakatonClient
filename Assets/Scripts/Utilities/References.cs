using System.Collections.Generic;
using Screens.AchievementScreen;
using Screens.Courses;

namespace Utilities
{
    public class References
    {
        public DescriptionCollection<AchievementDescription> Achievements { get; }
        public DescriptionCollection<DirectionDescription> Directions { get; }

        public References(Dictionary<string, object> rawData, Factory factory)
        {
            Achievements =
                LoadDictionary<AchievementDescription>((Dictionary<string, object>) rawData["achievements"], factory);
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