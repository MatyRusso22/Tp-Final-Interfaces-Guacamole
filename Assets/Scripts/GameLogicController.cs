using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicController : MonoBehaviour
{
    private bool gameStart;
    private MoleController moles;
    private ButtonController button;
    private CounterController counter;
    // Start is called before the first frame update
    void Start()
    {
        gameStart = false;
        moles = GameObject.FindGameObjectWithTag("table").GetComponent<MoleController>();
        button = GameObject.FindGameObjectWithTag("button").GetComponent<ButtonController>();
        counter = GameObject.FindGameObjectWithTag("counter").GetComponent<CounterController>();
        counter.setCounter(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            if (counter.getCounter() > 0){
                counter.decTime();
            } else {
                counter.setCounter(5);
                gameStart = false;
            }
            
        }
    }

    public void StartGame()
    {
        gameStart = true;
    }
}
