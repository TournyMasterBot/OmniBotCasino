using System;
using System.Collections.Generic;
using System.Text;

namespace OmniBot.Casino.Core
{
    public class Constants
    {
        /// <summary>
        /// This enum must match FourCardSuitColor
        /// </summary>
        public enum CardSuit
        {
            Invalid = 0,
            Spade = 1,
            Club = 2,
            Heart = 3,
            Diamond = 4
        }

        /// <summary>
        /// This enum must match CardSuit
        /// </summary>
        public enum FourCardSuitColor
        {
            Invalid = 0,
            Black = 1,
            Green = 2,
            Red = 3,
            Blue = 4
        }

        public enum StandardDeckAceLow
        {
            Invalid = 0,
            Ace = 1,
            One = 2,
            Two = 3,
            Three = 4,
            Four = 5,
            Five = 6,
            Six = 7,
            Seven = 8,
            Eight = 9,
            Nine = 10,
            Ten = 11,
            Jack = 12,
            Queen = 13,
            King = 14
        }

        public enum StandardDeckAceHigh
        {
            Invalid = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }
    }
}
