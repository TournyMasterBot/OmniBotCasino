using OmniBot.Casino.Core.Helpers;
using OmniBot.Casino.Core.Models.CardModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniBot.Casino.Core.Interop
{
    public static class CardInterop
    {
        public static CardModel[] GetStandardDeck(bool aceHigh)
        {
            return CardHelper.GetStandardCardDeck(aceHigh);
        }
    }
}
