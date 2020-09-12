using System;
using DefaultNamespace.FootMenu;
using PreviewSlider;
using UnityEngine;

namespace DefaultNamespace
{
    public class StartController : MonoBehaviour
    {
        [SerializeField] private GlobalContainer globalContainer;
        ControllerCollection _controllerCollection = new ControllerCollection();
        private GlobalContext _globalContext = new GlobalContext();
        private Generator _generator = new Generator();
        public void Start()
        {
            var controller = new PreviewSliderController(globalContainer.PreviewSliderContainer);
            controller.Activate();
            _generator.Add(new FootMenuGenerator());
            _generator.Generate(_globalContext,_controllerCollection,globalContainer);
        }
    }
}