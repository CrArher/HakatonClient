using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Screens.Courses.Categories
{
    public class CategoriesComponent : MonoBehaviour
    {
        public TMP_Dropdown Dropdown;
        
        public IEnumerable<DirectionCategories> GetCategories()
        {
            yield return DirectionCategories.GameDeveloper;
            yield return DirectionCategories.SysAdmin;
        }    
    }
}