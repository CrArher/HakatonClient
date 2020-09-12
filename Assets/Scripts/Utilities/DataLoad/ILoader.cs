using System.Collections.Generic;

namespace Utilities.DataLoad
{
    public interface ILoader
    {
        Dictionary<string, object> LoadData();
    }
}