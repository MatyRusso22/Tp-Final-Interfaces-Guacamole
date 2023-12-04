using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleArrayController : MonoBehaviour
{
    public MoleController[] moles;

    public void setMinHeight(float newMinHeight){
        foreach (MoleController mole in moles){
            mole.setMinHeight(newMinHeight);
        }
    }
    public void setMaxHeight(float newMaxHeight){
        foreach (MoleController mole in moles){
            mole.setMaxHeight(newMaxHeight);
        }
    }

    public void moveMoleUp(int moleIndex){
        moles[moleIndex].moveMoleUp();
    }
    public void moveMoleDown(int moleIndex){
        moles[moleIndex].moveMoleDown();
    }

    public void spawnMole(int moleIndex){
        moles[moleIndex].spawnMole();
    }
    
    public int getMoleCount(){
        int count = 0;
        foreach (MoleController mole in moles){
            count++;
        }
        return count;
    }
}


