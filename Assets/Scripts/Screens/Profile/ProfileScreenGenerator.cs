using System.Collections.Generic;
using ScreenObserver;
using Screens.Profile.Categories.Achievements;

namespace Screens.Profile
{
    public class ProfileScreenGenerator : IScreenGenerator<ProfileContext,ProfileContainer>
    {
        private readonly List<IScreenGenerator<ProfileContext,ProfileContainer>> _generators = new List<IScreenGenerator<ProfileContext, ProfileContainer>>();
        
        public ProfileScreenGenerator()
        {
            _generators.Add(new AchievementsCategoryGenerator());
        }
        
        public void Generate(ProfileContext context, ProfileContainer container, ControllerCollection collection)
        {
            foreach (var generator in _generators)
            {
                generator.Generate(context, container, collection);
            }
        }
    }
}