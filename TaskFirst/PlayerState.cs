using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFirst
{
    public class PlayerState 
    {
        /// <summary>
        /// State name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// is state active
        /// </summary>
        public bool IsActiveted { get; set; }

        /// <summary>
        /// Current propety for state
        /// </summary>
        public Property CurrentProperty { get; set; }
        public List<string> dropStateName { get; set; }
        public void ChangeActive()
        {
            if (IsActiveted)
            {
                IsActiveted = !IsActiveted;
            }
        }
        /// <summary>
        /// We get current list player states and remove all states which equals dropStateName
        /// </summary>
        /// <param name="currentPlayerStates"></param>
        public void DropState(List<PlayerState> currentPlayerStates)
        {
            for (int i = 0; i < currentPlayerStates.Count; i++)
            {
                for (int j = 0; i < dropStateName.Count; i++)
                {
                    currentPlayerStates.RemoveAll(x => x.Name == dropStateName[j]);
                }
            }
            //найти все обьекты у которых name будет равен dropStateName
        }
    }
    /// <summary>
    /// Property state for player 
    /// buff or debuff
    /// </summary>
    public enum Property
    {
        Buff,
        Debuff
    }
}
