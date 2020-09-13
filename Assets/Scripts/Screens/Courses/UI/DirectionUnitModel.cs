using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Screens.Courses
{
    public class DirectionUnitModel
    {
        public event Action OnShow;
        public event Action OnHide;

        public DirectionDescription DirectionDescription;

        public DirectionUnitModel(DirectionDescription description)
        {
            DirectionDescription = description;
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }

        public void Show()
        {
            OnShow?.Invoke();
        }
    }
}