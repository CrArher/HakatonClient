using System.Collections.Generic;
using UnityEngine;

namespace Screens.Courses.Search
{
    public class SearchComponent : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform root;

        private readonly List<GameObject> _gameObjects = new List<GameObject>();

        public SearchUnitComponent Create()
        {
            var go = Instantiate(prefab, root);
            _gameObjects.Add(go);
            return go.GetComponent<SearchUnitComponent>();
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