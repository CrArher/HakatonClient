using UnityEngine;

namespace Utilities.DataLoad
{
    public class ReferencesGenerator : IGenerator
    {
        public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
        {
            var data = new MainConfigLoader("Json/main_config");
            var rawData = data.LoadData();
            context.References = new References(rawData, new Factory());
        }
    }
}