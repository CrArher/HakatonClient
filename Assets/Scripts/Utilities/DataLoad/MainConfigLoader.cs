using System.Collections.Generic;
using Utilities.DataLoad;

namespace GameLoad.DataLoad
{
    public class MainConfigLoader : ILoader
    {
        private readonly string _path;
        private readonly string _applicationPath;

        public MainConfigLoader(string applicationPath, string path)
        {
            _applicationPath = applicationPath;
            _path = path;
        }
        
        public Dictionary<string, object> LoadData()
        {
            var resultData = new Dictionary<string, object>();
            var loader = new JsonLoader(_applicationPath + _path);
            var data = loader.LoadData();
            
            foreach (var item in data)
            {
                var path = (string)item.Value;
                var loaderItem = new JsonLoader(_applicationPath + path);
                var itemData = loaderItem.LoadData();
                resultData.Add(item.Key, itemData);
            }

            return resultData;
        }
    }
}