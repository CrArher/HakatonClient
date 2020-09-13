using ScreenManager;

namespace Screens.Profile.Categories.Achievements
{
    public class AchievementsCategoryController : IController
    {
        private readonly ProfileContext _context;
        private readonly AchievementsCategoryModel _categoryModel;
        private readonly ProfileContainer _categoryComponent;

        public AchievementsCategoryController(ProfileContext context, AchievementsCategoryModel categoryModel, ProfileContainer categoryComponent)
        {
            _context = context;
            _categoryModel = categoryModel;
            _categoryComponent = categoryComponent;
        }

        public void Deactivate()
        {
            _categoryComponent.ArClick.onClick.RemoveListener(ClickAr);
            _categoryComponent.JavaClick.onClick.RemoveListener(ClickJava);
        }

        public void Activate()
        {
            _categoryComponent.ArClick.onClick.AddListener(ClickAr);
            _categoryComponent.JavaClick.onClick.AddListener(ClickJava);
        }

        private void ClickJava()
        {
            _context.CourseDetailsModel.Show(_context.References.JavaCourseDetails);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.ClassRoom);
        }

        private void ClickAr()
        {
            _context.CourseDetailsModel.Show(_context.References.ArCourseDetails);
            _context.ScreenChangerModel.SwitchScreen(ScreenType.ClassRoom);
        }
    }
}