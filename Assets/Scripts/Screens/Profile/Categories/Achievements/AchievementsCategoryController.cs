using ScreenManager;

namespace Screens.Profile.Categories.Achievements
{
    public class AchievementsCategoryController : IController
    {
        private readonly ProfileContext _context;
        private readonly AchievementsCategoryModel _categoryModel;
        private readonly AchievementsCategoryComponent _categoryComponent;

        public AchievementsCategoryController(ProfileContext context, AchievementsCategoryModel categoryModel, AchievementsCategoryComponent categoryComponent)
        {
            _context = context;
            _categoryModel = categoryModel;
            _categoryComponent = categoryComponent;
        }

        public void Deactivate()
        {
            // _categoryComponent.ToAchievements.onClick.RemoveListener(OnClick);
        }

        public void Activate()
        {
            // _categoryComponent.ToAchievements.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            _context.ScreenChangerModel.SwitchScreen(ScreenType.Achievements);
        }
    }
}