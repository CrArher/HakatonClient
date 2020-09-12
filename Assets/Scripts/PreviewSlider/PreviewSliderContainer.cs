using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PreviewSlider
{
    public class PreviewSliderContainer : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Sprite[] _sprites;
        public TextMeshProUGUI TextButton;
        public int IndexItem = 0;
        public Button NextButton;
        public int MaxCount;
        
        public void Next()
        {
            _image.sprite = _sprites[IndexItem];
        }
    }
}