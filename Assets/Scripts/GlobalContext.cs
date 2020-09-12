using Commands;
using ScreenManager.ScreenChanger;
using UnityEngine;
using User;
using Utilities;

namespace DefaultNamespace
{
    public class GlobalContext : IGlobalContext

    {
        public ScreenChangerModel ScreenChangerModel { get; set; }
        public CommandModel CommandModel { get; set; }
        public UserModel UserModel { get; set; }
        public MonoBehaviour Mono { get; set; }
        public Engine Engine { get; set; }
    }
}