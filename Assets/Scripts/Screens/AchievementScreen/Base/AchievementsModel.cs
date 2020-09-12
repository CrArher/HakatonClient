using System.Collections.Generic;
using Utilities;

namespace Screens.AchievementScreen.Base
{
    public class AchievementsModel
    {
        private readonly Dictionary<string, AchievementUnitModel> _achievements = new Dictionary<string, AchievementUnitModel>();

        public AchievementsModel(DescriptionCollection<AchievementDescription> descriptions)
        {
            foreach (var description in descriptions)
            {
                _achievements.Add(description.Value.Name, new AchievementUnitModel(description.Value));
            }
        }

        public AchievementUnitModel Get(string key)
        {
            return _achievements[key];
        }
        
        public IEnumerable<AchievementUnitModel> GetAll()
        {
            foreach (var achievement in _achievements.Values)
            {
                yield return achievement;
            }
        }
    }
}