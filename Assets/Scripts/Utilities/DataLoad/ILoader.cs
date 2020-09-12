using System.Collections.Generic;

namespace GameLoad.DataLoad
{
    public interface ILoader
    {
        Dictionary<string, object> LoadData();
    }
}