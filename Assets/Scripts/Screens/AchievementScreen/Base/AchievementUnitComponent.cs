using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Screens.AchievementScreen.Base
{
    public class AchievementUnitComponent : MonoBehaviour, IPointerClickHandler
    {
        public event Action Click;
        
        [SerializeField] private Image icon;
        [SerializeField] private CanvasGroup canvasGroup;
        
        public void SetIcon(Sprite sprite, bool enable)
        {
            icon.sprite = sprite;
            canvasGroup.alpha = enable ? 1 : 0.5f;
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke();
        }
    }
}