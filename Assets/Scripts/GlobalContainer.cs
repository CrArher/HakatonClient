using DefaultNamespace.FootMenu;
using PreviewSlider;
using ScreenManager;
using ScreenObserver;
using UnityEngine;

namespace DefaultNamespace
{
    public class GlobalContainer : MonoBehaviour
    {
        public GameScreens GameScreens;
        public PreviewSliderContainer PreviewSliderContainer;
        public FootMenuComponent FootComponent;
        public ScreensContainer ScreensContainer;
    }
}