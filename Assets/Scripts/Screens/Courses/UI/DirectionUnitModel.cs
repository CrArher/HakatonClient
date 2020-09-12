using System.Collections.Generic;
using System.Security.Cryptography;

namespace Screens.Courses
{
    public class DirectionUnitModel
    {
        public DirectionDescription DirectionDescription;

        public DirectionUnitModel(DirectionDescription description)
        {
            DirectionDescription = description;
        }
    }
}