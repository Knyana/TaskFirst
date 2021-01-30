using System;
using System.Collections.Generic;
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
        ///  Current rank for state
        /// </summary>
        public Rank CurrentRank { get; set; }
        /// <summary>
        /// Current propety for state
        /// </summary>
        public Property CurrentProperty { get; set; }

        public void ChangeActive()
        {
            if (IsActiveted)
            {
                IsActiveted = !IsActiveted;
            }
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
    /// <summary>
    /// Rank state for player  simple middle high
    /// </summary>
    public enum Rank
    {
        SimpleRank,
        MiddleRank,
        HighRank
    }
}
