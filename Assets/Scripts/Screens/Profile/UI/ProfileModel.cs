using System.Collections.Generic;

namespace DefaultNamespace.Screens.Profile
{
    public class ProfileModel
    {
        public List<ProfileUnitModel> UnitModels = new List<ProfileUnitModel>();

        public IEnumerable<ProfileCategories> GetCategories()
        {
            yield return ProfileCategories.Info;
            yield return ProfileCategories.Activity;
            yield return ProfileCategories.Аchievements;
        }
    }
}