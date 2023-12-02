using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    private float counter;
    public Text counterText;
    public float getCounter(){
        return counter;
    }

    public void setCounter(float value){
        counter = value;
    }

    public void decTime(){ // Funcion q sirve para q decremente el tiempo en pantalla
        counterText.text = ((int)counter).ToString();
        counter -= Time.deltaTime;
    }
    
}

