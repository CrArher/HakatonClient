namespace Screens.BattlePass
{
    public class BattlePassContext : GlobalContext
    {
        public BattlePassContext(GlobalContext context) : base(context)
        {
            
        }

        public BattlePassModel BattlePassModel { get; set; }
    }
}