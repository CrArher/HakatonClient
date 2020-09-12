using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Screens.AchievementScreen.Base
{
    public class AchievementComponent : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform root;
        public Button CloseButton;
        private readonly List<GameObject> _gameObjects = new List<GameObject>();
        
        public AchievementUnitComponent Create()
        {
            var go = Instantiate(prefab, root);
            _gameObjects.Add(go);
            return go.GetComponent<AchievementUnitComponent>();
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