using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicController : MonoBehaviour
{
    private bool gameStart;
    public MoleArrayController moleArray;
    private ButtonController button;
    private CounterController counter;
    private float timeUntilNextMole;
    public float initialCounter;
    public float minTimeBetweenMoles;
    public float maxTimeBetweenMoles;
    public float movespeed;
    public float maxHeight;
    public float minHeight;
    // Start is called before the first frame update
    void Start()
    {
        gameStart = false;
        //moleArray = GameObject.FindGameObjectWithTag("table").GetComponent<MoleArrayController>();
        button = GameObject.FindGameObjectWithTag("button").GetComponent<ButtonController>();
        counter = GameObject.FindGameObjectWithTag("counter").GetComponent<CounterController>();
        counter.setCounter(initialCounter);
        setTimeUntilNextMole();
        timeUntilNextMole += 1;
        moleArray.setMinHeight(minHeight);
        moleArray.setMaxHeight(maxHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            //counter
            if (counter.getCounter() > 0){
                counter.decTime();
                timeUntilNextMole -= Time.deltaTime;
            } else {
                counter.setCounter(initialCounter);
                foreach (MoleController mole in moleArray.moles){
                    mole.moveMoleDown();
                }
                gameStart = false;
            }
            //moles
            if (timeUntilNextMole < 0){
                Debug.Log("timeUntilNextMole < 0");
                itsMoleTime();
                setTimeUntilNextMole();
            }
        }
    }

    private void setTimeUntilNextMole(){
        timeUntilNextMole = Random.Range(minTimeBetweenMoles,maxTimeBetweenMoles);
        Debug.Log("time until next mole is " + timeUntilNextMole.ToString());
    }

    public void itsMoleTime()
    {
        Debug.Log("It's mole time.");
        int randomNumber = Random.Range(0,3);
        moleArray.spawnMole(randomNumber);
        setTimeUntilNextMole();
    }

    public void StartGame()
    {
        gameStart = true;
    }
}
