using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Screens.AchievementScreen.Base
{
    public class AchievementUnitComponent : MonoBehaviour, IPointerClickHandler
    {
        public event Action Click;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke();
        }
    }
}