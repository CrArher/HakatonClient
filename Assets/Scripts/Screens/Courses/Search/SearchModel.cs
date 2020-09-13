using System;
using System.Collections.Generic;

namespace Screens.Courses.Search
{
    public class SearchModel
    {
        private List<SearchUnitModel> _unitModels = new List<SearchUnitModel>();

        
        public SearchModel()
        {
            foreach (var tag in GetTags())
            {
                _unitModels.Add(new SearchUnitModel(tag));
            }   
        }

        public IEnumerable<SearchUnitModel> GetAll()
        {
            foreach (var unitModel in _unitModels)
            {
                yield return unitModel;    
            }
        }

        private IEnumerable<string> GetTags()
        {
            yield return "Java";
            yield return "Android";
        }
    }
}