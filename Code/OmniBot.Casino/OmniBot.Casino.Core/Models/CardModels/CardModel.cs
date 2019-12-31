using System;
using System.Collections.Generic;
using System.Text;
using static OmniBot.Casino.Core.Constants;

namespace OmniBot.Casino.Core.Models.CardModels
{
    public class CardModel
    {
        public string CardName { get; set; }
        public StandardDeckAceHigh CardValue { get; set; }
        public string SuitName { get; set; }
        public CardSuit SuitValue { get; set; }
    }
}
