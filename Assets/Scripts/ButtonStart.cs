using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;


public class ButtonStart : MonoBehaviour
{
    bool gameStart;
    float counter;
    public Text counterText;
    public topos toposScript;
    // Start is called before the first frame update
    void Start()
    {
        toposScript = GameObject.FindGameObjectWithTag("mesa").GetComponent<topos>();
        gameStart = false;
        counter = 5;
    }

    

    // Update is called once per frame
    void Update()
    {
        counterText.text = ((int)counter).ToString();
        if (gameStart)
        {
            counter -= Time.deltaTime;
            if (counter < 0)
            {
                gameStart = false;
                counter = 5;
            }
        }
    }

    public void Empezar()
    {
        toposScript.moverTopoRandom();
        gameStart = true;
    }
}
