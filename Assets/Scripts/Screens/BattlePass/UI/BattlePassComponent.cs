using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Screens.BattlePass
{
    public class BattlePassComponent : MonoBehaviour
    {
        public TMP_Text Requirement;
        public TMP_Text Reward;
        public RectTransform root;
        public GameObject prefab;
        private List<GameObject> _gameObjects = new List<GameObject>();

        public BattlePassUnitComponent CreateComponent()
        {
            var go = Instantiate(prefab, root);
            _gameObjects.Add(go);
            return go.GetComponent<BattlePassUnitComponent>();
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