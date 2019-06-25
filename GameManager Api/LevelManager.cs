using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelManager : MonoBehaviour
{

    //miscellaneous
    private bool isLevelCompleted;
    private int enemyCount;
    private bool isPlayerDead;
  
    private float inGameTime;


    //Pause Menu 
    private PauseMenu pauseMenu;
    private bool isPaused;


    //Score Managers
    private ScoreManager scoreManager;


    private sceneManager sceneLoader;

    private Player player;
     
     //Wave Spawner
}
