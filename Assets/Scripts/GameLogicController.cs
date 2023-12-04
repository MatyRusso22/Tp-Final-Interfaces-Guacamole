using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicController : MonoBehaviour
{
    private bool gameStart;
    public MoleArrayController moleArray;
    public UICanvasController ui;
    private ButtonController button;
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
        button = GameObject.FindGameObjectWithTag("button").GetComponent<ButtonController>();
        ui = GameObject.FindGameObjectWithTag("uiCanvas").GetComponent<UICanvasController>();
        ui.setCounter(initialCounter);
        setTimeUntilNextMole();
        moleArray.setMinHeight(minHeight);
        moleArray.setMaxHeight(maxHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            //counter
            if (ui.getCounter() > 0.9){
                ui.decTime();
                timeUntilNextMole -= Time.deltaTime;
            } else {
                ui.setCounter(initialCounter);
                foreach (MoleController mole in moleArray.moles){
                    mole.moveMoleDown();
                }
                gameStart = false;
            }
            //moles
            if (timeUntilNextMole < 0){
                itsMoleTime();
                setTimeUntilNextMole();
            }
        }
    }

    private void setTimeUntilNextMole(){
        timeUntilNextMole = Random.Range(minTimeBetweenMoles,maxTimeBetweenMoles);
    }

    public void itsMoleTime()
    {
        int randomNumber = Random.Range(0,moleArray.getMoleCount());
        moleArray.spawnMole(randomNumber);
        setTimeUntilNextMole();
    }

    public void StartGame()
    {
        if (!gameStart){
            gameStart = true;
            ui.scoreCount = 0;
        }
    }
}

