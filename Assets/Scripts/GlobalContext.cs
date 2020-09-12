using Commands;
using Notification;
using ScreenManager.ScreenChanger;
using Screens.AchievementScreen.Base;
using UnityEngine;
using User;
using Utilities;

public class GlobalContext : IGlobalContext
{
    public ScreenChangerModel ScreenChangerModel { get; set; }
    public CommandModel CommandModel { get; set; }
    public UserModel UserModel { get; set; }
    public MonoBehaviour Mono { get; set; }
    public Engine Engine { get; set; }
    public AchievementsModel AchievementsModel { get; set; }
    public References References { get; set; }
    public NotificationModel NotificationModel { get; set; }
    public ImageLoaderComponent ImageLoaderComponent { get; set; }

    public GlobalContext()
    {
        
    }

    public GlobalContext(GlobalContext context)
    {
        References = context.References;
        AchievementsModel = context.AchievementsModel;
        Engine = context.Engine;
        Mono = context.Mono;
        UserModel = context.UserModel;
        CommandModel = context.CommandModel;
        ScreenChangerModel = context.ScreenChangerModel;
        NotificationModel = context.NotificationModel;
        ImageLoaderComponent = context.ImageLoaderComponent;
    }
}