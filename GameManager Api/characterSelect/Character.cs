using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   private int index;
   private bool isUnlocked;
   private int price;



   
  public bool getisUnlocked()
  {
      return isUnlocked;
  }
    public void setisUnlocked(bool val)
  {
   isUnlocked = val;
  }
   public int getIndex()
   {
       return index;
   }

   public int getprice()
   {
     return price;
   }
}
