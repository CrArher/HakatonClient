using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Screens.Courses
{
    public class DirectionComponent : MonoBehaviour
    {
        public GameObject prefab;
        public RectTransform root;
        private List<GameObject> _gameObjects = new List<GameObject>();

        public DirectionUnitComponent CreateComponent()
        {
            var go = Instantiate(prefab, root);
            _gameObjects.Add(go);
            return go.GetComponent<DirectionUnitComponent>();
        }

        public void Clear()
        {
            foreach (var go in _gameObjects)
            {
                Destroy(go);
            }
            _gameObjects.Clear();
        }
    }
}