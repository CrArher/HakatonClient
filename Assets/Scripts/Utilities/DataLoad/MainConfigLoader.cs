using System.Collections.Generic;

namespace Utilities.DataLoad
{
    public class MainConfigLoader : ILoader
    {
        private readonly string _path;

        public MainConfigLoader(string path)
        {
            _path = path;
        }
        
        public Dictionary<string, object> LoadData()
        {
            var resultData = new Dictionary<string, object>();
            var loader = new JsonLoader(_path);
            var data = loader.LoadData();
            
            foreach (var item in data)
            {
                var path = (string)item.Value;
                var loaderItem = new JsonLoader(path);
                var itemData = loaderItem.LoadData();
                resultData.Add(item.Key, itemData);
            }

            return resultData;
        }
    }
}