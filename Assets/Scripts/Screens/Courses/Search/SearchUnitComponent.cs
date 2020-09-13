using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Screens.Courses.Search
{
    public class SearchUnitComponent : MonoBehaviour, IPointerClickHandler
    {
        public event Action Click;

        public TextMeshProUGUI NameTag;
        public Image Icon;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke();
        }
    }
}