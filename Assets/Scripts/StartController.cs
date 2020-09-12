using System;
using FootMenu;
using Notification;
using PreviewSlider;
using ScreenManager;
using ScreenManager.ScreenChanger;
using Screens.AchievementScreen.Base;
using UnityEngine;
using Utilities.DataLoad;

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
        _generator.Add(new ReferencesGenerator());
        _generator.Add(new ScreenChangerGenerator());
        _generator.Add(new FootMenuGenerator());
        _generator.Add(new AchievementsGenerator());
        _generator.Add(new NotificationGenerator());
        _generator.Generate(_globalContext,_controllerCollection,globalContainer);
        _controllerCollection.Activate();
        _globalContext.ScreenChangerModel.SwitchScreen(ScreenType.Profile);
    }
}