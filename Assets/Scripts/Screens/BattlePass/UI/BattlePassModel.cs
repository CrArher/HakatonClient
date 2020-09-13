using System;
using System.Collections.Generic;
using Utilities;

namespace Screens.BattlePass
{
    public class BattlePassModel
    {
        public event Action<string> OnSetRequirement;
        public event Action<string> OnSetReward; 
        public List<BattlePassUnitModel> UnitModels = new List<BattlePassUnitModel>();

        public BattlePassModel(DescriptionCollection<BattlePassDescription> descriptionCollection)
        {
            foreach (var description in descriptionCollection)
            {
                UnitModels.Add(new BattlePassUnitModel(description.Value));
            }
        }

        public void SetRequirement(string requirement)
        {
            OnSetRequirement?.Invoke(requirement);
        }

        public void SetReward(string reward)
        {
            OnSetReward?.Invoke(reward);
        }
    }
}