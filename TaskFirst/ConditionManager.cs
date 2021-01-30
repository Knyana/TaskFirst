using System.Collections.Generic;

namespace TaskFirst
{
    class ConditionManager
    {
        /// <summary>
        /// All states for player
        /// </summary>
        public List<PlayerState> allState = new List<PlayerState>()
        {
            new PlayerState() { Name = "isHungry", CurrentRank = Rank.HighRank, CurrentProperty = Property.Debuff, IsActiveted = false  },
            new PlayerState() { Name = "isBleeding", CurrentRank = Rank.MiddleRank, CurrentProperty = Property.Debuff, IsActiveted = false },
            new PlayerState() { Name = "isDrowning", CurrentRank = Rank.HighRank, CurrentProperty = Property.Debuff, IsActiveted = false }
        };
        public List<PlayerState> intermediatePlayerConditions = new List<PlayerState>()
        {

        };
        public List<PlayerState> currentPlayerConditions = new List<PlayerState>()
        {

        };
        public void AddConditions()
        {
            for (int i = 0; i < intermediatePlayerConditions.Count; i++)
            {

            }
            
        }
        public void ChangePlayerConditions()
        {
            foreach (PlayerState item in allState)
            {
                if (item.IsActiveted)
                {
                    intermediatePlayerConditions.AddRange(allState);
                }
            }
            foreach (PlayerState item in intermediatePlayerConditions)
            {
                if (item.IsActiveted == false) 
                {
                    intermediatePlayerConditions.Remove(item);
                }
            }
        }
        
    }
}
