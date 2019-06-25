using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettingsData 
{
 public float soundVolume;
 public float musicVolume;


 public SettingsData(Settings setting)
 {
     soundVolume= setting.getvolumeSound();
     musicVolume=setting.getvolumeMusic();
 }
}

