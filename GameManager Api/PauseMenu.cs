using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PauseMenu : MonoBehaviour
{
    private bool ispaused;
    
    public  void Pause()
    {
        //tabs
    }
    public  void Resume()
    {
        //tabs

    }
    
    public  void Quit()
    {
        //tabs
    }
    public void LevelSelect()
        {
            Debug.Log("Define this method if needed ");
        }
    public void settings()
        {
            Debug.Log("Define this method if needed ");
        }



public void countDown(int val)
{
    StartCoroutine(Timer(val));
}

    IEnumerator Timer(int val)
    {

         int count = val;
        while(count>=0)
        { 
           
            yield return new WaitForSeconds(count);
            Debug.Log(count);
            count--;
        }
    }
}
