using Commands;
using Notification;
using ScreenManager.ScreenChanger;
using Screens.AchievementScreen.Base;
using Screens.CourseDetails;
using UnityEngine;
using User;
using Utilities;

public interface IGlobalContext
{
    ScreenChangerModel ScreenChangerModel { get; set; }
    CommandModel CommandModel { get; set; }
    UserModel UserModel { get; set; }
    MonoBehaviour Mono { get; set; }
    Engine Engine { get; set; }
    AchievementsModel AchievementsModel { get; set; }
    References References { get; set; }
    ImageLoaderComponent ImageLoaderComponent { get; set; }

    NotificationModel NotificationModel { get; set; }
    CourseDetailsModel CourseDetailsModel { get; set; } 
}