using UnityEngine;

namespace Utilities.DataLoad
{
    public class ReferencesGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var data = new MainConfigLoader(Application.dataPath + "/Resources/Json/", "main_config.json");
            var rawData = data.LoadData();
            context.References = new References(rawData, new Factory());
        }
    }
}