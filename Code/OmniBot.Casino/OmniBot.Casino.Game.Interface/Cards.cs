using OmniBot.Casino.Core.Interop;
using OmniBot.Casino.Core.Models.CardModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniBot.Casino.Game.Interface
{
    public static class Cards
    {
        public static CardModel[] GetStandardDeckAceLow()
        {
            return CardInterop.GetStandardDeck(aceHigh: false);
        }

        public static CardModel[] GetStandardDeckAceHigh()
        {
            return CardInterop.GetStandardDeck(aceHigh: true);
        }
    }
}
