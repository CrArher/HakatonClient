using System.Collections.Generic;
using Utilities;

namespace Screens.BattlePass
{
    public class BattlePassDescription : IDescription
    {
        public string Sprite;
        public int Level;
        public string Requirement;
        public string Reward;
        public bool IsTaken;
        
        public BattlePassDescription(Dictionary<string,object> node)
        {
            Sprite = node.GetString("image");
            Level = node.GetInt("lvl");
            Requirement = node.GetString("requirement");
            Reward = node.GetString("description");
            IsTaken = node.GetBool("IsTaken");
        }
    }
}