using System.Collections.Generic;
using System.IO;
using Lib.fastJSON;
using UnityEngine;

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
            string sourceString = Resources.Load<TextAsset>(_path).text;
            
            return (Dictionary<string, object>) JSON.Parse(sourceString);
        }
    }
}