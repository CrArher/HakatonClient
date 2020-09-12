using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Screens.AchievementScreen.AchievementDetailsDialog
{
    public class AchievementDetailsDialogComponent : MonoBehaviour
    {
        [SerializeField] private GameObject root;
        public Button CloseButton;
        [SerializeField] private Image _icon;
        public TextMeshProUGUI Name;
        public TextMeshProUGUI Desciption;
        public TextMeshProUGUI State;
        
        public void Show(Sprite icon)
        {
            _icon.sprite = icon;
            root.SetActive(true);
        }

        public void Hide()
        {
            root.SetActive(false);
        }
    }
}