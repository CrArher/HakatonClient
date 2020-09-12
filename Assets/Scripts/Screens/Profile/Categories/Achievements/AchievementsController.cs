using UnityEngine.UI;

namespace DefaultNamespace.Screens.Profile.Categories.Achievements
{
    public class AchievementsController : IController
    {
        private readonly ProfileContext _context;
        private readonly AchievementsModel _model;
        private readonly AchievementsComponent _component;

        public AchievementsController(ProfileContext context, AchievementsModel model, AchievementsComponent component)
        {
            _context = context;
            _model = model;
            _component = component;
        }

        public void Deactivate()
        {
        }

        public  void Activate()
        {
               
        }
    }
}