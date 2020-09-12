using System.Collections.Generic;
using UnityEngine;

namespace Utilities
{
    public class ImageLoaderComponent : MonoBehaviour
    {
        [SerializeField]private Sprite[] sprites;
        
        private readonly Dictionary<string, Sprite> _icons = new Dictionary<string, Sprite>();

        public Sprite Get(string id)
        {
            return _icons[id];
        }

        public void Init()
        {
            foreach (var sprite in sprites)
            {
                _icons.Add(sprite.name, sprite);
            }
        }

    }
}