using System;
using System.Collections.Generic;
using OmniBot.Casino.Core.Models.CardModels;
using static OmniBot.Casino.Core.Constants;

namespace OmniBot.Casino.Core.Helpers
{
    internal static class CardHelper
    {
        internal static CardModel[] GetStandardCardDeck(bool aceHigh)
        {
            var cardList = new List<CardModel>();
            
            foreach(CardSuit suit in Enum.GetValues(typeof(Constants.CardSuit)))
            {
                if(suit != 0)
                {
                    foreach (StandardDeckAceHigh card in Enum.GetValues(typeof(Constants.StandardDeckAceLow)))
                    {
                        if(card != 0)
                        {
                            cardList.Add
                            (
                                new CardModel()
                                {
                                    CardName = Enum.GetName(typeof(StandardDeckAceLow), (int)card),
                                    CardValue = card,
                                    SuitName = Enum.GetName(typeof(FourCardSuitColor), (int)suit),
                                    SuitValue = suit
                                }
                            );
                        }
                    }
                }
            }
            return cardList.ToArray();
        }
    }
}
