using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ButtonController : MonoBehaviour
{
    private GameLogicController gameLogic;
    // Start is called before the first frame update
    void Start()
    {
        gameLogic=GameObject.FindGameObjectWithTag("gamelogic").GetComponent<GameLogicController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
