using System.Collections.Generic;

namespace Utilities
{
    public class DescriptionCollection<T> where T : IDescription
    {
        private readonly Dictionary<string, T> _items;
        
        public DescriptionCollection()
        {
            _items = new Dictionary<string, T>();
        }
        
        public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public T Get(string key)
        {
           return _items[key];
        }

        public void Add(string key, T value)
        {
            _items.Add(key, value);
        }
    }
}