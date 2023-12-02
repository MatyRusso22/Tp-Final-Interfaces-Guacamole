using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    public Rigidbody[] arrayTopos;
    public float movespeed = 1;
    public float maxHeight = 1;
    public float minHeight = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void moverTopoArriba(int indexTopo)
    {
        if (arrayTopos[indexTopo].transform.position.y < maxHeight)
        {
            arrayTopos[indexTopo].transform.position += (Vector3.up * movespeed) * Time.deltaTime;
        }
    }

    void moverTopoAbajo(int indexTopo)
    {
        if (arrayTopos[indexTopo].transform.position.y > minHeight)
        {
            arrayTopos[indexTopo].transform.position += (Vector3.down * movespeed * 2) * Time.deltaTime;
        }
    }

    public void moverTopoRandom()
    {
        int randomNumber = Random.Range(0,3);
        moverTopoArriba(randomNumber);
    }
}