using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskFirst
{
    class ConditionManager
    {
        /// <summary>
        /// All states for player
        /// </summary>
        public List<PlayerState> allState = new List<PlayerState>()
        {
            new PlayerState { Name = "isHungry",  CurrentProperty = Property.Debuff, IsActiveted = false },
            new PlayerState { Name = "isBleeding", CurrentProperty = Property.Debuff, IsActiveted = false },
            new PlayerState { Name = "isDrowning", CurrentProperty = Property.Debuff, IsActiveted = false },
            new PlayerState { Name = "isEating", CurrentProperty = Property.Debuff, IsActiveted = false, dropStateName = new List<string>() { "isHungry" } },
            new PlayerState { Name = "isBandaged", CurrentProperty = Property.Debuff, IsActiveted = false, dropStateName = new List<string>() { "isBleeding"} }
        };
        public List<PlayerState> currentPlayerStates = new List<PlayerState>()
        {

        };
        /*
         * Игрок голоден - дебаф
         * Игрок ест - баф
         * Когда он ест, дебаф -голод должен отключиться
         */
        public async void ChangePlayerState()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    currentPlayerStates.AddRange(allState.FindAll(x => x.IsActiveted == true)) ;
                    currentPlayerStates.RemoveAll(x => x.IsActiveted == false);
                }
            });
        } 
    }
}
