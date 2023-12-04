using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleKiller : MonoBehaviour
{
    private UICanvasController ui;
    public MoleArrayController spawner;
    private AudioSource audioSource;
    void Start(){
        ui = GameObject.FindGameObjectWithTag("uiCanvas").GetComponent<UICanvasController>();
        audioSource = GameObject.FindGameObjectWithTag("moleSpawnerController").GetComponent<AudioSource>();
    }
    public void killMole(){

        audioSource.PlayOneShot(audioSource.clip, Random.Range(0.75f, 1));
        ui.scoreCount++;
        Destroy(gameObject);
    }
    
}
