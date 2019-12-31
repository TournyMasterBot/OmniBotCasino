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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
