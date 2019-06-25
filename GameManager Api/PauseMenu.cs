using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PauseMenu : MonoBehaviour
{
    private bool ispaused;
    public GameObject pauseMenuScreen;
    public GameObject settingsScreen;
    private sceneManager scenemanger;
    public  void Pause()
    {
        ispaused = true;
        Time.timeScale = 0f;
        pauseMenuScreen.SetActive(true);
    }
    public  void Resume(int val)
    {
        ispaused = false;
        StartCoroutine(Timer(val));
        pauseMenuScreen.SetActive(false);
        Time.timeScale = 1f;
        

    }
    
    public  void Quit()
    {
       Application.Quit();
    }
    public void LevelSelect(int index)
        {
           scenemanger.LevelLoad(index);
        }
    public void settings()
        {
           settingsScreen.SetActive(true);
        }

public bool getIspaused()
{
    return ispaused;
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
