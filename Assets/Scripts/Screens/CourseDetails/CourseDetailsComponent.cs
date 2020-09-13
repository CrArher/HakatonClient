using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Screens.CourseDetails
{
    public class CourseDetailsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        
        private readonly List<GameObject> _gameObjects = new List<GameObject>();
        public Text Count; 
        public Text Count2; 
        public Text Rating; 
        public Button Close; 
        
        public CourseDetailsUnitComponent Create()
        {
            var go = Instantiate(prefab, transform);
            _gameObjects.Add(go);
            return go.GetComponent<CourseDetailsUnitComponent>();
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