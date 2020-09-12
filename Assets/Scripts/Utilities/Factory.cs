using System;
using System.Collections.Generic;
using Screens.AchievementScreen;

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
            };
        }
        
        
    }
}