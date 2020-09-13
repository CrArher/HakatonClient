using TMPro;

namespace Screens.Courses.Categories
{
    public class CategoriesController : IController
    {
        private readonly DirectionsContext _context;
        private readonly CategoriesComponent _component;

        public CategoriesController(DirectionsContext context, CategoriesComponent component)
        {
            _context = context;
            _component = component;
        }

        public void Deactivate()
        {
        }

        public void Activate()
        {
            foreach (var directionCategory in _component.GetCategories())
            {
                _component.Dropdown.options.Add(new TMP_Dropdown.OptionData(
                    directionCategory == DirectionCategories.GameDeveloper
                        ? "Разработчик игр"
                        : "Системный администратор"));
            }
            
            _component.Dropdown.onValueChanged.AddListener(ChangeCategory);
        }

        private void ChangeCategory(int arg0)
        {
            if (arg0 ==0)
            {
                foreach (var unitModel in _context.DirectionModel.UnitModels)
                {
                    if (unitModel.DirectionDescription.Tags.Contains("Java")||unitModel.DirectionDescription.Tags.Contains("Unity"))
                    {
                        unitModel.Show();
                    }
                    else
                    {
                        unitModel.Hide();
                    }
                }
            }
            else
            {
                foreach (var unitModel in _context.DirectionModel.UnitModels)
                {
                    if (unitModel.DirectionDescription.Tags.Contains("Админ"))
                    {
                        unitModel.Show();
                    }
                    else
                    {
                        unitModel.Hide();
                    }
                }
            }
        }
    }
}