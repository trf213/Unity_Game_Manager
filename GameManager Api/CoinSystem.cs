using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CoinSystem : MonoBehaviour
{
   public int coins;

   public virtual void setCoin(int val)
   {
       coins = val;
   }

   public virtual int getCoin()
   {
      return coins;
   }
   public void updateCoin()
   {
      Debug.Log("cha");
   }


}
