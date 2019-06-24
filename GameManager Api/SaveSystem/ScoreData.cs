using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScoreData 
{
  public float levelScore;// score with in a level
  public float gameScore;// score with in the game
  public float highScore;// high score of the level

  public int coins;

  public  ScoreData(ScoreManager SC)
  {
      levelScore = SC.getLevelScore();
      gameScore = SC.getGameScore();
      highScore = SC.getHighScore();
      coins = SC.getCoins();
  }

public void saveData()
{

}


public void loadDAta()
{
    
}
}
