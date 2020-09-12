using UnityEngine;
using UnityEngine.UI;

namespace Screens.AchievementScreen.AchievementDetailsDialog
{
    public class AchievementDetailsDialogComponent : MonoBehaviour
    {
        [SerializeField] private GameObject root;
        public Button CloseButton;
        
        public void Show()
        {
            root.SetActive(true);
        }

        public void Hide()
        {
            root.SetActive(false);
        }
    }
}