using System;
using UnityEngine;
using UnityEngine.UI;

namespace FootMenu
{
    public class FootMenuComponent : MonoBehaviour
    {
        [NonSerialized]private ButtonFooter Current;
        
        public GameObject root;
        public ButtonFooter Profile;
        public ButtonFooter Shop;
        public ButtonFooter BattlePass;
        public ButtonFooter Directions;

        public void Show(ButtonFooter buttonFooter)
        {
            if (Current != null)
            {
                Current.Icon.color = Color.white;
            }
            Current = buttonFooter;
            Current.Icon.color = Color.green; 
        }
    }

    [Serializable]
    public class ButtonFooter
    {
        public Button Button;
        public Image Icon;
    }
}