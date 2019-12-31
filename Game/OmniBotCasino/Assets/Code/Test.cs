using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var testString = OmniBot.Casino.Game.Interface.Test.TestMethod();
        Debug.Log(testString);
        var testCards = OmniBot.Casino.Game.Interface.Cards.GetStandardDeckAceLow();
        foreach(var card in testCards)
        {
            Debug.Log($@"Card Name: {card.CardName}, Card Value: {card.CardValue}, Suit Name: {card.SuitName}, Suit Value: {card.SuitValue}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
