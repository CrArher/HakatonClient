using System;

namespace Screens.Courses.Search
{
    public class SearchUnitModel
    {
        public event Action OnClick;
        public string Tag { get; }
        public bool IsEnable;
        public SearchUnitModel(string tag)
        {
            Tag = tag;
        }

        public void Click()
        {
            IsEnable = !IsEnable;
            OnClick?.Invoke();
        }
    }
}