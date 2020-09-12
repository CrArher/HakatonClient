using System.Collections.Generic;
using System.IO;
using GameLoad.DataLoad;
using Lib.fastJSON;

namespace Utilities.DataLoad
{
    public class JsonLoader : ILoader
    {
        private readonly string _path;

        public JsonLoader(string path)
        {
            _path = path;
        }
        
        public Dictionary<string, object> LoadData()
        {
            string sourceString = File.ReadAllText(_path);
            
            return (Dictionary<string, object>) JSON.Parse(sourceString);
        }
    }
}