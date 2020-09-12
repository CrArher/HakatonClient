using System;
using PreviewSlider;
using UnityEngine;

namespace DefaultNamespace
{
    public class StartController : MonoBehaviour
    {
        [SerializeField] private GlobalContainer globalContainer;

        public void Start()
        {
            var controller = new PreviewSliderController(globalContainer.PreviewSliderContainer);
            controller.Activate();
        }
    }
}