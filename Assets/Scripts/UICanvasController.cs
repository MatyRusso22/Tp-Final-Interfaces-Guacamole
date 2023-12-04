using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasController : MonoBehaviour
{
    public Text counterText;
    public Text scoreText;
    public Text hiScoreText;
    public int scoreCount;
    public float hiScoreCount;
    private float counter;
    
    
    void Start()
    {
        if (PlayerPrefs.HasKey("HiScore")){
            hiScoreCount = PlayerPrefs.GetFloat("HiScore");
        }
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreCount > hiScoreCount){
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore",hiScoreCount);
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + hiScoreCount;
    }

    public float getCounter(){
        return counter;
    }

    public void setCounter(float value){
        counter = value;
    }

    public void decTime(){ 
        counterText.text = ((int)counter).ToString();
        counter -= Time.deltaTime;
    }
}
