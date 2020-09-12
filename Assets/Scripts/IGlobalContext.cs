using Commands;
using ScreenManager.ScreenChanger;
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
}