﻿using System.Collections.Generic;
using UnityEngine;

namespace ScreenManager
{
    public class GameScreens : MonoBehaviour, ISerializationCallbackReceiver
    {
        private Dictionary<ScreenType, GameObject> Roots = new Dictionary<ScreenType, GameObject>();
        [SerializeField] private List<ScreenComponent> windows;

        public GameObject this[ScreenType screen] => Roots[screen];

        public void OnBeforeSerialize()
        {
            
        }

        public void OnAfterDeserialize()
        {
            foreach (var window in windows)
            {
                Roots.Add(window.Type, window.Root);
            }
        }
    }
}