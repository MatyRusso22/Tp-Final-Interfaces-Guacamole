using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    public Rigidbody mole;
    private Rigidbody spawnedMole;
    private float minHeight;
    private float maxHeight;
    private bool moleHasBeenSpawned = false;

    public void setMinHeight(float newMinHeight){
        minHeight = newMinHeight;
    }

    public void setMaxHeight(float newMaxHeight){
        maxHeight = newMaxHeight;
    }

    public void spawnMole(){
        if (!moleHasBeenSpawned){
            spawnedMole = Instantiate(mole, transform.position, transform.rotation);
            setMoleState();
            Destroy(spawnedMole.gameObject, 2);
            Invoke("setMoleState", 2);
        }
    }

    private void setMoleState(){
        moleHasBeenSpawned = !moleHasBeenSpawned;
    }
    
    public void moveMoleUp()
    {
        Vector3 newPosition = new Vector3(mole.position.x, maxHeight, mole.position.z);
        mole.MovePosition(newPosition);
    }

    public void moveMoleDown()
    {
        Vector3 newPosition = new Vector3(mole.position.x, minHeight, mole.position.z);
        mole.MovePosition(newPosition);
    }
}
