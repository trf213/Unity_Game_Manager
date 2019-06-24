﻿using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{


public static void SaveScore(ScoreManager SC)
{
 BinaryFormatter format = new BinaryFormatter();
 string path = Application.persistentDataPath + "/Scoremanager.trf";
 FileStream stream = new FileStream(path, FileMode.Create);

 ScoreData data = new ScoreData(SC);

 format.Serialize(stream, data);
 stream.Close();

}


public static ScoreData LoadScore()
{
    
     string path = Application.persistentDataPath + "/Scoremanager.trf";

     if(File.Exists(path))
     {
         BinaryFormatter format = new BinaryFormatter();
         FileStream stream = new FileStream(path, FileMode.Open);

        ScoreData data = format.Deserialize(stream) as ScoreData;
        stream.Close();
        return data;
     }
     else{
         Debug.Log("No file found");
         return null;
     }
}
}
