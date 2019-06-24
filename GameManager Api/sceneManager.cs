using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public LevelLoader lvlLoader;


    public GameObject LoadScreen;
    public Slider progressBar;

public void start()
{
    //lvlLoader = GetComponent<LevelLoader>();
}


    public void LevelLoad(int index)
    {
        LoadScreen.SetActive(true);
        lvlLoader.loadLevel(index, progressBar);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
