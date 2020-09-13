using ScreenObserver;
using Screens.Courses.Categories;
using Screens.Courses.Search;
using Screens.Courses.ShowMore;
using UnityEngine;

namespace Screens.Courses
{
    public class DirectionsContainer : MonoBehaviour,ISceneContainer
    {
        public DirectionComponent DirectionComponent;
        public ShowMoreComponent ShowMoreComponent;
        public SearchComponent SearchComponent;
        public CategoriesComponent CategoriesComponent;
    }
}