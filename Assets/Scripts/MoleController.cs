using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    public Rigidbody mole;
    private float minHeight;
    private float maxHeight;

    public void setMinHeight(float newMinHeight){
        minHeight = newMinHeight;
    }

    public void setMaxHeight(float newMaxHeight){
        maxHeight = newMaxHeight;
    }

    public void spawnMole(){
        Instantiate(mole, transform.position, transform.rotation);
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
