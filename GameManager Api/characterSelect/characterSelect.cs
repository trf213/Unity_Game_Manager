using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSelect : MonoBehaviour
{
    public int index;
   public  Character[] mycharacteList;
   
   private int indexCheck;

  
   public int Range()
   {
       if ( mycharacteList.Length <= 0 )
          Debug.Log("May want to populate me");
       return mycharacteList.Length;
   }

   public int select()
    {
        if(index == 0)
        return 0;

         return mycharacteList[indexCheck].getIndex();
    }

   public void nextRight()
   {
        if(index == 0)
        return ;
     if(indexCheck == mycharacteList.Length)
     {
         indexCheck = 0;
     }
     else {indexCheck++;}

   }

   public void nextLeft()
   {
           if(index == 0)
        return ;
     if(indexCheck == mycharacteList.Length)
     {
         indexCheck = 0;
     }
     else {indexCheck++;}
   }

   public void setSelect(int val)
   {
       indexCheck = val;

   }
}
