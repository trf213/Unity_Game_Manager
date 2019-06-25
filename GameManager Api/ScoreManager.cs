/*
Author: Tabari Rudder-Fields 

Date: 20 May 2019 

Purpose: This is a  class that was meant to be inherited and over ridden 

Changes: should be done with // and the intials of the author 


 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{


  public float levelScore;// score with in a level
  public float gameScore;// score with in the game
  public float highScore;// high score of the level
  public CoinSystem coinSystem;





/*GET and SET functions for Level Score  */
  protected virtual void setLevelScore(int val)
  {
      levelScore = val;
  }

   public virtual float  getLevelScore()
  {
     return levelScore;
  }

  /*GET and SET functions for Game Score  */
  public virtual void setGameScore(int val)
  {
      gameScore = val;
  }

   public virtual float getGameScore()
  {
     return gameScore;
  }


 /*GET and SET functions for High Score  */

  protected virtual void  setHighScore(int val)
  {
      highScore = val;
  }

   public virtual float getHighScore()
  {
     return highScore;
  }


  protected void clearlevelScore()
  {
    levelScore = 0;
  }
  protected void clearHighScore()
  {
    highScore = 0;
  }


  public virtual void increaselevelScore(int val)
  {
      levelScore += val;
  }
  public virtual void decreaselevelScore(int val)
  {
      levelScore -= val;
  }

   public virtual void increaseGameScore()
   {
     Debug.Log("Calc coin");
   }
  public virtual void decreaseGameScore()
  {
    Debug.Log("Calc coin");
  }


  public virtual void calcCoin()
  {
    Debug.Log("Calc coin");
  }

  public int getCoins()
  {
    return coinSystem.getCoin();
  }

  public void saveData()
{
 SaveSystem.SaveScore(this);
}


public void loadData()
{
  ScoreData data = SaveSystem.LoadScore();
   levelScore = data.levelScore;// score with in a level
  gameScore = data.gameScore;// score with in the game
  highScore = data.highScore;// high score of the level
 coinSystem.setCoin(data.coins);
    
}



}
